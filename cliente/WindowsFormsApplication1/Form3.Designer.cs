namespace WindowsFormsApplication1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginUsuariotextBox = new System.Windows.Forms.TextBox();
            this.loginContraseñatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginEntrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // loginUsuariotextBox
            // 
            this.loginUsuariotextBox.Location = new System.Drawing.Point(131, 80);
            this.loginUsuariotextBox.Name = "loginUsuariotextBox";
            this.loginUsuariotextBox.Size = new System.Drawing.Size(188, 22);
            this.loginUsuariotextBox.TabIndex = 2;
            // 
            // loginContraseñatextBox
            // 
            this.loginContraseñatextBox.Location = new System.Drawing.Point(131, 119);
            this.loginContraseñatextBox.Name = "loginContraseñatextBox";
            this.loginContraseñatextBox.Size = new System.Drawing.Size(188, 22);
            this.loginContraseñatextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // loginEntrarButton
            // 
            this.loginEntrarButton.Location = new System.Drawing.Point(155, 161);
            this.loginEntrarButton.Name = "loginEntrarButton";
            this.loginEntrarButton.Size = new System.Drawing.Size(99, 40);
            this.loginEntrarButton.TabIndex = 5;
            this.loginEntrarButton.Text = "Entrar";
            this.loginEntrarButton.UseVisualStyleBackColor = true;
            this.loginEntrarButton.Click += new System.EventHandler(this.loginEntrarButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 225);
            this.Controls.Add(this.loginEntrarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginContraseñatextBox);
            this.Controls.Add(this.loginUsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginUsuariotextBox;
        private System.Windows.Forms.TextBox loginContraseñatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginEntrarButton;
    }
}