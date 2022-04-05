namespace Calculadora;

public partial class Form1 : Form
{
    private Button btnBorrarUltimo;
    private Button btnBorrarActual;
    private Button btnBorrarTodo;
    private Button btnSigno;
    private Button btn7;
    private Button btn8;
    private Button btn9;
    private Button btnSuma;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btnResta;
    private Button btn1;
    private Button btn2;
    private Button btn3;
    private Button btnMultiplicacion;
    private Button btn0;
    private Button btnPunto;
    private Button btnIgual;
    private Button btnDivision;
    private TextBox txtDisplay;
    private Label lblOperacion;
    private String operacion;
    private Double resultado;

    public Form1()
    {
        operacion="";
        resultado=0;
        txtDisplay = new TextBox();
        lblOperacion = new Label();

        btnBorrarUltimo = new Button();
        btnBorrarActual = new Button();
        btnBorrarTodo = new Button();
        btnSigno = new Button();
        btn7 = new Button();
        btn8 = new Button();
        btn9 = new Button();
        btnSuma = new Button();
        btn4 = new Button();
        btn5 = new Button();
        btn6 = new Button();
        btnResta = new Button();
        btn1 = new Button();
        btn2 = new Button();
        btn3 = new Button();
        btnMultiplicacion = new Button();
        btn0 = new Button();
        btnPunto = new Button();
        btnIgual = new Button();
        btnDivision = new Button();
        


        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes(){
        //Tamaño de Botones
        btnBorrarUltimo.Size = new Size(60,60);
        btnBorrarActual.Size = new Size(60,60);
        btnBorrarTodo.Size = new Size(60,60);
        btnSigno.Size = new Size(60,60);
        btn7.Size = new Size(60,60);
        btn8.Size = new Size(60,60);
        btn9.Size = new Size(60,60);
        btnSuma.Size = new Size(60,60);
        btn4.Size = new Size(60,60);
        btn5.Size = new Size(60,60);
        btn6.Size = new Size(60,60);
        btnResta.Size = new Size(60,60);
        btn1.Size = new Size(60,60);
        btn2.Size = new Size(60,60);
        btn3.Size = new Size(60,60);
        btnMultiplicacion.Size = new Size(60,60);
        btn0.Size = new Size(60,60);
        btnPunto.Size = new Size(60,60);
        btnIgual.Size = new Size(60,60);
        btnDivision.Size = new Size(60,60);
        txtDisplay.Size = new Size(260,50);
        txtDisplay.Multiline = true;
        lblOperacion.AutoSize=true;

        //Texto
        btnBorrarUltimo.Text = "⌫";
        btnBorrarActual.Text = "CE";
        btnBorrarTodo.Text = "C";
        btnSigno.Text = "±";
        btn7.Text = "7";
        btn8.Text = "8";
        btn9.Text = "9";
        btnSuma.Text = "+";
        btn4.Text = "4";
        btn5.Text = "5";
        btn6.Text = "6";
        btnResta.Text = "-";
        btn1.Text = "1";
        btn2.Text = "2";
        btn3.Text = "3";
        btnMultiplicacion.Text = "*";
        btn0.Text = "0";
        btnPunto.Text = ".";
        btnIgual.Text = "=";
        btnDivision.Text = "/";

        //Posicion
        txtDisplay.Location = new Point(10,30);
        lblOperacion.Location = new Point(10,30);
        lblOperacion.BringToFront();

        //Agregar controles al formulario
        this.Controls.Add(txtDisplay);
        this.Controls.Add(lblOperacion);

    }
}
