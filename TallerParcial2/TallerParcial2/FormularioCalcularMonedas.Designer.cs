namespace TallerParcial2
{
    partial class FormularioCalcularMonedas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OD = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.DO = new System.Windows.Forms.RadioButton();
            this.btnCalcularConversion = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.cbxOrigen = new System.Windows.Forms.ComboBox();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrigenSalida = new System.Windows.Forms.Label();
            this.txtDestinoConversion = new System.Windows.Forms.TextBox();
            this.txtValBitcoins = new System.Windows.Forms.TextBox();
            this.txtDestinoSalida = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplicación de Conversión de Monedas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Origen: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Moneda Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Moneda Origen: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tasa de Cambio:";
            // 
            // OD
            // 
            this.OD.AutoSize = true;
            this.OD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OD.Location = new System.Drawing.Point(245, 252);
            this.OD.Name = "OD";
            this.OD.Size = new System.Drawing.Size(136, 19);
            this.OD.TabIndex = 5;
            this.OD.Text = "De Origen a Destino ";
            this.OD.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dirección de Conversión: ";
            // 
            // DO
            // 
            this.DO.AutoSize = true;
            this.DO.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DO.Location = new System.Drawing.Point(245, 275);
            this.DO.Name = "DO";
            this.DO.Size = new System.Drawing.Size(133, 19);
            this.DO.TabIndex = 7;
            this.DO.Text = "De Destino a Origen";
            this.DO.UseVisualStyleBackColor = true;
            // 
            // btnCalcularConversion
            // 
            this.btnCalcularConversion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularConversion.Location = new System.Drawing.Point(467, 249);
            this.btnCalcularConversion.Name = "btnCalcularConversion";
            this.btnCalcularConversion.Size = new System.Drawing.Size(132, 36);
            this.btnCalcularConversion.TabIndex = 8;
            this.btnCalcularConversion.Text = "Calcular Conversión";
            this.btnCalcularConversion.UseVisualStyleBackColor = true;
            this.btnCalcularConversion.Click += new System.EventHandler(this.btnCalcularConversion_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(624, 247);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(132, 36);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // cbxOrigen
            // 
            this.cbxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrigen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrigen.Items.AddRange(new object[] {
            "Dólares Americanos",
            "Euros",
            "Yuanes (Renminbi)",
            "Yenes Japoneses",
            "Pesos Colombianos"});
            this.cbxOrigen.Location = new System.Drawing.Point(175, 180);
            this.cbxOrigen.Name = "cbxOrigen";
            this.cbxOrigen.Size = new System.Drawing.Size(140, 23);
            this.cbxOrigen.TabIndex = 10;
            // 
            // cbxDestino
            // 
            this.cbxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDestino.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Items.AddRange(new object[] {
            "Dólares Americanos",
            "Euros",
            "Yuanes (Renminbi)",
            "Yenes Japoneses",
            "Pesos Colombianos"});
            this.cbxDestino.Location = new System.Drawing.Point(584, 180);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(140, 23);
            this.cbxDestino.TabIndex = 11;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(175, 123);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(140, 22);
            this.txtOrigen.TabIndex = 12;
            // 
            // txtTasa
            // 
            this.txtTasa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasa.Location = new System.Drawing.Point(584, 123);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(140, 22);
            this.txtTasa.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor Origen: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor Destino: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Valor en Bitcoins:  ";
            // 
            // txtOrigenSalida
            // 
            this.txtOrigenSalida.AutoSize = true;
            this.txtOrigenSalida.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigenSalida.Location = new System.Drawing.Point(189, 377);
            this.txtOrigenSalida.Name = "txtOrigenSalida";
            this.txtOrigenSalida.Size = new System.Drawing.Size(0, 21);
            this.txtOrigenSalida.TabIndex = 17;
            // 
            // txtDestinoConversion
            // 
            this.txtDestinoConversion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinoConversion.Location = new System.Drawing.Point(193, 424);
            this.txtDestinoConversion.Name = "txtDestinoConversion";
            this.txtDestinoConversion.ReadOnly = true;
            this.txtDestinoConversion.Size = new System.Drawing.Size(164, 22);
            this.txtDestinoConversion.TabIndex = 18;
            // 
            // txtValBitcoins
            // 
            this.txtValBitcoins.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValBitcoins.Location = new System.Drawing.Point(193, 466);
            this.txtValBitcoins.Name = "txtValBitcoins";
            this.txtValBitcoins.ReadOnly = true;
            this.txtValBitcoins.Size = new System.Drawing.Size(164, 22);
            this.txtValBitcoins.TabIndex = 19;
            // 
            // txtDestinoSalida
            // 
            this.txtDestinoSalida.AutoSize = true;
            this.txtDestinoSalida.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinoSalida.Location = new System.Drawing.Point(363, 424);
            this.txtDestinoSalida.Name = "txtDestinoSalida";
            this.txtDestinoSalida.Size = new System.Drawing.Size(0, 21);
            this.txtDestinoSalida.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(137, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 31);
            this.label10.TabIndex = 21;
            this.label10.Text = "Resultados de Conversión";
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.Location = new System.Drawing.Point(467, 377);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(132, 36);
            this.btnAcercaDe.TabIndex = 22;
            this.btnAcercaDe.Text = "Acerca De";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(624, 377);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 36);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir ";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormularioCalcularMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDestinoSalida);
            this.Controls.Add(this.txtValBitcoins);
            this.Controls.Add(this.txtDestinoConversion);
            this.Controls.Add(this.txtOrigenSalida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.cbxOrigen);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnCalcularConversion);
            this.Controls.Add(this.DO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormularioCalcularMonedas";
            this.Text = "ConversiónDivisas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton OD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton DO;
        private System.Windows.Forms.Button btnCalcularConversion;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ComboBox cbxOrigen;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtOrigenSalida;
        private System.Windows.Forms.TextBox txtDestinoConversion;
        private System.Windows.Forms.TextBox txtValBitcoins;
        private System.Windows.Forms.Label txtDestinoSalida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnSalir;
    }
}

