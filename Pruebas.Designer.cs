namespace practica10fun2
{
    partial class Pruebas
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
            this.mostrarContraseña = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_acontraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_ausuario = new System.Windows.Forms.TextBox();
            this.InicioAdmin = new System.Windows.Forms.GroupBox();
            this.InicioAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mostrarContraseña
            // 
            this.mostrarContraseña.AutoSize = true;
            this.mostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mostrarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.mostrarContraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mostrarContraseña.Location = new System.Drawing.Point(25, 202);
            this.mostrarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.mostrarContraseña.Name = "mostrarContraseña";
            this.mostrarContraseña.Size = new System.Drawing.Size(158, 22);
            this.mostrarContraseña.TabIndex = 23;
            this.mostrarContraseña.Text = "Mostrar Contraseña";
            this.mostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(29, 248);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 99);
            this.button1.TabIndex = 20;
            this.button1.Text = "Iniciar Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Contraseña";
            // 
            // tx_acontraseña
            // 
            this.tx_acontraseña.Location = new System.Drawing.Point(25, 152);
            this.tx_acontraseña.Margin = new System.Windows.Forms.Padding(2);
            this.tx_acontraseña.Name = "tx_acontraseña";
            this.tx_acontraseña.PasswordChar = '*';
            this.tx_acontraseña.Size = new System.Drawing.Size(272, 20);
            this.tx_acontraseña.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Usuario";
            // 
            // tx_ausuario
            // 
            this.tx_ausuario.Location = new System.Drawing.Point(25, 73);
            this.tx_ausuario.Margin = new System.Windows.Forms.Padding(2);
            this.tx_ausuario.Name = "tx_ausuario";
            this.tx_ausuario.Size = new System.Drawing.Size(272, 20);
            this.tx_ausuario.TabIndex = 18;
            // 
            // InicioAdmin
            // 
            this.InicioAdmin.Controls.Add(this.mostrarContraseña);
            this.InicioAdmin.Controls.Add(this.button1);
            this.InicioAdmin.Controls.Add(this.label2);
            this.InicioAdmin.Controls.Add(this.tx_acontraseña);
            this.InicioAdmin.Controls.Add(this.label1);
            this.InicioAdmin.Controls.Add(this.tx_ausuario);
            this.InicioAdmin.Location = new System.Drawing.Point(340, 54);
            this.InicioAdmin.Name = "InicioAdmin";
            this.InicioAdmin.Size = new System.Drawing.Size(317, 371);
            this.InicioAdmin.TabIndex = 24;
            this.InicioAdmin.TabStop = false;
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InicioAdmin);
            this.Name = "Pruebas";
            this.Text = "Pruebas";
            this.InicioAdmin.ResumeLayout(false);
            this.InicioAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox mostrarContraseña;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_acontraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_ausuario;
        private System.Windows.Forms.GroupBox InicioAdmin;
    }
}