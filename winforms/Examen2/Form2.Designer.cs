namespace Examen2
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.CLBMonto = new System.Windows.Forms.CheckedListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // CLBMonto
            // 
            this.CLBMonto.FormattingEnabled = true;
            this.CLBMonto.Items.AddRange(new object[] {
            "MXN - Peso mexicano",
            "USD - Dólar estadounidense",
            "CAD - Dólar canadiense",
            "EUR - Euro",
            "JPY - Yen japonés"});
            this.CLBMonto.Location = new System.Drawing.Point(12, 12);
            this.CLBMonto.Name = "CLBMonto";
            this.CLBMonto.Size = new System.Drawing.Size(219, 166);
            this.CLBMonto.TabIndex = 2;
            this.CLBMonto.SelectedIndexChanged += new System.EventHandler(this.CLBMonto_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(156, 201);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 236);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.CLBMonto);
            this.Controls.Add(this.btnCancelar);
            this.Name = "Form2";
            this.Text = "Conversión";
            this.ResumeLayout(false);

        }

        #endregion

        public Button btnCancelar;
        public CheckedListBox CLBMonto;
        private Button btnAceptar;
    }
}