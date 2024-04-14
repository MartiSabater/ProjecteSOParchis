namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.signupContraseñatextBox = new System.Windows.Forms.TextBox();
            this.signupUsuariotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signupCorreotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signupRegistrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sign Up";
            // 
            // signupContraseñatextBox
            // 
            this.signupContraseñatextBox.Location = new System.Drawing.Point(156, 154);
            this.signupContraseñatextBox.Name = "signupContraseñatextBox";
            this.signupContraseñatextBox.Size = new System.Drawing.Size(278, 22);
            this.signupContraseñatextBox.TabIndex = 8;
            // 
            // signupUsuariotextBox
            // 
            this.signupUsuariotextBox.Location = new System.Drawing.Point(156, 115);
            this.signupUsuariotextBox.Name = "signupUsuariotextBox";
            this.signupUsuariotextBox.Size = new System.Drawing.Size(278, 22);
            this.signupUsuariotextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario: ";
            // 
            // signupCorreotextBox
            // 
            this.signupCorreotextBox.Location = new System.Drawing.Point(156, 78);
            this.signupCorreotextBox.Name = "signupCorreotextBox";
            this.signupCorreotextBox.Size = new System.Drawing.Size(278, 22);
            this.signupCorreotextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo electrónico:";
            // 
            // signupRegistrarButton
            // 
            this.signupRegistrarButton.Location = new System.Drawing.Point(192, 194);
            this.signupRegistrarButton.Name = "signupRegistrarButton";
            this.signupRegistrarButton.Size = new System.Drawing.Size(109, 45);
            this.signupRegistrarButton.TabIndex = 12;
            this.signupRegistrarButton.Text = "Registrar";
            this.signupRegistrarButton.UseVisualStyleBackColor = true;
            this.signupRegistrarButton.Click += new System.EventHandler(this.signupRegistrarButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 254);
            this.Controls.Add(this.signupRegistrarButton);
            this.Controls.Add(this.signupCorreotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signupContraseñatextBox);
            this.Controls.Add(this.signupUsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signupContraseñatextBox;
        private System.Windows.Forms.TextBox signupUsuariotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signupCorreotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signupRegistrarButton;
    }
}