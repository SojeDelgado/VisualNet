namespace Repaso;

public partial class Form1 : Form
{
    private Button btnVentana;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        Form2 frmVentana = new Form2();
        if (frmVentana.ShowDialog() == DialogResult.OK)
        {
            Label lblAgregado = new Label();
            lblAgregado.Text = "";
            lblAgregado.AutoSize = true;
            lblAgregado.Location = new Point(10, 30);
            this.Controls.Add(lblAgregado);
        }
    }
}
