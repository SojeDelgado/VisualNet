namespace Examen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //  
            //  Ocultamos los labels y textboxs al darle click al boton //
            //
            lblConv1.Visible = false;
            lblConv2.Visible = false;
            lblConv3.Visible = false;
            lblConv4.Visible = false;

            txtConv1.Visible = false;
            txtConv2.Visible = false;
            txtConv3.Visible = false;
            txtConv4.Visible = false;

            Form2 frmVentana = new Form2();
            this.num = 0;

            //
            //  Removemos el item del CLB dependiendo de la operacion en el ComboBox    //
            //
            if (CBMoneda.Text == "MXN - Peso mexicano") {
                frmVentana.CLBMonto.Items.Remove("MXN - Peso mexicano");
            }

            if (CBMoneda.Text == "USD - Dólar estadounidense")
            {
                frmVentana.CLBMonto.Items.Remove("USD - Dólar estadounidense");
            }

            if (CBMoneda.Text == "CAD - Dólar canadiense")
            {
                frmVentana.CLBMonto.Items.Remove("CAD - Dólar canadiense");
            }

            if (CBMoneda.Text == "EUR - Euro")
            {
                frmVentana.CLBMonto.Items.Remove("EUR - Euro");
            }
            if (CBMoneda.Text == "JPY - Yen japonés")
            {
                frmVentana.CLBMonto.Items.Remove("JPY - Yen japonés");
            }

            //
            //  Validamos el darle click en el boton Calcular   //
            //  
            if (validarEntrada(CBMoneda.Text) == true && txtMonto.Text != "" && frmVentana.ShowDialog() == DialogResult.OK)
            {
                int indice = 1;
                foreach (object itemChecked in frmVentana.CLBMonto.CheckedItems)
                {

                    if (frmVentana.CLBMonto.CheckedItems.Count == 1)
                    {
                        lblConv1.Visible = true;
                        txtConv1.Visible = true;

                        lblConv1.Text = itemChecked.ToString();
                        txtConv1.Text = monedaAConvertir(CBMoneda.Text, lblConv1.Text, Convert.ToDouble(txtMonto.Text)).ToString();
                    }

                    if (frmVentana.CLBMonto.CheckedItems.Count == 2)
                    {
                        lblConv1.Visible = true;
                        txtConv1.Visible = true;
                        lblConv2.Visible = true;
                        txtConv2.Visible = true;

                        if (indice == 1){ 
                            lblConv1.Text = itemChecked.ToString();
                            txtConv1.Text = monedaAConvertir(CBMoneda.Text, lblConv1.Text, Convert.ToDouble(txtMonto.Text)).ToString();
                        }
                        lblConv2.Text = itemChecked.ToString();
                        txtConv2.Text = monedaAConvertir(CBMoneda.Text, lblConv2.Text, Convert.ToDouble(txtMonto.Text)).ToString();
                    }

                    if (frmVentana.CLBMonto.CheckedItems.Count == 3)
                    {
                        lblConv1.Visible = true;
                        txtConv1.Visible = true;
                        lblConv2.Visible = true;
                        txtConv2.Visible = true;
                        lblConv3.Visible = true;
                        txtConv3.Visible = true;

                        if (indice == 1) { 
                            lblConv1.Text = itemChecked.ToString();
                            txtConv1.Text = monedaAConvertir(CBMoneda.Text, lblConv1.Text, Convert.ToDouble(txtMonto.Text)).ToString();
                        }
                        if (indice == 2) { 
                            lblConv2.Text = itemChecked.ToString();
                            txtConv2.Text = monedaAConvertir(CBMoneda.Text, lblConv2.Text, Convert.ToDouble(txtMonto.Text)).ToString();
                        }
                        lblConv3.Text = itemChecked.ToString();
                        txtConv3.Text = monedaAConvertir(CBMoneda.Text, lblConv3.Text, Convert.ToDouble(txtMonto.Text)).ToString();
                    }

                    if (frmVentana.CLBMonto.CheckedItems.Count == 4)
                    {
                        lblConv1.Visible = true;
                        txtConv1.Visible = true;
                        lblConv2.Visible = true;
                        txtConv2.Visible = true;
                        lblConv3.Visible = true;
                        txtConv3.Visible = true;
                        lblConv4.Visible = true;
                        txtConv4.Visible = true;

                        if (indice == 1){ 
                            lblConv1.Text = itemChecked.ToString();
                            txtConv1.Text = monedaAConvertir(CBMoneda.Text, lblConv1.Text, Convert.ToDouble(txtMonto.Text)).ToString();
                        }
                        if (indice == 2) { 
                            lblConv2.Text = itemChecked.ToString();
                            txtConv2.Text = monedaAConvertir(CBMoneda.Text, lblConv2.Text, Convert.ToDouble(txtMonto.Text)).ToString();
                        }
                        if (indice == 3) { 
                            lblConv3.Text = itemChecked.ToString();
                            txtConv3.Text = monedaAConvertir(CBMoneda.Text, lblConv3.Text, Convert.ToDouble(txtMonto.Text)).ToString();
                        }
                        lblConv4.Text = itemChecked.ToString();
                        txtConv4.Text = monedaAConvertir(CBMoneda.Text, lblConv4.Text, Convert.ToDouble(txtMonto.Text)).ToString();
                    }
                    indice++;
                }
            }
        }

        //
        //  Este método nos ayuda a validar la entrada del CBMoneda
        //
        private bool validarEntrada(String txt1)
        {
            if (txt1 == "MXN - Peso mexicano")
            {
                return true;
            }
            else if (txt1 == "USD - Dólar estadounidense")
            {
                return true;
            }
            else if (txt1 == "CAD - Dólar canadiense")
            {
                return true;
            }
            else if (txt1 == "EUR - Euro")
            {
                return true;
            }
            else if (txt1 == "JPY - Yen japonés")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private double monedaAConvertir(String moneda, String moneda2,double monto)
        {
            if (moneda == "MXN - Peso mexicano")
            {
                if (moneda2 == "USD - Dólar estadounidense")
                {
                    return monto * 0.05;
                }
                else if(moneda2 == "CAD - Dólar canadiense")
                {
                    return monto * 0.06;
                }
                else if(moneda2 == "EUR - Euro")
                {
                    return monto * 0.04;
                }
                else if (moneda2 == "JPY - Yen japonés")
                {
                    return monto * 5.32;
                }
            }
            else if (moneda == "USD - Dólar estadounidense")
            {
                if (moneda2 == "MXN - Peso mexicano")
                {
                    return monto * 21.23;
                }
                else if (moneda2 == "CAD - Dólar canadiense")
                {
                    return monto * 1.28;
                }
                else if (moneda2 == "EUR - Euro")
                {
                    return monto * 0.89;
                }
                else if (moneda2 == "JPY - Yen japonés")
                {
                    return monto * 113.05;
                }
            }
            else if (moneda == "CAD - Dólar canadiense")
            {
                if (moneda2 == "MXN - Peso mexicano")
                {
                    return monto * 16.55;
                }
                else if (moneda2 == "USD - Dólar estadounidense")
                {
                    return monto * 0.78;
                }
                else if (moneda2 == "EUR - Euro")
                {
                    return monto * 0.69;
                }
                else if (moneda2 == "JPY - Yen japonés")
                {
                    return monto * 88.12;
                }
            }
            else if (moneda == "EUR - Euro")
            {
                if (moneda2 == "MXN - Peso mexicano")
                {
                    return monto * 23.96;
                }
                else if (moneda2 == "USD - Dólar estadounidense")
                {
                    return monto * 1.13;
                }
                else if (moneda2 == "CAD - Dólar canadiense")
                {
                    return monto * 1.45;
                }
                else if (moneda2 == "JPY - Yen japonés")
                {
                    return monto * 127.56;
                }
            }
            else if (moneda == "JPY - Yen japonés")
            {
                if (moneda2 == "MXN - Peso mexicano")
                {
                    return monto * 0.1878;
                }
                else if (moneda2 == "USD - Dólar estadounidense")
                {
                    return monto * 0.0088;
                }
                else if (moneda2 == "CAD - Dólar canadiense")
                {
                    return monto * 0.0113;
                }
                else if (moneda2 == "EUR - Euro")
                {
                    return monto * 0.0078;
                }
            }
            return 0;
        }

        //
        //  Este método me ayuda a ingresar SOLO datos numericos en txtMonto    //
        //
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Puntos decimales
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}