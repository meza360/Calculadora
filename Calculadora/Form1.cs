using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{
    public partial class Form1 : Form
    {
        Ayuda call = new Ayuda();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pan.MaxLength = 12;
            //tamaño del formulario
            this.Width = 270;
            this.Height = 320;
            this.CenterToScreen();
            pan.Text = "0";
            
            //el formulario empieza con la calculadora basica
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;

            //comboBox1.Items.Add("Masa");
            comboBox1.Items.Add("Longitud");
            comboBox1.Items.Add("Area");
            comboBox1.Items.Add("Temperatura");
            comboBox1.Items.Add("Datos D.");
            comboBox1.Items.Add("Tiempo");
            comboBox1.Items.Add("Velocidad");

        }


        #region no usados aun
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion no usados aun


        #region comandosbasicos

        private void basicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            pan.Text = "0";
            pan.Size = new Size(230, 40);
            this.Width = 270;
            this.Height = 320;
            pan.Text = "0";
            ans = 0;
            a = 0;
            b = 0;
            temp = 0;
            signo = true;
            op = "";

        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            pan.Text = "0";
            pan.Size = new Size(380, 40);
            this.Width = 420;
            this.Height = 320;
            pan.Text = "0";
            ans = 0;
            a = 0;
            b = 0;
            temp = 0;
            signo = true;
            op = "";
        }

        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            pan.Text = "0";
            pan.Size = new Size(320, 40);
            this.Width = 360;
            this.Height = 350;
            pan.Text = "0";
            ans = 0;
            a = 0;
            b = 0;
            temp = 0;
            signo = true;
            op = "";
        }

        private void conversionDeUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            pan.Text = "0";
            pan.Size = new Size(350, 40);
            this.Width = 378;
            this.Height = 330;
            pan.Text = "0";
            ans = 0;
            a = 0;
            b = 0;
            temp = 0;
            signo = true;
            op = "";
        }

        private void matricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            pan.Text = "0";
            pan.Size = new Size(430, 40);
            this.Width = 460;
            this.Height = 490;
            pan.Text = "0";
            ans = 0;
            a = 0;
            b = 0;
            temp = 0;
            signo = true;
            op = "";
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            call.ShowDialog();
        }

        private void pan_TextChanged(object sender, EventArgs e)
        {
            pan.MaxLength = 12;
        }

        #endregion comandosbasicos 


        #region variables
        double a = 0;
        double b = 0;
        double c = 0;
        double d = 0;
        double e = 0;
        double f = 0;
        double g = 0;
        double h = 0;
        double pii = 0;
        double ans = 0;
        double resultado = 0;
        int ab = 0;
        int ba = 0;
        double temp = 0;
        string op = "";
        bool signo = true;
        string bin = "";
        object tipo;
        object con1;
        object con2;

        #endregion variables


        #region basica 

        private void bas0_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "0";
        }

        private void bas1_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "1";
        }

        private void bas2_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "2";
        }

        private void bas3_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "3";
        }

        private void bas4_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "4";
        }

        private void bas5_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "5";
        }

        private void bas6_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "6";
        }

        private void bas7_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "7";
        }

        private void bas8_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "8";
        }

        private void bas9_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "9";
        }

        private void baspunto_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + ".";
        }

        private void basmas_Click(object sender, EventArgs e)
        {
            try
            {
                op = "+";
                a = double.Parse(pan.Text);
                pan.Clear();
                ans = ans + a;

            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }

        }

        private void basresta_Click(object sender, EventArgs e)
        {
            try
            {
                op = "-";
                a = double.Parse(pan.Text);
                pan.Clear();
                temp = a;
                ans = temp;
                //ans = ans - b;
                // temp = 0;

            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void basigual_Click(object sender, EventArgs e)
        {
            try
            {
                //try de la suma
                if (op == "+")
                {
                    a = double.Parse(pan.Text);
                    ans = ans + a;
                    pan.Text = ans.ToString();

                }
                //try de la resta
                if (op == "-")
                {
                    b = double.Parse(pan.Text);
                    ans = ans - b;
                    pan.Text = ans.ToString();

                }
                //try de la multiplicacion
                if (op == "*")
                {
                    b = double.Parse(pan.Text);
                    ans = ans * b;
                    pan.Text = ans.ToString();

                }
                //try de la division
                if (op == "/")
                {
                    b = double.Parse(pan.Text);
                    ans = ans / b;
                    pan.Text = ans.ToString();

                }
                //try de la raiz cuadrada
                if (op == "√")
                {
                    ans = Math.Sqrt(a);
                    pan.Text = ans.ToString();

                }
                //try de porcentaje
                if (op == "%")
                {
                    ans = a;
                    b = double.Parse(pan.Text);
                    c = (ans / 100) * b;
                    pan.Text = c.ToString();

                }

                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                op = "";


            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }

        }

        private void basce_Click(object sender, EventArgs e)
        {
            pan.Text = "0";
            op = "";
            ans = 0;
            a = 0;
            b = 0;
            temp = 0;
            signo = true;
        }

        private void basc_Click(object sender, EventArgs e)
        {
            pan.Text = "0";
            signo = true;
        }

        private void basmultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                op = "*";
                a = double.Parse(pan.Text);
                pan.Clear();
                temp = a;
                ans = temp;
                //ans = ans - b;
                // temp = 0;

            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void basdivision_Click(object sender, EventArgs e)
        {
            try
            {
                op = "/";
                a = double.Parse(pan.Text);
                pan.Clear();
                temp = a;
                ans = temp;
                //ans = ans - b;
                // temp = 0;

            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void bassigno_Click(object sender, EventArgs e)
        {
            signo = false;
            pan.Text = "-" + pan.Text;
            if (signo == false)
            {
                pan.Text = pan.Text;
            }

        }

        private void basraiz_Click(object sender, EventArgs e)
        {


            try
            {
                op = "√";
                a = double.Parse(pan.Text);
                // Math.Sqrt(a);
                //ans = a;
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void basporcentaje_Click(object sender, EventArgs e)
        {
            try
            {
                op = "%";
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }



        #endregion basica 

        #region cientifica

        private void button53_Click(object sender, EventArgs e)
        {
            //muestra PI 
            try
            {
                pii = Math.PI;
                pan.Text = pii.ToString();
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }

        }

        private void button52_Click(object sender, EventArgs e)
        {
            //entero de un numero decimal
            try
            {
                a = double.Parse(pan.Text);
                pan.Text = Math.Truncate(a).ToString();
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }

        }

        private void button51_Click(object sender, EventArgs e)
        {
            //seno de un angulo
            try
            {
                a = double.Parse(pan.Text);
                pan.Text = Math.Sin(a).ToString();
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            //coseno de un agulo
            try
            {
                a = double.Parse(pan.Text);

                pan.Text = Math.Cos(a).ToString();
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            //tangente de un angulo
            try
            {
                a = double.Parse(pan.Text);
                pan.Text = Math.Tan(a).ToString();
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //potencia de 2
            try
            {
                a = double.Parse(pan.Text);

                pan.Text = Math.Pow(a, 2).ToString();
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            //potencia a 3
            try
            {
                a = double.Parse(pan.Text);

                pan.Text = Math.Pow(a, 3).ToString();
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "0";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "1";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "2";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "3";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "4";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "5";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "6";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "7";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "8";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "9";
        }

        private void puntocientifica_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + ".";
        }

        private void cecientifica_Click(object sender, EventArgs e)
        {
            pan.Text = "0";
            op = "";
            ans = 0;
            a = 0;
            b = 0;
            temp = 0;
            signo = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //c
            pan.Text = "0";
            signo = true;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            //potencia x y y
            try
            {
                op = "^";
                a = double.Parse(pan.Text);
                pan.Clear();
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //boton igual
            try
            {
                //try de potencia x y y
                if (op == "^")
                {
                    b = double.Parse(pan.Text);
                    ans = Math.Pow(a, b);
                    pan.Text = ans.ToString();

                }
                //try de la raiz definida
                if (op == "rd")
                {
                    b = double.Parse(pan.Text);
                    c = 1 / b;
                    ans = Math.Pow(a, c);
                    pan.Text = ans.ToString();
                }

                //try de la suma
                if (op == "+")
                {
                    a = double.Parse(pan.Text);
                    ans = ans + a;
                    pan.Text = ans.ToString();

                }
                //try de la resta
                if (op == "-")
                {
                    b = double.Parse(pan.Text);
                    ans = ans - b;
                    pan.Text = ans.ToString();

                }
                //try de la multiplicacion
                if (op == "*")
                {
                    b = double.Parse(pan.Text);
                    ans = ans * b;
                    pan.Text = ans.ToString();

                }
                //try de la division
                if (op == "/")
                {
                    b = double.Parse(pan.Text);
                    ans = ans / b;
                    pan.Text = ans.ToString();

                }

                //try de porcentaje
                if (op == "%")
                {
                    ans = a;
                    b = double.Parse(pan.Text);
                    c = (ans / 100) * b;
                    pan.Text = c.ToString();

                }


                ans = 0;
                a = 0;
                b = 0;
                signo = true;
                temp = 0;
                op = "";
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();

            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //logaritmo base 10
            try
            {
                op = "log";
                ans = Math.Log10(double.Parse(pan.Text));
                pan.Text = ans.ToString();
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }

        }

        private void button40_Click(object sender, EventArgs e)
        {
            //boton de raiz cuadrada
            try
            {
                op = "√";
                a = double.Parse(pan.Text);
                ans = Math.Sqrt(a);
                pan.Text = ans.ToString();

            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            //boton de raiz definida 

            try
            {
                op = "rd";
                a = double.Parse(pan.Text);
                pan.Clear();

            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //boton factorial
            try
            {
                op = "n!";
                a = double.Parse(pan.Text);
                pan.Clear();
                b = 1;

                for (f = a; f >= 1; f--)
                {
                    b = b * f;

                }

                pan.Text = b.ToString();
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void mascientifica_Click(object sender, EventArgs e)
        {
            //suma de cientifica
            try
            {
                op = "+";
                a = double.Parse(pan.Text);
                pan.Clear();
                ans = ans + a;

            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void menoscientifica_Click(object sender, EventArgs e)
        {
            //resta de la cientifica
            try
            {
                op = "-";
                a = double.Parse(pan.Text);
                pan.Clear();
                temp = a;
                ans = temp;
                //ans = ans - b;
                // temp = 0;

            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void porcientifica_Click(object sender, EventArgs e)
        {
            //multiplicacion de la cientifica
            try
            {
                op = "*";
                a = double.Parse(pan.Text);
                pan.Clear();
                temp = a;
                ans = temp;
                //ans = ans - b;
                // temp = 0;

            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void divcientifica_Click(object sender, EventArgs e)
        {
            //division de la cientifica
            try
            {
                op = "/";
                a = double.Parse(pan.Text);
                pan.Clear();
                temp = a;
                ans = temp;
                //ans = ans - b;
                // temp = 0;

            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //signo de la cientifica
            signo = false;
            pan.Text = "-" + pan.Text;
            if (signo == false)
            {
                pan.Text = pan.Text;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //porcentaje de la cientifica
            try
            {
                op = "%";
            }
            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }


        #endregion cientifica

        #region programador

        public void binarioconvertidor()
        {
            //esto lo uso para la calculadora del programador
            pan2.Clear();
            ab = int.Parse(pan.Text);

            if (ab != 1)
            {
                for (ba = ab; ba != 0 && ba != 1; ba = ba / 2)
                {
                    bin = (ba % 2) + bin;
                }
                if (ab == 0)
                {
                    pan2.Text = "el binario es 0";
                }
                else
                {
                    bin = 1 + bin;
                    pan2.Text = bin;
                }
            }
            else
            {
                pan2.Text = "el valor es 1";
            }
            ab = 0;
            ba = 0;
            bin = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button72_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "0";
        }

        private void button67_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "1";
        }

        private void button68_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "2";
        }

        private void button69_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "3";
        }

        private void button64_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "4";
        }

        private void button65_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "5";
        }

        private void button66_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "6";
        }

        private void button63_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "7";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "8";
        }

        private void button61_Click(object sender, EventArgs e)
        {
            pan.Text = pan.Text + "9";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            pan.Text = "0";
            pan2.Clear();
            signo = true;
        }

        private void ceprogramador_Click(object sender, EventArgs e)
        {
            pan.Text = "0";
            pan2.Clear();
            op = "";
            ans = 0;
            a = 0;
            b = 0;
            temp = 0;
            signo = true;
        }

        private void masprogramador_Click(object sender, EventArgs e)
        {
            //suma de programador
            try
            {
                op = "+";
                a = double.Parse(pan.Text);
                pan.Clear();
                pan2.Clear();
                ans = ans + a;

            }
            catch
            {
                pan.Text = "0";
                pan2.Clear();
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void menosprogramador_Click(object sender, EventArgs e)
        {
            //resta de la programador
            try
            {
                op = "-";
                a = double.Parse(pan.Text);
                pan.Clear();
                pan2.Clear();
                temp = a;
                ans = temp;
                //ans = ans - b;
                // temp = 0;

            }
            catch
            {
                pan.Text = "0";
                pan2.Clear();
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void porprogramador_Click(object sender, EventArgs e)
        {
            //multiplicacion de programador
            try
            {
                op = "*";
                a = double.Parse(pan.Text);
                pan.Clear();
                pan2.Clear();
                temp = a;
                ans = temp;
                //ans = ans - b;
                // temp = 0;

            }
            catch
            {
                pan.Text = "0";
                pan2.Clear();
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            //boton igual de programador
            try
            {
                

                //try de la suma
                if (op == "+")
                {
                    a = double.Parse(pan.Text);
                    ans = ans + a;
                    pan.Text = ans.ToString();

                }
                //try de la resta
                if (op == "-")
                {
                    b = double.Parse(pan.Text);
                    ans = ans - b;
                    pan.Text = ans.ToString();

                }
                //try de la multiplicacion
                if (op == "*")
                {
                    b = double.Parse(pan.Text);
                    ans = ans * b;
                    pan.Text = ans.ToString();

                }

                ans = 0;
                a = 0;
                b = 0;
                signo = true;
                temp = 0;
                op = "";


            }

            catch
            {
                pan.Text = "0";
                ans = 0;
                a = 0;
                b = 0;
                temp = 0;
                signo = true;
                op = "";
                call.ShowDialog();

            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            binarioconvertidor();
        }

        #endregion programador

        #region llenadodecombos

        public void masa()
        {
            comboBox2.Items.Add("Gramo");
            comboBox2.Items.Add("Kilogramo");
            comboBox2.Items.Add("Tonelada");
            comboBox2.Items.Add("Libra");

            comboBox3.Items.Add("Gramo");
            comboBox3.Items.Add("Kilogramo");
            comboBox3.Items.Add("Tonelada");
            comboBox3.Items.Add("Libra");
        }

        public void longitud()
        {
            comboBox2.Items.Add("Centimetros");
            comboBox2.Items.Add("Metros");
            comboBox2.Items.Add("Kilometros");
            

            comboBox3.Items.Add("Centimetros");
            comboBox3.Items.Add("Metros");
            comboBox3.Items.Add("Kilometros");
            
        }

        public void area()
        {
            comboBox2.Items.Add("Metro c.");
            comboBox2.Items.Add("Kilometro c.");
            comboBox2.Items.Add("Hectarea");
            comboBox2.Items.Add("Pie c.");
            comboBox2.Items.Add("Pulgada c.");

            comboBox3.Items.Add("Metro c.");
            comboBox3.Items.Add("Kilometro c.");
            comboBox3.Items.Add("Hectarea");
            comboBox3.Items.Add("Pie c.");
            comboBox3.Items.Add("Pulgada c.");
        }

        public void temperatura()
        {
            comboBox2.Items.Add("Celcius");
            comboBox2.Items.Add("Fahrenheit");
            comboBox2.Items.Add("Kelvin");

            comboBox3.Items.Add("Celcius");
            comboBox3.Items.Add("Fahrenheit");
            comboBox3.Items.Add("Kelvin");
        }

        public void datos()
        {
            comboBox2.Items.Add("Kb");
            comboBox2.Items.Add("Mb");
            comboBox2.Items.Add("Gb");
            comboBox2.Items.Add("Tb");

            comboBox3.Items.Add("Kb");
            comboBox3.Items.Add("Mb");
            comboBox3.Items.Add("Gb");
            comboBox3.Items.Add("Tb");

        }

        public void tiempo()
        {
            comboBox2.Items.Add("Segundos");
            comboBox2.Items.Add("Minutos");
            comboBox2.Items.Add("Horas");

            comboBox3.Items.Add("Segundos");
            comboBox3.Items.Add("Minutos");
            comboBox3.Items.Add("Horas");

            
        }

        public void velocidad()
        {
            comboBox2.Items.Add("Mt/s");
            comboBox2.Items.Add("Km/h");

            comboBox3.Items.Add("Mt/s");
            comboBox3.Items.Add("Km/h");
        }

        #endregion llenadodecombos

        #region llenadodeconversiones

        public void longitud2()
        {
            ///////////////////////////////CM A
            if (con1 == "Centimetros" && con2 == "Metros")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f / 100;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            /////////////////////////////////////////////////////////////
            if (con1 == "Centimetros" && con2 == "Kilometros")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f / 100000;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ///////////////////////////METROS A
            if (con1 == "Metros" && con2 == "Centimetros")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 100;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            //////////////////////////////////////////
            if (con1 == "Metros" && con2 == "Kilometros")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f / 1000;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            //////////////////////////KILOMETROS A
            if (con1 == "Kilometros" && con2 == "Centimetros")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 100000;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            //////////////////////////////////////////////
            if (con1 == "Kilometros" && con2 == "Metros")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 1000;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }


        }

        public void datos2()
        {
            /////////////////////////KB A
            if (con1 == "Kb" && con2 == "Mb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f / Math.Pow(2,10);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ///////////////////////////////////////////
            if (con1 == "Kb" && con2 == "Gb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f / Math.Pow(2, 30);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            /////////////////////////////////////////////////////
            if (con1 == "Kb" && con2 == "Tb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f / Math.Pow(2, 40);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ///////////////////////////MB A
            if (con1 == "Mb" && con2 == "Kb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * Math.Pow(2, 10);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            //////////////////////////////////////////////
            if (con1 == "Mb" && con2 == "Gb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f / Math.Pow(2, 10);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ///////////////////////////////////////////////////////
            if (con1 == "Mb" && con2 == "Tb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f / Math.Pow(2, 20);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            /////////////////////////////GB A
            if (con1 == "Gb" && con2 == "Kb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * Math.Pow(2, 20);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            /////////////////////////////////////////////////////
            if (con1 == "Gb" && con2 == "Mb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * Math.Pow(2, 10);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ///////////////////////////////////////////////
            if (con1 == "Gb" && con2 == "Tb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f / Math.Pow(2, 10);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ////////////////////////////////////TB A
            if (con1 == "Tb" && con2 == "Kb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * Math.Pow(2, 30);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ////////////////////////////////////////////
            if (con1 == "Tb" && con2 == "Mb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * Math.Pow(2, 20);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ///////////////////////////////////////////////
            if (con1 == "Tb" && con2 == "Gb")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * Math.Pow(2, 10);
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ////////////////////////////////////
            if (con1 == con2 )
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    pan.Text = f.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }



        }

        public void tiempo2()
        {
            /////////////////////////SEGUNDOS A
            if (con1 == "Segundos" && con2 == "Segundos")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    pan.Text = f.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            //////////////////////////////////////////////////////////////////
            if (con1 == "Segundos" && con2 == "Horas")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 1/60 * 1/60;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            //////////////////////////////////////////////////////////////////////
            if (con1 == "Segundos" && con2 == "Minutos")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 1/60;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ////////////////////////////////////////////HORAS A
            if (con2 == "Segundos" && con1 == "Horas")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f *60/1 * 60/1;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            //////////////////////////////////////////
            if (con2 == "Minutos" && con1 == "Horas")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 60/1;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            /////////////////////////////////////////////////////////
            if (con2 == "Horas" && con1 == "Horas")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);                  
                    pan.Text = f.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            //////////////////////////////MINUTOS A
            if (con1 == "Minutos" && con2 == "Segundos")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 60/1;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ////////////////////////////////////////////////////
            if (con1 == "Minutos" && con2 == "Horas")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f / 60;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();

                }
            }
            ////////////////////////////////////////////////////////////////
            if (con1 == "Minutos" && con2 == "Minutos")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    
                    pan.Text = f.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }


        }

        public void tempe2()
        {
            /////////////////////////CELCIUS A
            if (con1 == "Celcius" && con2 == "Celcius")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    pan.Text = f.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();


                }
            }
            ///////////////////////////////////////////////////////////
            if (con1 == "Celcius" && con2 == "Fahrenheit")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = ((9 * f)/5) + 32;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
            ///////////////////////////////////////////////////////////
            if (con1 == "Celcius" && con2 == "Kelvin")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f + 273.15;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
            ////////////////////////////////////////////KELVIN A
            if (con2 == "Celcius" && con1 == "Kelvin")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f - 273.15;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
            //////////////////////////////////////////
            if (con2 == "Fahrenheit" && con1 == "Kelvin")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = ((9*(f -273.15)) / (5)) + 32;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
            /////////////////////////////////////////
            if (con1 == "Kelvin" && con2 == "Kelvin")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    
                    pan.Text = f.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
            /////////////////////////FAHRENHEIT A
            if (con1 == "Fahrenheit" && con2 == "Fahrenheit")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                   
                    pan.Text = f.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
            ///////////////////////////////////////////////////
            if (con1 == "Fahrenheit" && con2 == "Kelvin")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = ((5 * (f - 32)) / 9) + 273.15;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
            ////////////////////////////////////////////
            if (con1 == "Fahrenheit" && con2 == "Celcius")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = (5 * (f - 32)) / 9;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }

        }

        public void velocidad2()
        {
            //////////////METROS SEGUNDOS A
            if (con1 == "Mt/s" && con2 == "Mt/s")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    
                    pan.Text = f.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
            ////////////////////////////////////////////////////////
            if (con1 == "Mt/s" && con2 == "Km/h")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = (f * 3600) / 1000;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
            //////////////////////////////////////KILOMETROS HORA A
            if (con1 == "Km/h" && con2 == "Mt/s")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = (f * 1000) / 3600;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
            /////////////////////////////////////////////////
            if (con1 == "Km/h" && con2 == "Km/h")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    pan.Text = f.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }

        }


        public void area2()
        {
           
            ///////////////////////////////////////METROS CUADRADOS A
            if (con1 == "Metro c." && con2 == "Kilometro c.")
            {
                
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 0.000001;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            //////////////////////////////////////////////////////////////////
            if (con1 == "Metro c." && con2 == "Pie c.")
            {
                
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 10.76;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            /////////////////////////////////////////////////////
            if (con1 == "Metro c." && con2 == "Pulgada c.")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 1550;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            ///////////////////////////////////////////////////////
            if (con1 == "Metro c." && con2 == "Hectarea")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 0.0001; 
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }

            if (con1 == con2)
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    
                    pan.Text = f.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }

            
            /////////////////////////KILOMETROS CUADRADOS A
            if (con1 == "Kilometro c." && con2 == "Metro c.")
            {
                
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 1000000;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            ///////////////////////////////////
            if (con1 == "Kilometro c." && con2 == "Pie c.")
            {
                
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 10760000;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            //////////////////////////////////////////////
            if (con1 == "Kilometro c." && con2 == "Pulgada c.")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 1550000000;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            /////////////////////////////////////
            if (con1 == "Kilometro c." && con2 == "Hectarea")
            {
                
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 100;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
            

            
            ///////////////////////////PIES CUADRADOS A
            if (con1 == "Pie c." && con2 == "Metro c.")
            {
              
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 0.093;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            ////////////////////////////////////////////////////
            if (con1 == "Pie c." && con2 == "Kilometro c.")
            {
                
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 0.0000000929;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            ////////////////////////////////////////////
            if (con1 == "Pie c." && con2 == "Pulgada c.")
            {

                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 144;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            if (con1 == "Pie c." && con2 == "Hectarea")
            {
                
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 0.00000629;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }

            ////////////////////////////////////PULGADAS CUADRADAS A
            if (con1 == "Pulgada c." && con2 == "Metro c.")
            {
                
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 0.000645;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            //////////////////////////////////////////////////
            if (con1 == "Pulgada c." && con2 == "Kilometro c.")
            {
                
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 0.000000000645;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            /////////////////////////////////
            if (con1 == "Pulgada c." && con2 == "Pie c.")
            {

                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 0.00694;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            if (con1 == "Pulgada c." && con2 == "Hectarea")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 0.0000000645;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
           
            //////////////////////////////////HECTAREAS CUADRADAS A
            if (con1== "Hectarea" && con2 == "Metro c.")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 10000;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            ////////////////////////////////////////////////
            if (con1 == "Hectarea" && con2 == "Kilometro c.")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 0.01;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            /////////////////////////////////////////////////
            if (con1 == "Hectarea" && con2 == "Pie c.")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 107639;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }

            }
            if (con1 == "Hectarea" && con2 == "Pulgada c.")
            {
                try
                {
                    pan.Clear();
                    f = double.Parse(textBox1.Text);
                    h = f * 15500000;
                    pan.Text = h.ToString();
                }
                catch
                {
                    pan.Clear();
                    f = 0;
                    h = 0;
                    pan.Clear();
                    textBox1.Text = "0";
                    call.ShowDialog();
                }
            }
               
        }


        #endregion llenadodeconversiones

        #region conversiones

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = comboBox1.SelectedItem;
            if (tipo == "Masa")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                masa();
            }
            else if (tipo =="Longitud")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                longitud();
            }
            else if (tipo == "Area")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                area();
            }
            else if (tipo == "Temperatura")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                temperatura();
            }
            else if (tipo == "Datos D.")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                datos();
            }
            else if (tipo == "Tiempo")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                tiempo();
            }
            else if (tipo == "Velocidad")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                velocidad();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con1 = comboBox2.SelectedItem;
            tiempo2();
            tempe2();
            velocidad2();
            area2();
            datos2();
            longitud2();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            con2 = comboBox3.SelectedItem;
            tiempo2();
            tempe2();
            velocidad2();
            area2();
            datos2();
            longitud2();
        }



        #endregion conversiones

        #region matrices

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox19.Text = "0";
            textBox20.Text = "0";
            textBox21.Text = "0";
            textBox22.Text = "0";
            textBox23.Text = "0";
            textBox24.Text = "0";
            textBox25.Text = "0";
            textBox26.Text = "0";
            textBox27.Text = "0";
            textBox28.Text = "0";
            label7.Text = "Determinante:";
            label8.Text = "Determinante:";
            ans = 0;
            a = 0;
            b = 0;
            d = 0;
            g = 0;
            h = 0;
            temp = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //aqui multiplique la diagonal principal y su "estrella de david"
                d = (double.Parse(textBox2.Text) * double.Parse(textBox6.Text) * double.Parse(textBox10.Text)) + (double.Parse(textBox3.Text) * double.Parse(textBox7.Text) * double.Parse(textBox8.Text)) + (double.Parse(textBox4.Text) * double.Parse(textBox5.Text) * double.Parse(textBox9.Text));
                //aqui multiplique la diagonal secundaria y su "estrella de david"
                g = (double.Parse(textBox4.Text) * double.Parse(textBox6.Text) * double.Parse(textBox8.Text)) + (double.Parse(textBox5.Text) * double.Parse(textBox3.Text) * double.Parse(textBox10.Text)) + (double.Parse(textBox2.Text) * double.Parse(textBox7.Text) * double.Parse(textBox9.Text));
                //aqui esta el determinante
                h = d - g;
                //este es el determinante de la primera
                label7.Text = "Determinante: " + h.ToString();
            }
            catch
            {
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
                textBox13.Text = "0";
                textBox14.Text = "0";
                textBox15.Text = "0";
                textBox16.Text = "0";
                textBox17.Text = "0";
                textBox18.Text = "0";
                textBox19.Text = "0";
                textBox20.Text = "0";
                textBox21.Text = "0";
                textBox22.Text = "0";
                textBox23.Text = "0";
                textBox24.Text = "0";
                textBox25.Text = "0";
                textBox26.Text = "0";
                textBox27.Text = "0";
                textBox28.Text = "0";
                label7.Text = "Determinante:";
                label8.Text = "Determinante:";
                ans = 0;
                a = 0;
                b = 0;
                d = 0;
                g = 0;
                h = 0;
                temp = 0;
                call.ShowDialog();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //determinante de la segunda matriz
                //aqui multiplique la diagonal principal y su "estrella de david"
                d = (double.Parse(textBox11.Text) * double.Parse(textBox15.Text) * double.Parse(textBox19.Text)) + (double.Parse(textBox12.Text) * double.Parse(textBox16.Text) * double.Parse(textBox17.Text)) + (double.Parse(textBox14.Text) * double.Parse(textBox18.Text) * double.Parse(textBox13.Text));
                //aqui multiplique la diagonal secundaria y su "estrella de david"
                g = (double.Parse(textBox13.Text) * double.Parse(textBox15.Text) * double.Parse(textBox17.Text)) + (double.Parse(textBox12.Text) * double.Parse(textBox14.Text) * double.Parse(textBox19.Text)) + (double.Parse(textBox18.Text) * double.Parse(textBox16.Text) * double.Parse(textBox11.Text));
                //aqui esta el determinante
                h = d - g;
                //este es el determinante de la primera
                label8.Text = "Determinante: " + h.ToString();
            }
            catch
            {
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
                textBox13.Text = "0";
                textBox14.Text = "0";
                textBox15.Text = "0";
                textBox16.Text = "0";
                textBox17.Text = "0";
                textBox18.Text = "0";
                textBox19.Text = "0";
                textBox20.Text = "0";
                textBox21.Text = "0";
                textBox22.Text = "0";
                textBox23.Text = "0";
                textBox24.Text = "0";
                textBox25.Text = "0";
                textBox26.Text = "0";
                textBox27.Text = "0";
                textBox28.Text = "0";
                label7.Text = "Determinante:";
                label8.Text = "Determinante:";
                ans = 0;
                a = 0;
                b = 0;
                d = 0;
                g = 0;
                h = 0;
                temp = 0;
                call.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //aqui hago la suma de matrices
                textBox20.Text = (double.Parse(textBox2.Text) + double.Parse(textBox11.Text)).ToString();
                textBox21.Text = (double.Parse(textBox3.Text) + double.Parse(textBox12.Text)).ToString();
                textBox22.Text = (double.Parse(textBox4.Text) + double.Parse(textBox13.Text)).ToString();
                textBox23.Text = (double.Parse(textBox5.Text) + double.Parse(textBox14.Text)).ToString();
                textBox24.Text = (double.Parse(textBox6.Text) + double.Parse(textBox15.Text)).ToString();
                textBox25.Text = (double.Parse(textBox7.Text) + double.Parse(textBox16.Text)).ToString();
                textBox26.Text = (double.Parse(textBox8.Text) + double.Parse(textBox17.Text)).ToString();
                textBox27.Text = (double.Parse(textBox9.Text) + double.Parse(textBox18.Text)).ToString();
                textBox28.Text = (double.Parse(textBox10.Text) + double.Parse(textBox19.Text)).ToString();
            }
            catch
            {
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
                textBox13.Text = "0";
                textBox14.Text = "0";
                textBox15.Text = "0";
                textBox16.Text = "0";
                textBox17.Text = "0";
                textBox18.Text = "0";
                textBox19.Text = "0";
                textBox20.Text = "0";
                textBox21.Text = "0";
                textBox22.Text = "0";
                textBox23.Text = "0";
                textBox24.Text = "0";
                textBox25.Text = "0";
                textBox26.Text = "0";
                textBox27.Text = "0";
                textBox28.Text = "0";
                label7.Text = "Determinante:";
                label8.Text = "Determinante:";
                ans = 0;
                a = 0;
                b = 0;
                d = 0;
                g = 0;
                h = 0;
                temp = 0;
                call.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //aqui hago la resta de matrices
            try
            {
                //aqui hago la resta de matrices
                textBox20.Text = (double.Parse(textBox2.Text) - double.Parse(textBox11.Text)).ToString();
                textBox21.Text = (double.Parse(textBox3.Text) - double.Parse(textBox12.Text)).ToString();
                textBox22.Text = (double.Parse(textBox4.Text) - double.Parse(textBox13.Text)).ToString();
                textBox23.Text = (double.Parse(textBox5.Text) - double.Parse(textBox14.Text)).ToString();
                textBox24.Text = (double.Parse(textBox6.Text) - double.Parse(textBox15.Text)).ToString();
                textBox25.Text = (double.Parse(textBox7.Text) - double.Parse(textBox16.Text)).ToString();
                textBox26.Text = (double.Parse(textBox8.Text) - double.Parse(textBox17.Text)).ToString();
                textBox27.Text = (double.Parse(textBox9.Text) - double.Parse(textBox18.Text)).ToString();
                textBox28.Text = (double.Parse(textBox10.Text) - double.Parse(textBox19.Text)).ToString();
            }
            catch
            {
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
                textBox13.Text = "0";
                textBox14.Text = "0";
                textBox15.Text = "0";
                textBox16.Text = "0";
                textBox17.Text = "0";
                textBox18.Text = "0";
                textBox19.Text = "0";
                textBox20.Text = "0";
                textBox21.Text = "0";
                textBox22.Text = "0";
                textBox23.Text = "0";
                textBox24.Text = "0";
                textBox25.Text = "0";
                textBox26.Text = "0";
                textBox27.Text = "0";
                textBox28.Text = "0";
                label7.Text = "Determinante:";
                label8.Text = "Determinante:";
                ans = 0;
                a = 0;
                b = 0;
                d = 0;
                g = 0;
                h = 0;
                temp = 0;
                call.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //aqui multiplico las matrices
            try
            {
                //aqui hago la multiplicaicon de matrices
                textBox20.Text = ((double.Parse(textBox2.Text) * double.Parse(textBox11.Text)) + (double.Parse(textBox3.Text) * double.Parse(textBox14.Text)) + (double.Parse(textBox4.Text) * double.Parse(textBox17.Text))).ToString();
                textBox23.Text = ((double.Parse(textBox5.Text) * double.Parse(textBox11.Text)) + (double.Parse(textBox6.Text) * double.Parse(textBox14.Text)) + (double.Parse(textBox7.Text) * double.Parse(textBox17.Text))).ToString();
                textBox26.Text = ((double.Parse(textBox8.Text) * double.Parse(textBox11.Text)) + (double.Parse(textBox9.Text) * double.Parse(textBox14.Text)) + (double.Parse(textBox10.Text) * double.Parse(textBox17.Text))).ToString();
                textBox21.Text = ((double.Parse(textBox2.Text) * double.Parse(textBox12.Text)) + (double.Parse(textBox3.Text) * double.Parse(textBox15.Text)) + (double.Parse(textBox4.Text) * double.Parse(textBox18.Text))).ToString();
                textBox24.Text = ((double.Parse(textBox5.Text) * double.Parse(textBox12.Text)) + (double.Parse(textBox6.Text) * double.Parse(textBox15.Text)) + (double.Parse(textBox7.Text) * double.Parse(textBox18.Text))).ToString();
                textBox27.Text = ((double.Parse(textBox8.Text) * double.Parse(textBox12.Text)) + (double.Parse(textBox9.Text) * double.Parse(textBox15.Text)) + (double.Parse(textBox10.Text) * double.Parse(textBox18.Text))).ToString();
                textBox22.Text = ((double.Parse(textBox2.Text) * double.Parse(textBox13.Text)) + (double.Parse(textBox3.Text) * double.Parse(textBox16.Text)) + (double.Parse(textBox4.Text) * double.Parse(textBox19.Text))).ToString();
                textBox25.Text = ((double.Parse(textBox5.Text) * double.Parse(textBox13.Text)) + (double.Parse(textBox6.Text) * double.Parse(textBox16.Text)) + (double.Parse(textBox7.Text) * double.Parse(textBox19.Text))).ToString();
                textBox28.Text = ((double.Parse(textBox8.Text) * double.Parse(textBox13.Text)) + (double.Parse(textBox9.Text) * double.Parse(textBox16.Text)) + (double.Parse(textBox10.Text) * double.Parse(textBox19.Text))).ToString();
            }
            catch
            {
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
                textBox13.Text = "0";
                textBox14.Text = "0";
                textBox15.Text = "0";
                textBox16.Text = "0";
                textBox17.Text = "0";
                textBox18.Text = "0";
                textBox19.Text = "0";
                textBox20.Text = "0";
                textBox21.Text = "0";
                textBox22.Text = "0";
                textBox23.Text = "0";
                textBox24.Text = "0";
                textBox25.Text = "0";
                textBox26.Text = "0";
                textBox27.Text = "0";
                textBox28.Text = "0";
                label7.Text = "Determinante:";
                label8.Text = "Determinante:";
                ans = 0;
                a = 0;
                b = 0;
                d = 0;
                g = 0;
                h = 0;
                temp = 0;
                call.ShowDialog();
            }
        }

        #endregion matrices
    }
}
