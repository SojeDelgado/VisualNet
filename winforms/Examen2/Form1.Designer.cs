namespace Examen2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.CBMoneda = new System.Windows.Forms.ComboBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblConversiones = new System.Windows.Forms.Label();
            this.lblConv1 = new System.Windows.Forms.Label();
            this.lblConv2 = new System.Windows.Forms.Label();
            this.txtConv1 = new System.Windows.Forms.TextBox();
            this.txtConv2 = new System.Windows.Forms.TextBox();
            this.txtConv3 = new System.Windows.Forms.TextBox();
            this.txtConv4 = new System.Windows.Forms.TextBox();
            this.lblConv3 = new System.Windows.Forms.Label();
            this.lblConv4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBMoneda
            // 
            this.CBMoneda.AccessibleName = "";
            this.CBMoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBMoneda.FormattingEnabled = true;
            this.CBMoneda.Items.AddRange(new object[] {
            "MXN - Peso mexicano",
            "USD - Dólar estadounidense",
            "CAD - Dólar canadiense",
            "EUR - Euro",
            "JPY - Yen japonés"});
            this.CBMoneda.Location = new System.Drawing.Point(12, 29);
            this.CBMoneda.Name = "CBMoneda";
            this.CBMoneda.Size = new System.Drawing.Size(174, 23);
            this.CBMoneda.TabIndex = 1;
            this.CBMoneda.Tag = "";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(12, 11);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(51, 15);
            this.lblMoneda.TabIndex = 3;
            this.lblMoneda.Text = "Moneda";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(202, 9);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 15);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.AccessibleName = "";
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMonto.Location = new System.Drawing.Point(202, 29);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 23);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.Tag = "";
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Location = new System.Drawing.Point(202, 58);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblConversiones
            // 
            this.lblConversiones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConversiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConversiones.Location = new System.Drawing.Point(12, 93);
            this.lblConversiones.Name = "lblConversiones";
            this.lblConversiones.Size = new System.Drawing.Size(305, 144);
            this.lblConversiones.TabIndex = 11;
            this.lblConversiones.Text = "Conversiones";
            // 
            // lblConv1
            // 
            this.lblConv1.AutoSize = true;
            this.lblConv1.Location = new System.Drawing.Point(25, 120);
            this.lblConv1.Name = "lblConv1";
            this.lblConv1.Size = new System.Drawing.Size(38, 15);
            this.lblConv1.TabIndex = 12;
            this.lblConv1.Text = "label1";
            this.lblConv1.Visible = false;
            // 
            // lblConv2
            // 
            this.lblConv2.AutoSize = true;
            this.lblConv2.Location = new System.Drawing.Point(25, 149);
            this.lblConv2.Name = "lblConv2";
            this.lblConv2.Size = new System.Drawing.Size(38, 15);
            this.lblConv2.TabIndex = 13;
            this.lblConv2.Text = "label2";
            this.lblConv2.Visible = false;
            // 
            // txtConv1
            // 
            this.txtConv1.Location = new System.Drawing.Point(202, 120);
            this.txtConv1.Name = "txtConv1";
            this.txtConv1.Size = new System.Drawing.Size(100, 23);
            this.txtConv1.TabIndex = 14;
            this.txtConv1.Visible = false;
            // 
            // txtConv2
            // 
            this.txtConv2.Location = new System.Drawing.Point(202, 149);
            this.txtConv2.Name = "txtConv2";
            this.txtConv2.Size = new System.Drawing.Size(100, 23);
            this.txtConv2.TabIndex = 15;
            this.txtConv2.Visible = false;
            // 
            // txtConv3
            // 
            this.txtConv3.Location = new System.Drawing.Point(202, 178);
            this.txtConv3.Name = "txtConv3";
            this.txtConv3.Size = new System.Drawing.Size(100, 23);
            this.txtConv3.TabIndex = 16;
            this.txtConv3.Visible = false;
            // 
            // txtConv4
            // 
            this.txtConv4.Location = new System.Drawing.Point(202, 204);
            this.txtConv4.Name = "txtConv4";
            this.txtConv4.Size = new System.Drawing.Size(100, 23);
            this.txtConv4.TabIndex = 17;
            this.txtConv4.Visible = false;
            // 
            // lblConv3
            // 
            this.lblConv3.AutoSize = true;
            this.lblConv3.Location = new System.Drawing.Point(25, 178);
            this.lblConv3.Name = "lblConv3";
            this.lblConv3.Size = new System.Drawing.Size(38, 15);
            this.lblConv3.TabIndex = 18;
            this.lblConv3.Text = "label3";
            this.lblConv3.Visible = false;
            // 
            // lblConv4
            // 
            this.lblConv4.AutoSize = true;
            this.lblConv4.Location = new System.Drawing.Point(25, 207);
            this.lblConv4.Name = "lblConv4";
            this.lblConv4.Size = new System.Drawing.Size(38, 15);
            this.lblConv4.TabIndex = 19;
            this.lblConv4.Text = "label4";
            this.lblConv4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 246);
            this.Controls.Add(this.lblConv4);
            this.Controls.Add(this.lblConv3);
            this.Controls.Add(this.txtConv4);
            this.Controls.Add(this.txtConv3);
            this.Controls.Add(this.txtConv2);
            this.Controls.Add(this.txtConv1);
            this.Controls.Add(this.lblConv2);
            this.Controls.Add(this.lblConv1);
            this.Controls.Add(this.lblConversiones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.CBMoneda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComboBox CBMoneda;
        public Label lblMoneda;
        public Label lblMonto;
        public TextBox txtMonto;
        public Button btnCalcular;
        public Label lblConversiones;
        int num = 1;
        private Label lblConv1;
        private Label lblConv2;
        private TextBox txtConv1;
        private TextBox txtConv2;
        private TextBox txtConv3;
        private TextBox txtConv4;
        private Label lblConv3;
        private Label lblConv4;
    }
}