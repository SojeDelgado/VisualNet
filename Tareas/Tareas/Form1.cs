namespace Tareas;

public partial class Form1 : Form
{
    private Label? lblFigura;
    private ComboBox? cmbFiguras;
    private Label? lblCalculo;
    private ComboBox? cmbCalculos;
    private Label? lblAltura;
    private TextBox? txtAltura;
    private TextBox? txtBase;
    private Label? lblResultado;
    private Label? lblBase;

    private Label? lblLado1;
    private Label? lblLado2;
    private Label? lblLado3;
    private TextBox? txtLado1;
    private TextBox? txtLado2;
    private TextBox? txtLado3;
    private TextBox? txtResultado;
    private Button? btnCalcular;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        // Tamaño de la ventana
        this.Size = new Size(300,350);

        //Etiqueta Figura
        lblFigura= new Label();
        lblFigura.Text="Figura";
        lblFigura.AutoSize=true;
        lblFigura.Location= new Point(10,10);

        //ComboBox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Selecciona figura");
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.SelectedIndex=0;
        cmbFiguras.Location= new Point(10,40);
        cmbFiguras.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Calculo
        lblCalculo= new Label();
        lblCalculo.Text="Cálculo";
        lblCalculo.AutoSize=true;
        lblCalculo.Location= new Point(150,10);

        //ComboBox Calculos
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Selecciona calculo");
        cmbCalculos.Items.Add("Périmetro");
        cmbCalculos.Items.Add("Área");
        cmbCalculos.SelectedIndex=0;
        cmbCalculos.Location= new Point(150,40);
        cmbCalculos.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Altura
        lblAltura= new Label();
        lblAltura.Text="Altura";
        lblAltura.AutoSize=true;
        lblAltura.Location= new Point(10,80);
        lblAltura.Visible=false;

        //Etiqueta Base
        lblBase= new Label();
        lblBase.Text="Base";
        lblBase.AutoSize=true;
        lblBase.Location= new Point(10,110);
        lblBase.Visible=false;

        //TextBox Altura
        txtAltura=new TextBox();
        txtAltura.Size = new Size(100,20);
        txtAltura.Location= new Point(60,75);
        txtAltura.Visible=false;

        //TextBox Base
        txtBase=new TextBox();
        txtBase.Size = new Size(100,20);
        txtBase.Location= new Point(60,105);
        txtBase.Visible=false;

        //Etiqueta Altura
        lblResultado= new Label();
        lblResultado.Text="Resultado";
        lblResultado.AutoSize=true;
        lblResultado.Location= new Point(10,280);

        //TextBox Lado 1, Lado 2 y Lado 3.
        txtLado1=new TextBox();
        txtLado1.Size = new Size(100,20);
        txtLado1.Location= new Point(60,75);
        txtLado1.Visible=false;

        txtLado2=new TextBox();
        txtLado2.Size = new Size(100,20);
        txtLado2.Location= new Point(60,105);
        txtLado2.Visible=false;

        txtLado3=new TextBox();
        txtLado3.Size = new Size(100,20);
        txtLado3.Location= new Point(60,135);
        txtLado3.Visible=false;

        //Etiqueta Lado 1, Lado 2 y Lado 3.
        lblLado1= new Label();
        lblLado1.Text="Lado 1";
        lblLado1.AutoSize=true;
        lblLado1.Location= new Point(10,80);
        lblLado1.Visible=false;

        lblLado2= new Label();
        lblLado2.Text="Lado 2";
        lblLado2.AutoSize=true;
        lblLado2.Location= new Point(10,110);
        lblLado2.Visible=false;

        lblLado3= new Label();
        lblLado3.Text="Lado 3";
        lblLado3.AutoSize=true;
        lblLado3.Location= new Point(10,140);
        lblLado3.Visible=false;


        //TextBox Prueba
        txtResultado=new TextBox();
        txtResultado.Size = new Size(100,20);
        txtResultado.Location= new Point(70,275);

        //Boton Calcular
        btnCalcular= new Button();
        btnCalcular.Text="Calcular";
        btnCalcular.AutoSize=true;
        btnCalcular.Location= new Point(200,200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);

