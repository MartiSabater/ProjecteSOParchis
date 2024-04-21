namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.consultasLabel = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.consultasBox = new System.Windows.Forms.GroupBox();
            this.consultasNombretextBox = new System.Windows.Forms.TextBox();
            this.consulta3 = new System.Windows.Forms.RadioButton();
            this.consulta2 = new System.Windows.Forms.RadioButton();
            this.consulta1 = new System.Windows.Forms.RadioButton();
            this.loginButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.loginEntrarButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginContraseñatextBox = new System.Windows.Forms.TextBox();
            this.loginUsuariotextBox = new System.Windows.Forms.TextBox();
            this.loginContraseñaLabel = new System.Windows.Forms.Label();
            this.loginUsuarioLabel = new System.Windows.Forms.Label();
            this.signupRegistrarButton = new System.Windows.Forms.Button();
            this.signupCorreotextBox = new System.Windows.Forms.TextBox();
            this.signupCorreoLabel = new System.Windows.Forms.Label();
            this.signupLabel = new System.Windows.Forms.Label();
            this.signupContraseñatextBox = new System.Windows.Forms.TextBox();
            this.signupUsuariotextBox = new System.Windows.Forms.TextBox();
            this.signupContraseñaLabel = new System.Windows.Forms.Label();
            this.signupUsuarioLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desconectarButton = new System.Windows.Forms.Button();
            this.listaConectadosButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultasBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // consultasLabel
            // 
            this.consultasLabel.AutoSize = true;
            this.consultasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasLabel.Location = new System.Drawing.Point(24, 23);
            this.consultasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.consultasLabel.Name = "consultasLabel";
            this.consultasLabel.Size = new System.Drawing.Size(260, 25);
            this.consultasLabel.TabIndex = 1;
            this.consultasLabel.Text = "Seleccione una consulta, ";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(246, 109);
            this.IP.Margin = new System.Windows.Forms.Padding(4);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(193, 22);
            this.IP.TabIndex = 2;
            this.IP.Text = "192.168.56.102";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(173, 193);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // consultasBox
            // 
            this.consultasBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.consultasBox.Controls.Add(this.consultasNombretextBox);
            this.consultasBox.Controls.Add(this.consulta3);
            this.consultasBox.Controls.Add(this.consulta2);
            this.consultasBox.Controls.Add(this.consulta1);
            this.consultasBox.Controls.Add(this.consultasLabel);
            this.consultasBox.Controls.Add(this.button2);
            this.consultasBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.consultasBox.Location = new System.Drawing.Point(773, 13);
            this.consultasBox.Margin = new System.Windows.Forms.Padding(4);
            this.consultasBox.Name = "consultasBox";
            this.consultasBox.Padding = new System.Windows.Forms.Padding(4);
            this.consultasBox.Size = new System.Drawing.Size(479, 256);
            this.consultasBox.TabIndex = 6;
            this.consultasBox.TabStop = false;
            this.consultasBox.Visible = false;
            // 
            // consultasNombretextBox
            // 
            this.consultasNombretextBox.Enabled = false;
            this.consultasNombretextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasNombretextBox.Location = new System.Drawing.Point(275, 20);
            this.consultasNombretextBox.Name = "consultasNombretextBox";
            this.consultasNombretextBox.Size = new System.Drawing.Size(188, 30);
            this.consultasNombretextBox.TabIndex = 14;
            // 
            // consulta3
            // 
            this.consulta3.AutoSize = true;
            this.consulta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulta3.Location = new System.Drawing.Point(38, 164);
            this.consulta3.Margin = new System.Windows.Forms.Padding(4);
            this.consulta3.Name = "consulta3";
            this.consulta3.Size = new System.Drawing.Size(120, 24);
            this.consulta3.TabIndex = 9;
            this.consulta3.TabStop = true;
            this.consulta3.Text = "Consulta 3";
            this.consulta3.UseVisualStyleBackColor = true;
            // 
            // consulta2
            // 
            this.consulta2.AutoSize = true;
            this.consulta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulta2.Location = new System.Drawing.Point(38, 120);
            this.consulta2.Margin = new System.Windows.Forms.Padding(4);
            this.consulta2.Name = "consulta2";
            this.consulta2.Size = new System.Drawing.Size(120, 24);
            this.consulta2.TabIndex = 7;
            this.consulta2.TabStop = true;
            this.consulta2.Text = "Consulta 2";
            this.consulta2.UseVisualStyleBackColor = true;
            // 
            // consulta1
            // 
            this.consulta1.AutoSize = true;
            this.consulta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulta1.Location = new System.Drawing.Point(38, 73);
            this.consulta1.Margin = new System.Windows.Forms.Padding(4);
            this.consulta1.Name = "consulta1";
            this.consulta1.Size = new System.Drawing.Size(288, 24);
            this.consulta1.TabIndex = 8;
            this.consulta1.TabStop = true;
            this.consulta1.Text = "Número de partidas realizadas";
            this.consulta1.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(288, 313);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(151, 51);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(288, 246);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(151, 51);
            this.signupButton.TabIndex = 10;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // loginEntrarButton
            // 
            this.loginEntrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEntrarButton.Location = new System.Drawing.Point(134, 480);
            this.loginEntrarButton.Name = "loginEntrarButton";
            this.loginEntrarButton.Size = new System.Drawing.Size(99, 40);
            this.loginEntrarButton.TabIndex = 16;
            this.loginEntrarButton.Text = "Entrar";
            this.loginEntrarButton.UseVisualStyleBackColor = true;
            this.loginEntrarButton.Visible = false;
            this.loginEntrarButton.Click += new System.EventHandler(this.loginEntrarButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(143, 352);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(90, 32);
            this.loginLabel.TabIndex = 15;
            this.loginLabel.Text = "Login";
            this.loginLabel.Visible = false;
            // 
            // loginContraseñatextBox
            // 
            this.loginContraseñatextBox.Location = new System.Drawing.Point(110, 443);
            this.loginContraseñatextBox.Name = "loginContraseñatextBox";
            this.loginContraseñatextBox.PasswordChar = '*';
            this.loginContraseñatextBox.Size = new System.Drawing.Size(188, 22);
            this.loginContraseñatextBox.TabIndex = 14;
            this.loginContraseñatextBox.Visible = false;
            // 
            // loginUsuariotextBox
            // 
            this.loginUsuariotextBox.Location = new System.Drawing.Point(110, 404);
            this.loginUsuariotextBox.Name = "loginUsuariotextBox";
            this.loginUsuariotextBox.Size = new System.Drawing.Size(188, 22);
            this.loginUsuariotextBox.TabIndex = 13;
            this.loginUsuariotextBox.Visible = false;
            // 
            // loginContraseñaLabel
            // 
            this.loginContraseñaLabel.AutoSize = true;
            this.loginContraseñaLabel.Location = new System.Drawing.Point(14, 443);
            this.loginContraseñaLabel.Name = "loginContraseñaLabel";
            this.loginContraseñaLabel.Size = new System.Drawing.Size(90, 16);
            this.loginContraseñaLabel.TabIndex = 12;
            this.loginContraseñaLabel.Text = "Contraseña:";
            this.loginContraseñaLabel.Visible = false;
            // 
            // loginUsuarioLabel
            // 
            this.loginUsuarioLabel.AutoSize = true;
            this.loginUsuarioLabel.Location = new System.Drawing.Point(44, 404);
            this.loginUsuarioLabel.Name = "loginUsuarioLabel";
            this.loginUsuarioLabel.Size = new System.Drawing.Size(69, 16);
            this.loginUsuarioLabel.TabIndex = 11;
            this.loginUsuarioLabel.Text = "Usuario: ";
            this.loginUsuarioLabel.Visible = false;
            // 
            // signupRegistrarButton
            // 
            this.signupRegistrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupRegistrarButton.Location = new System.Drawing.Point(539, 519);
            this.signupRegistrarButton.Name = "signupRegistrarButton";
            this.signupRegistrarButton.Size = new System.Drawing.Size(109, 45);
            this.signupRegistrarButton.TabIndex = 24;
            this.signupRegistrarButton.Text = "Registrar";
            this.signupRegistrarButton.UseVisualStyleBackColor = true;
            this.signupRegistrarButton.Visible = false;
            this.signupRegistrarButton.Click += new System.EventHandler(this.signupRegistrarButton_Click);
            // 
            // signupCorreotextBox
            // 
            this.signupCorreotextBox.Location = new System.Drawing.Point(457, 404);
            this.signupCorreotextBox.Name = "signupCorreotextBox";
            this.signupCorreotextBox.Size = new System.Drawing.Size(278, 22);
            this.signupCorreotextBox.TabIndex = 23;
            this.signupCorreotextBox.Visible = false;
            // 
            // signupCorreoLabel
            // 
            this.signupCorreoLabel.AutoSize = true;
            this.signupCorreoLabel.Location = new System.Drawing.Point(312, 407);
            this.signupCorreoLabel.Name = "signupCorreoLabel";
            this.signupCorreoLabel.Size = new System.Drawing.Size(139, 16);
            this.signupCorreoLabel.TabIndex = 22;
            this.signupCorreoLabel.Text = "Correo electrónico:";
            this.signupCorreoLabel.Visible = false;
            // 
            // signupLabel
            // 
            this.signupLabel.AutoSize = true;
            this.signupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLabel.Location = new System.Drawing.Point(496, 352);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(122, 32);
            this.signupLabel.TabIndex = 21;
            this.signupLabel.Text = "Sign Up";
            this.signupLabel.Visible = false;
            // 
            // signupContraseñatextBox
            // 
            this.signupContraseñatextBox.Location = new System.Drawing.Point(457, 480);
            this.signupContraseñatextBox.Name = "signupContraseñatextBox";
            this.signupContraseñatextBox.PasswordChar = '*';
            this.signupContraseñatextBox.Size = new System.Drawing.Size(278, 22);
            this.signupContraseñatextBox.TabIndex = 20;
            this.signupContraseñatextBox.Visible = false;
            // 
            // signupUsuariotextBox
            // 
            this.signupUsuariotextBox.Location = new System.Drawing.Point(457, 441);
            this.signupUsuariotextBox.Name = "signupUsuariotextBox";
            this.signupUsuariotextBox.Size = new System.Drawing.Size(278, 22);
            this.signupUsuariotextBox.TabIndex = 19;
            this.signupUsuariotextBox.Visible = false;
            // 
            // signupContraseñaLabel
            // 
            this.signupContraseñaLabel.AutoSize = true;
            this.signupContraseñaLabel.Location = new System.Drawing.Point(361, 480);
            this.signupContraseñaLabel.Name = "signupContraseñaLabel";
            this.signupContraseñaLabel.Size = new System.Drawing.Size(90, 16);
            this.signupContraseñaLabel.TabIndex = 18;
            this.signupContraseñaLabel.Text = "Contraseña:";
            this.signupContraseñaLabel.Visible = false;
            // 
            // signupUsuarioLabel
            // 
            this.signupUsuarioLabel.AutoSize = true;
            this.signupUsuarioLabel.Location = new System.Drawing.Point(391, 441);
            this.signupUsuarioLabel.Name = "signupUsuarioLabel";
            this.signupUsuarioLabel.Size = new System.Drawing.Size(69, 16);
            this.signupUsuarioLabel.TabIndex = 17;
            this.signupUsuarioLabel.Text = "Usuario: ";
            this.signupUsuarioLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(229, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 46);
            this.label2.TabIndex = 25;
            this.label2.Text = "Parchis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(379, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 46);
            this.label3.TabIndex = 26;
            this.label3.Text = ".com";
            // 
            // desconectarButton
            // 
            this.desconectarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desconectarButton.Location = new System.Drawing.Point(473, 147);
            this.desconectarButton.Margin = new System.Windows.Forms.Padding(4);
            this.desconectarButton.Name = "desconectarButton";
            this.desconectarButton.Size = new System.Drawing.Size(126, 42);
            this.desconectarButton.TabIndex = 27;
            this.desconectarButton.Text = "Desconectar";
            this.desconectarButton.UseVisualStyleBackColor = true;
            this.desconectarButton.Click += new System.EventHandler(this.desconectarButton_Click);
            // 
            // listaConectadosButton
            // 
            this.listaConectadosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaConectadosButton.Location = new System.Drawing.Point(834, 319);
            this.listaConectadosButton.Name = "listaConectadosButton";
            this.listaConectadosButton.Size = new System.Drawing.Size(199, 65);
            this.listaConectadosButton.TabIndex = 28;
            this.listaConectadosButton.Text = "Lista de conectados";
            this.listaConectadosButton.UseVisualStyleBackColor = true;
            this.listaConectadosButton.Click += new System.EventHandler(this.listaConectadosButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario});
            this.dataGridView1.Location = new System.Drawing.Point(834, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(265, 235);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuarios conectados";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1410, 818);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listaConectadosButton);
            this.Controls.Add(this.desconectarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signupRegistrarButton);
            this.Controls.Add(this.signupCorreotextBox);
            this.Controls.Add(this.signupCorreoLabel);
            this.Controls.Add(this.signupLabel);
            this.Controls.Add(this.signupContraseñatextBox);
            this.Controls.Add(this.signupUsuariotextBox);
            this.Controls.Add(this.signupContraseñaLabel);
            this.Controls.Add(this.signupUsuarioLabel);
            this.Controls.Add(this.loginEntrarButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginContraseñatextBox);
            this.Controls.Add(this.loginUsuariotextBox);
            this.Controls.Add(this.loginContraseñaLabel);
            this.Controls.Add(this.loginUsuarioLabel);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.consultasBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.consultasBox.ResumeLayout(false);
            this.consultasBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label consultasLabel;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox consultasBox;
        private System.Windows.Forms.RadioButton consulta2;
        private System.Windows.Forms.RadioButton consulta1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.RadioButton consulta3;
        private System.Windows.Forms.Button loginEntrarButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginContraseñatextBox;
        private System.Windows.Forms.TextBox loginUsuariotextBox;
        private System.Windows.Forms.Label loginContraseñaLabel;
        private System.Windows.Forms.Label loginUsuarioLabel;
        private System.Windows.Forms.Button signupRegistrarButton;
        private System.Windows.Forms.TextBox signupCorreotextBox;
        private System.Windows.Forms.Label signupCorreoLabel;
        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.TextBox signupContraseñatextBox;
        private System.Windows.Forms.TextBox signupUsuariotextBox;
        private System.Windows.Forms.Label signupContraseñaLabel;
        private System.Windows.Forms.Label signupUsuarioLabel;
        private System.Windows.Forms.TextBox consultasNombretextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button desconectarButton;
        private System.Windows.Forms.Button listaConectadosButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}

