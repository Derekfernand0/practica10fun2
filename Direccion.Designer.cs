namespace practica10fun2
{
    partial class Direccion
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
            this.CX = new System.Windows.Forms.Label();
            this.tx_CX = new System.Windows.Forms.TextBox();
            this.tx_CY = new System.Windows.Forms.TextBox();
            this.CY = new System.Windows.Forms.Label();
            this.tx_CZ = new System.Windows.Forms.TextBox();
            this.CZ = new System.Windows.Forms.Label();
            this.tx_Ra = new System.Windows.Forms.TextBox();
            this.Ra = new System.Windows.Forms.Label();
            this.tx_EA = new System.Windows.Forms.TextBox();
            this.EA = new System.Windows.Forms.Label();
            this.AR = new System.Windows.Forms.Button();
            this.Cr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CX
            // 
            this.CX.AutoSize = true;
            this.CX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CX.Location = new System.Drawing.Point(41, 9);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(134, 24);
            this.CX.TabIndex = 0;
            this.CX.Text = "Coordenada X";
            // 
            // tx_CX
            // 
            this.tx_CX.Location = new System.Drawing.Point(29, 45);
            this.tx_CX.Name = "tx_CX";
            this.tx_CX.Size = new System.Drawing.Size(160, 20);
            this.tx_CX.TabIndex = 1;
            // 
            // tx_CY
            // 
            this.tx_CY.Location = new System.Drawing.Point(294, 54);
            this.tx_CY.Name = "tx_CY";
            this.tx_CY.Size = new System.Drawing.Size(160, 20);
            this.tx_CY.TabIndex = 3;
            // 
            // CY
            // 
            this.CY.AutoSize = true;
            this.CY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CY.Location = new System.Drawing.Point(304, 9);
            this.CY.Name = "CY";
            this.CY.Size = new System.Drawing.Size(132, 24);
            this.CY.TabIndex = 2;
            this.CY.Text = "Coordenada Y";
            // 
            // tx_CZ
            // 
            this.tx_CZ.Location = new System.Drawing.Point(574, 54);
            this.tx_CZ.Name = "tx_CZ";
            this.tx_CZ.Size = new System.Drawing.Size(160, 20);
            this.tx_CZ.TabIndex = 5;
            // 
            // CZ
            // 
            this.CZ.AutoSize = true;
            this.CZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CZ.Location = new System.Drawing.Point(540, 9);
            this.CZ.Name = "CZ";
            this.CZ.Size = new System.Drawing.Size(221, 24);
            this.CZ.TabIndex = 4;
            this.CZ.Text = "Coordenada Z (opcional)";
            // 
            // tx_Ra
            // 
            this.tx_Ra.Location = new System.Drawing.Point(76, 201);
            this.tx_Ra.Name = "tx_Ra";
            this.tx_Ra.Size = new System.Drawing.Size(160, 20);
            this.tx_Ra.TabIndex = 7;
            // 
            // Ra
            // 
            this.Ra.AutoSize = true;
            this.Ra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ra.Location = new System.Drawing.Point(108, 144);
            this.Ra.Name = "Ra";
            this.Ra.Size = new System.Drawing.Size(101, 24);
            this.Ra.TabIndex = 6;
            this.Ra.Text = "Referencia";
            // 
            // tx_EA
            // 
            this.tx_EA.Location = new System.Drawing.Point(502, 201);
            this.tx_EA.Name = "tx_EA";
            this.tx_EA.Size = new System.Drawing.Size(160, 20);
            this.tx_EA.TabIndex = 9;
            // 
            // EA
            // 
            this.EA.AutoSize = true;
            this.EA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EA.Location = new System.Drawing.Point(432, 144);
            this.EA.Name = "EA";
            this.EA.Size = new System.Drawing.Size(318, 24);
            this.EA.TabIndex = 8;
            this.EA.Text = "en caso de no responder entregar a:";
            // 
            // AR
            // 
            this.AR.Location = new System.Drawing.Point(413, 288);
            this.AR.Name = "AR";
            this.AR.Size = new System.Drawing.Size(128, 35);
            this.AR.TabIndex = 10;
            this.AR.Text = "Aceptar y continuar";
            this.AR.UseVisualStyleBackColor = true;
            // 
            // Cr
            // 
            this.Cr.Location = new System.Drawing.Point(220, 288);
            this.Cr.Name = "Cr";
            this.Cr.Size = new System.Drawing.Size(128, 35);
            this.Cr.TabIndex = 11;
            this.Cr.Text = "Cancelar";
            this.Cr.UseVisualStyleBackColor = true;
            // 
            // Direccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cr);
            this.Controls.Add(this.AR);
            this.Controls.Add(this.tx_EA);
            this.Controls.Add(this.EA);
            this.Controls.Add(this.tx_Ra);
            this.Controls.Add(this.Ra);
            this.Controls.Add(this.tx_CZ);
            this.Controls.Add(this.CZ);
            this.Controls.Add(this.tx_CY);
            this.Controls.Add(this.CY);
            this.Controls.Add(this.tx_CX);
            this.Controls.Add(this.CX);
            this.Name = "Direccion";
            this.Text = "Direccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CX;
        private System.Windows.Forms.TextBox tx_CX;
        private System.Windows.Forms.TextBox tx_CY;
        private System.Windows.Forms.Label CY;
        private System.Windows.Forms.TextBox tx_CZ;
        private System.Windows.Forms.Label CZ;
        private System.Windows.Forms.TextBox tx_Ra;
        private System.Windows.Forms.Label Ra;
        private System.Windows.Forms.TextBox tx_EA;
        private System.Windows.Forms.Label EA;
        private System.Windows.Forms.Button AR;
        private System.Windows.Forms.Button Cr;
    }
}