        //Agregar controles a la ventana
        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculos);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
        this.Controls.Add(btnCalcular);

        this.Controls.Add(txtLado1);
        this.Controls.Add(txtLado2);
        this.Controls.Add(txtLado3);

        this.Controls.Add(lblLado1);
        this.Controls.Add(lblLado2);
        this.Controls.Add(lblLado3);
    }
    private void cmb_ValueChanged(object sender, EventArgs e){
        if(cmbCalculos.SelectedIndex!=0 && cmbFiguras.SelectedIndex!=0){
            if(cmbFiguras.SelectedItem.ToString()=="Cuadrado"){
                //cmbFigura.SelectedIndex==1
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;

                    txtBase.Visible = false;
                    lblBase.Visible = false;

                    txtLado1.Visible = false;
                    txtLado2.Visible = false;
                    txtLado3.Visible = false;

                    lblLado1.Visible = false;
                    lblLado2.Visible = false;
                    lblLado3.Visible = false;

                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;

                    txtBase.Visible = false;
                    lblBase.Visible = false;

                    txtLado1.Visible = false;
                    txtLado2.Visible = false;
                    txtLado3.Visible = false;

                    lblLado1.Visible = false;
                    lblLado2.Visible = false;
                    lblLado3.Visible = false;
                }
            }
            if(cmbFiguras.SelectedItem.ToString()=="Triangulo"){
                //cmbFigura.SelectedIndex==1
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtLado1.Visible = true;
                    txtLado2.Visible = true;
                    txtLado3.Visible = true;

                    lblLado1.Visible = true;
                    lblLado2.Visible = true;
                    lblLado3.Visible = true;

                    txtAltura.Visible=false;
                    lblAltura.Visible=false;

                    txtBase.Visible = false;
                    lblBase.Visible = false;


                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;

                    txtBase.Visible = true;
                    lblBase.Visible = true;

                    txtLado1.Visible = false;
                    txtLado2.Visible = false;
                    txtLado3.Visible = false;

                    lblLado1.Visible = false;
                    lblLado2.Visible = false;
                    lblLado3.Visible = false;
                }
            }
            if(cmbFiguras.SelectedItem.ToString()=="Rectangulo"){
                //cmbFigura.SelectedIndex==1
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;

                    txtBase.Visible = true;
                    lblBase.Visible = true;

                    txtLado1.Visible = false;
                    txtLado2.Visible = false;
                    txtLado3.Visible = false;

                    lblLado1.Visible = false;
                    lblLado2.Visible = false;
                    lblLado3.Visible = false;
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;

                    txtBase.Visible = true;
                    lblBase.Visible = true;

                    txtLado1.Visible = false;
                    txtLado2.Visible = false;
                    txtLado3.Visible = false;

                    lblLado1.Visible = false;
                    lblLado2.Visible = false;
                    lblLado3.Visible = false;
                }
            }
        }
        else
        {
            txtAltura.Visible=false;
            lblAltura.Visible=false;

            txtBase.Visible = false;
            lblBase.Visible = false;

            txtLado1.Visible = false;
            txtLado2.Visible = false;
            txtLado3.Visible = false;

            lblLado1.Visible = false;
            lblLado2.Visible = false;
            lblLado3.Visible = false;
        }
    }
    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo= cmbCalculos.SelectedItem.ToString();
        if(txtAltura.Text!=""){
            if(calculo=="Périmetro" && cmbFiguras.SelectedItem.ToString()=="Cuadrado"){
                int altura= Convert.ToInt32(txtAltura.Text);
                txtResultado.Text=(altura*4).ToString();
            }
            if(calculo=="Área" && cmbFiguras.SelectedItem.ToString()=="Cuadrado"){
                int altura= Convert.ToInt32(txtAltura.Text);
                txtResultado.Text=(altura*altura).ToString();
            }
        }
        if(txtAltura.Text!="" && txtBase.Text!=""){
            if(calculo=="Área" && cmbFiguras.SelectedItem.ToString()=="Triangulo"){
                int altura= Convert.ToInt32(txtAltura.Text);
                int _base= Convert.ToInt32(txtBase.Text);
                txtResultado.Text=((_base * altura)/2).ToString();
            }
            if(calculo=="Área" && cmbFiguras.SelectedItem.ToString()=="Rectangulo"){
                int altura= Convert.ToInt32(txtAltura.Text);
                int _base= Convert.ToInt32(txtBase.Text);
                txtResultado.Text=(_base * altura).ToString();
            }
            if(calculo=="Périmetro" && cmbFiguras.SelectedItem.ToString()=="Rectangulo"){
                int altura= Convert.ToInt32(txtAltura.Text);
                int _base= Convert.ToInt32(txtBase.Text);
                txtResultado.Text=(2*(_base + altura)).ToString();
            }
        }
        if(txtLado1.Text != "" && txtLado2.Text != "" && txtLado3.Text != ""){
            if(calculo=="Périmetro" && cmbFiguras.SelectedItem.ToString()=="Triangulo"){
                int lado1 = Convert.ToInt32(txtLado1.Text);
                int lado2 = Convert.ToInt32(txtLado2.Text);
                int lado3 = Convert.ToInt32(txtLado3.Text);

                txtResultado.Text=(lado1 + lado2 + lado3).ToString();   
            }           
        }
    }
}
