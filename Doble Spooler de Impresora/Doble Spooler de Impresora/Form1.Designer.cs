namespace Doble_Spooler_de_Impresora
{
    partial class Form1
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
            this.PanelCantidad = new System.Windows.Forms.Panel();
            this.btnTipos = new System.Windows.Forms.Button();
            this.txtTipoB = new System.Windows.Forms.TextBox();
            this.txtTipoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelTipoA = new System.Windows.Forms.Panel();
            this.LSImpresos = new System.Windows.Forms.ListBox();
            this.BTNImprimir = new System.Windows.Forms.Button();
            this.CBXTipotrabajo = new System.Windows.Forms.ComboBox();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelTipoB = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelCantidad.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCantidad
            // 
            this.PanelCantidad.Controls.Add(this.btnTipos);
            this.PanelCantidad.Controls.Add(this.txtTipoB);
            this.PanelCantidad.Controls.Add(this.txtTipoA);
            this.PanelCantidad.Controls.Add(this.label2);
            this.PanelCantidad.Controls.Add(this.label1);
            this.PanelCantidad.Location = new System.Drawing.Point(114, 60);
            this.PanelCantidad.Name = "PanelCantidad";
            this.PanelCantidad.Size = new System.Drawing.Size(782, 306);
            this.PanelCantidad.TabIndex = 0;
            // 
            // btnTipos
            // 
            this.btnTipos.Location = new System.Drawing.Point(244, 148);
            this.btnTipos.Name = "btnTipos";
            this.btnTipos.Size = new System.Drawing.Size(283, 73);
            this.btnTipos.TabIndex = 4;
            this.btnTipos.Text = "Empezar";
            this.btnTipos.UseVisualStyleBackColor = true;
            this.btnTipos.Click += new System.EventHandler(this.btnTipos_Click);
            // 
            // txtTipoB
            // 
            this.txtTipoB.Location = new System.Drawing.Point(528, 76);
            this.txtTipoB.Name = "txtTipoB";
            this.txtTipoB.Size = new System.Drawing.Size(195, 22);
            this.txtTipoB.TabIndex = 3;
            this.txtTipoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoB_KeyPress);
            // 
            // txtTipoA
            // 
            this.txtTipoA.Location = new System.Drawing.Point(50, 76);
            this.txtTipoA.Name = "txtTipoA";
            this.txtTipoA.Size = new System.Drawing.Size(195, 22);
            this.txtTipoA.TabIndex = 2;
            this.txtTipoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de impresoras tipo B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de impresoras tipo A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.PanelTipoA);
            this.PanelPrincipal.Controls.Add(this.LSImpresos);
            this.PanelPrincipal.Controls.Add(this.BTNImprimir);
            this.PanelPrincipal.Controls.Add(this.CBXTipotrabajo);
            this.PanelPrincipal.Controls.Add(this.txtmensaje);
            this.PanelPrincipal.Controls.Add(this.label5);
            this.PanelPrincipal.Controls.Add(this.label4);
            this.PanelPrincipal.Controls.Add(this.PanelTipoB);
            this.PanelPrincipal.Controls.Add(this.label3);
            this.PanelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(989, 474);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // PanelTipoA
            // 
            this.PanelTipoA.AutoScroll = true;
            this.PanelTipoA.Location = new System.Drawing.Point(3, 18);
            this.PanelTipoA.Name = "PanelTipoA";
            this.PanelTipoA.Size = new System.Drawing.Size(983, 100);
            this.PanelTipoA.TabIndex = 0;
            this.PanelTipoA.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTipoA_Paint);
            // 
            // LSImpresos
            // 
            this.LSImpresos.FormattingEnabled = true;
            this.LSImpresos.ItemHeight = 16;
            this.LSImpresos.Location = new System.Drawing.Point(559, 252);
            this.LSImpresos.Name = "LSImpresos";
            this.LSImpresos.Size = new System.Drawing.Size(410, 212);
            this.LSImpresos.TabIndex = 9;
            this.LSImpresos.SelectedIndexChanged += new System.EventHandler(this.LSImpresos_SelectedIndexChanged);
            // 
            // BTNImprimir
            // 
            this.BTNImprimir.Location = new System.Drawing.Point(346, 327);
            this.BTNImprimir.Name = "BTNImprimir";
            this.BTNImprimir.Size = new System.Drawing.Size(103, 29);
            this.BTNImprimir.TabIndex = 8;
            this.BTNImprimir.Text = "Imprimir";
            this.BTNImprimir.UseVisualStyleBackColor = true;
            this.BTNImprimir.Click += new System.EventHandler(this.BTNImprimir_Click);
            // 
            // CBXTipotrabajo
            // 
            this.CBXTipotrabajo.FormattingEnabled = true;
            this.CBXTipotrabajo.Items.AddRange(new object[] {
            "Tipo de trabajo a imprimir",
            "(A)",
            "(B)",
            "(C)"});
            this.CBXTipotrabajo.Location = new System.Drawing.Point(302, 284);
            this.CBXTipotrabajo.Name = "CBXTipotrabajo";
            this.CBXTipotrabajo.Size = new System.Drawing.Size(188, 24);
            this.CBXTipotrabajo.TabIndex = 7;
            this.CBXTipotrabajo.SelectedIndexChanged += new System.EventHandler(this.CBXTipotrabajo_SelectedIndexChanged);
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(38, 284);
            this.txtmensaje.Multiline = true;
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(246, 72);
            this.txtmensaje.TabIndex = 5;
            this.txtmensaje.TextChanged += new System.EventHandler(this.txtmensaje_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mensaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(465, 119);
            this.label4.MaximumSize = new System.Drawing.Size(100, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo B";
            // 
            // PanelTipoB
            // 
            this.PanelTipoB.AutoScroll = true;
            this.PanelTipoB.Location = new System.Drawing.Point(3, 139);
            this.PanelTipoB.Name = "PanelTipoB";
            this.PanelTipoB.Size = new System.Drawing.Size(983, 100);
            this.PanelTipoB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(465, 0);
            this.label3.MaximumSize = new System.Drawing.Size(100, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo A";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 524);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelCantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelCantidad.ResumeLayout(false);
            this.PanelCantidad.PerformLayout();
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTipos;
        private System.Windows.Forms.TextBox txtTipoB;
        private System.Windows.Forms.TextBox txtTipoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelTipoA;
        private System.Windows.Forms.ComboBox CBXTipotrabajo;
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelTipoB;
        private System.Windows.Forms.ListBox LSImpresos;
        private System.Windows.Forms.Button BTNImprimir;

    }
}

