namespace Repaso;

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
    private void InitializeComponent()
    {
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.tBoxMonto = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMoneda
            // 
            this.cbMoneda.AccessibleName = "";
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Items.AddRange(new object[] {
            "MXN - Peso mexicano",
            "USD - Dólar estadounidense",
            "CAD - Dólar canadiense",
            "EUR - Euro",
            "JPY - Yen japonés"});
            this.cbMoneda.Location = new System.Drawing.Point(12, 26);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(174, 23);
            this.cbMoneda.TabIndex = 0;
            this.cbMoneda.Tag = "";
            this.cbMoneda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tBoxMonto
            // 
            this.tBoxMonto.AccessibleName = "";
            this.tBoxMonto.Location = new System.Drawing.Point(205, 26);
            this.tBoxMonto.Name = "tBoxMonto";
            this.tBoxMonto.Size = new System.Drawing.Size(112, 23);
            this.tBoxMonto.TabIndex = 1;
            this.tBoxMonto.Tag = "";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(12, 8);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(51, 15);
            this.lblMoneda.TabIndex = 2;
            this.lblMoneda.Text = "Moneda";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(205, 8);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 15);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(205, 55);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 459);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.tBoxMonto);
            this.Controls.Add(this.cbMoneda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ComboBox cbMoneda;
    private TextBox tBoxMonto;
    private Label lblMoneda;
    private Label lblMonto;
    private Button btnCalcular;
}
