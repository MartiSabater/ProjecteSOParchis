#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <pthread.h>

char ubicacion[20];

int i = 0;
int sockets[100];

void *AtenderCliente (void *socket)
{
	//strcpy(ubicacion, "localhost");
	strcpy(ubicacion, "shiva2.upc.es");
	int sock_conn;
	int *s;
	s = (int *) socket;
	sock_conn = *s;
	char buff[512];
	char buff2[512];
	int ret;
	
	
	//Inicio el MYSQL
	MYSQL *conn;
	int err;
	// Estructura necessaria para acesso excluyente
	pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;
	
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexi\ufff3n: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexin
	conn = mysql_real_connect (conn, ubicacion,"root", "mysql", "M4_BBDDParchis",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}	
	int terminar = 0;
	//Entramos en un bucle para atender todas las peticiones de este clientes.
	//Hasta que se desconecte
	while(terminar==0)
	{
		
		// Ahora recibimos su nombre, que dejamos en buff
		ret=read(sock_conn,buff, sizeof(buff));
		printf ("Recibido\n");
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		buff[ret]='\0';
		
		//Escribimos el nombre en la consola
		
		printf ("Se ha conectado: %s\n",buff);
		char nomUsuario[20];
		char contra[20];
		int resultado_numerico;
		
		
		char *p = strtok( buff, "/");
		int codigo =  atoi (p);	
		
		if (codigo == 0) 
		{       
			char usuario[50];
			
			p = strtok(NULL, "/");
			strcpy(usuario, p);
			
			char consulta[1000];
			strcpy(consulta, "");
			
			sprintf(consulta, "DELETE FROM conectados WHERE Nombre_Usuario = '%s';", usuario);
			err = mysql_query(conn, consulta);
			if(err != 0) {
				printf("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit(1);
			}           
			terminar = 1;
		}
		//Registre del Usuari
		if (codigo == 1)
		{
			char correo[50];
			
			p= strtok(NULL, "/");
			strcpy(correo, p);
			
			p= strtok(NULL, "/");
			strcpy(nomUsuario, p);
			
			p= strtok(NULL, "/");
			strcpy(contra, p);
			
			//Comprobo que el usuario no existeix
			pthread_mutex_lock(&mutex);
			
			char consulta [1000];
			char consulta2 [1000];
			strcpy(consulta, "SELECT * FROM usuario WHERE Nombre_Usuario = '");
			strcat(consulta, nomUsuario);
			strcat(consulta, "';");
			
			err = mysql_query (conn, consulta);
			if(err!=0){
				printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
				
				exit (1);
			}
			//Recollim el resultat de la consulta.
			resultado = mysql_store_result(conn);
			//ahora busco la fila de del usuario.
			row = mysql_fetch_row (resultado);
			int n_rows = mysql_num_rows(resultado);
			
			pthread_mutex_unlock(&mutex);
			
			
			//si la contrasenya i el nom d'usuari son correctes no sera null.
			if(n_rows == 0)
			{
				strcpy(buff2, "1/0");
				
				pthread_mutex_lock(&mutex);
				
				//Afegeixo el usuari a la base de dades
				char consulta [1000];
				char consulta2 [1000];
				strcpy(consulta, "");
				strcpy(consulta2, "");
				strcpy(consulta, "INSERT INTO usuario (Nombre_Usuario, Fecha_Registro, Correo, Passwd, ELO_Actual, ELO_Mas_Alto, Num_Partidas, Porcentaje_1er_Puesto, Porcentaje_2do_Puesto, Porcentaje_3er_Puesto, Porcentaje_4to_Puesto, Puntuacion_Media_Por_Partida, Racha_Victorias, Partidas_ID, Contrincantes_ID, Amigos_ID, Num_Amigo) ");
				strcat(consulta, "VALUES ('");
				strcat(consulta, nomUsuario);
				strcat(consulta, "', '2024-03-10', '");
				
				strcat(consulta, correo);
				strcat(consulta, "', '");
				strcat(consulta, contra);
				strcat(consulta, "', 1200, 1300, 50, 25.0, 30.0, 20.0, 25.0, 7.5, 3, 1, 2, 3, 123);");
				
				err = mysql_query (conn, consulta);
				if(err!=0){
					printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
					
					exit (1);
				}
				//Recollim el resultat de la consulta.
				resultado = mysql_store_result(conn);
				printf("Usuario registrado con exito!\n");
				sprintf(consulta2, "INSERT INTO conectados (Nombre_Usuario) VALUES ('%s');",nomUsuario);
				err = mysql_query(conn, consulta2);
				if (err!=0) {
					printf ("Error al introducir usuario conectado en la base %u %s\n", mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				
			}
			else
			{
				strcpy(buff2, "1/-1");
				printf("Ja existeix aquest usuari!\n");
			}
			
			// Y lo enviamos
			write (sock_conn, buff2, strlen(buff2));
			
			pthread_mutex_unlock(&mutex);
			
		}
		//SingIn
		if(codigo ==2)
		{			
			p= strtok(NULL, "/");
			strcpy(nomUsuario, p);
			
			p= strtok(NULL, "/");
			strcpy(contra, p);
			
			//faig la consulta
			
			pthread_mutex_lock(&mutex);
			
			
			char consulta [1000];
			char consulta2 [1000];
			strcpy(consulta, "");
			strcpy(consulta2, "");
			strcpy(consulta, "SELECT Nombre_Usuario FROM usuario WHERE Nombre_Usuario = '");
			strcat(consulta, nomUsuario);
			strcat(consulta, "' AND Passwd = '");
			strcat(consulta, contra);
			strcat(consulta, "';");
			
			err = mysql_query (conn, consulta);
			if(err!=0){
				printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
				
				exit (1);
			}
			//Recollim el resultat de la consulta.
			resultado = mysql_store_result(conn);
			//ahora busco la fila de del usuario.
			row = mysql_fetch_row (resultado);			
			
			//si la contrasenya i el nom d'usuari son correctes no sera null.
			if(row == NULL){
				strcpy(buff2, "2/-1");
				printf("No hi es!!!");
			}
			else{
				char consultaConectado[1000];
				int err2;
				
				sprintf(consultaConectado, "SELECT Nombre_Usuario FROM conectados WHERE Nombre_Usuario = '%s'", nomUsuario);
				err2 = mysql_query (conn, consultaConectado);
				if(err2!=0){
					printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
					
					exit (1);
				}
				resultado = mysql_store_result(conn);
				//ahora busco la fila de del usuario.
				row = mysql_fetch_row (resultado);	
				if(row != NULL){
					strcpy(buff2, "2/-2");
				}
				else{
					strcpy(buff2, "2/0");
					printf("Trobat!!\n");
					sprintf(consulta2, "INSERT INTO conectados (Nombre_Usuario) VALUES ('%s');",nomUsuario);
					err = mysql_query(conn, consulta2);
					if (err!=0) {
						printf ("Error al introducir usuario conectado en la base %u %s\n", mysql_errno(conn), mysql_error(conn));
						exit (1);
					}
				}
			}			
			// Y lo enviamos
			write (sock_conn, buff2, strlen(buff2));
			
			pthread_mutex_unlock(&mutex);
			
			
		}
		
		if (codigo == 3) {
			p = strtok(NULL, "/");
			strcpy(nomUsuario, p);
			
			pthread_mutex_lock(&mutex);
			
			
			char consulta[1000];
			strcpy(consulta, "SELECT Num_Partidas FROM usuario WHERE Nombre_Usuario = '");
			strcat(consulta, nomUsuario);
			strcat(consulta, "';");
			
			err = mysql_query(conn, consulta);
			if (err != 0) {
				printf("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit(1);
			}
			
			// Recogemos el resultado de la consulta.
			resultado = mysql_store_result(conn);
			if (resultado == NULL) {
				printf("Error al obtener el resultado de la consulta\n");
				exit(1);
			}
			// Ahora buscamos la fila del usuario.
			row = mysql_fetch_row(resultado);
			
			// Obtenemos el valor de Num_Partidas de la fila obtenida.
			int numPartidas = atoi(row[0]);
			printf("Numero de partidas del usuario %s: %d\n", nomUsuario, numPartidas);
			
			// Convertimos el numero de partidas a cadena para enviarlo.
			snprintf(buff2, sizeof(buff2), "3/%d", numPartidas);
			printf("Buff2: %s\n", buff2);
			// Enviamos el número de partidas.
			write(sock_conn, buff2, strlen(buff2));
			
			// Liberamos el resultado de la consulta.
			mysql_free_result(resultado);
			
			pthread_mutex_unlock(&mutex);
			
		}					
		if (codigo == 4) {
			p = strtok(NULL, "/");
			strcpy(nomUsuario, p);
			
			pthread_mutex_lock(&mutex);
			
			
			char consulta[1000];
			strcpy(consulta, "SELECT ELO_Actual FROM usuario WHERE Nombre_Usuario = '");
			strcat(consulta, nomUsuario);
			strcat(consulta, "';");
			
			err = mysql_query(conn, consulta);
			if (err != 0) {
				printf("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit(1);
			}	
			// Recogemos el resultado de la consulta.
			resultado = mysql_store_result(conn);
			if (resultado == NULL) {
				printf("Error al obtener el resultado de la consulta\n");
				exit(1);
			}
			// Ahora buscamos la fila del usuario.
			row = mysql_fetch_row(resultado);
			if (row != NULL) {
				// Obtenemos el valor de ELO_Actual de la fila obtenida.
				int eloActual = atoi(row[0]);
				printf("Elo actual de %s: %d\n", nomUsuario, eloActual);
				
				// Convertimos el Elo actual a cadena para enviarlo.
				snprintf(buff2, sizeof(buff2), "4/%d", eloActual);
				printf("Buff2: %s\n", buff2);
				
				// Enviamos el Elo actual.
				write(sock_conn, buff2, strlen(buff2));
			} else {
				printf("No se encontró al usuario %s\n", nomUsuario);
				// Enviamos un mensaje de error.
				char error_msg[] = "Usuario no encontrado";
				write(sock_conn, error_msg, strlen(error_msg));
			}
			
			// Liberamos el resultado de la consulta.
			mysql_free_result(resultado);
			
			pthread_mutex_unlock(&mutex);
			
			
		}
		
		if (codigo == 5) {
			p = strtok(NULL, "/");
			strcpy(nomUsuario, p);
			
			pthread_mutex_lock(&mutex);
			
			
			char consulta[1000];
			strcpy(consulta, "SELECT Num_Amigo FROM usuario WHERE Nombre_Usuario = '");
			strcat(consulta, nomUsuario);
			strcat(consulta, "';");
			
			err = mysql_query(conn, consulta);
			if (err != 0) {
				printf("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit(1);
			}
			
			// Recogemos el resultado de la consulta.
			resultado = mysql_store_result(conn);
			if (resultado == NULL) {
				printf("Error al obtener el resultado de la consulta\n");
				exit(1);
			}
			// Ahora buscamos la fila del resultado.
			row = mysql_fetch_row(resultado);
			
			if (row != NULL) {
				// Obtenemos el valor de Num_Amigo de la fila obtenida.
				int numAmigo = atoi(row[0]);
				printf("Número de amigo de %s: %d\n", nomUsuario, numAmigo);
				
				// Convertimos el número de amigo a cadena para enviarlo.
				snprintf(buff2, sizeof(buff2), "5/%d", numAmigo);
				printf("Buff2: %s\n", buff2);
				
				// Enviamos el número de amigo.
				write(sock_conn, buff2, strlen(buff2));	
			} 
			
			else {
				printf("No se encontró al usuario %s\n", nomUsuario);
				// Enviamos un mensaje de error.
				char error_msg[] = "Usuario no encontrado";
				write(sock_conn, error_msg, strlen(error_msg));
			}
			
			// Liberamos el resultado de la consulta.
			mysql_free_result(resultado);
			
			pthread_mutex_unlock(&mutex);
			
		}
		//Lista de conectados
		if ((codigo == 2) || (codigo== 1)|| (codigo== 3) || (codigo== 4) || (codigo==5)){		
			pthread_mutex_lock(&mutex);
			
			char consulta[1000];
			snprintf(consulta, sizeof(consulta), "SELECT Nombre_Usuario FROM conectados");
			
			err = mysql_query(conn, consulta);
			if (err != 0) {
				printf("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit(1);
			}	
			
			// Recogemos el resultado de la consulta.
			resultado = mysql_store_result(conn);
			if (resultado == NULL) {
				printf("Error al obtener el resultado de la consulta\n");
				exit(1);
			}
			// Construimos la respuesta con los nombres de usuario conectados
			char respuesta[1024] = "";
			row = mysql_fetch_row(resultado);
			if (row != NULL) {
				strcat(respuesta, row[0]);
				while ((row = mysql_fetch_row(resultado)) != NULL) {
					strcat(respuesta, ",");
					strcat(respuesta, row[0]);
				}
			} else {
				strcpy(respuesta, "0");
			}
			// Enviamos la respuesta al los clientes
			char notificacion[20];
			sprintf (notificacion, "6/%s", respuesta);
			int j;
			for (j=0; j < i; j++)
				write (sockets[j], notificacion, strlen(notificacion));
			
			
			// Liberamos el resultado de la consulta.
			mysql_free_result(resultado);
			
			pthread_mutex_unlock(&mutex);		
			
		}
			
	}		
}

int main(int argc, char *argv[])
{
	//strcpy(ubicacion, "localhost");
	strcpy(ubicacion, "shiva2.upc.es");
	//Inicio el MYSQL
	MYSQL *conn;
	int err;
	// Estructura necessaria para acesso excluyente
	pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;
	
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexi\ufff3n: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexin
	conn = mysql_real_connect (conn, ubicacion, "root", "mysql", "M4_BBDDParchis",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	char consulta[1000];
	snprintf(consulta, sizeof(consulta), "DELETE FROM conectados");
	
	err = mysql_query(conn, consulta);
	if (err != 0) {
		printf("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit(1);
	}	
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char buff[512];
	char buff2[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	
	serv_adr.sin_port = htons(50015);
	
	
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0)
		printf("Error en el Listen");	
	
	int terminar = 0;
	
	pthread_t thread;
	
	// Atenderemos solo 5 clientes
	while(terminar == 0){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		//sock_conn es el socket que usaremos para este cliente
			
	
		sockets[i] = sock_conn;
		
		//Creat thead y decirle lo que tinene que hacer
		pthread_create (&thread, NULL, AtenderCliente, &sockets[i]); 
		i++;
	}
}
