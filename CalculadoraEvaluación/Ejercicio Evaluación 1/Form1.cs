using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Evaluación_1
{
    public partial class Form1 : Form
    {

        //Aqui van las variables de afuera

        float numero1, numero2, contador=0, resultado;
        string store="";
        int suma=0, dividir=0, multi=0, resta=0;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //esto limpia la pantalla y las variables numericas guardadas, "reinicia la calculadora"
            txtScreen.Text = "";
            store = "";
            contador = 0;
        }

        //Estos son los botones numericos

        private void btn1_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 1;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 1;
                txtScreen.Text = store;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 2;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 2;
                txtScreen.Text = store;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 3;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 3;
                txtScreen.Text = store;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 4;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 4;
                txtScreen.Text = store;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 5;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 5;
                txtScreen.Text = store;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 6;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 6;
                txtScreen.Text = store;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 7;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 7;
                txtScreen.Text = store;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 8;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 8;
                txtScreen.Text = store;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 9;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 9;
                txtScreen.Text = store;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 0;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 0;
                txtScreen.Text = store;
            }
        }

        //Este es el boton que cambia el signo de los numeros

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (contador == 0 && store != "")
            {

                numero1 = float.Parse(store);
                numero1 = (-1) * numero1;
                store = "" + numero1;
                txtScreen.Text = store;

            }
            else
            {
                if (store != "")
                {
                    numero2 = float.Parse(store);
                    numero2 = (-1) * numero2;
                    store = "" + numero2;
                    txtScreen.Text = store;
                }
            }
        }

        //El boton de resultado


        //Funciona mirando un contador especifico para cada boton operador

        //Por ejemplo, si le das al boton de sumar hara que el contador sea 1 y al darle
        //al boton de resultado te hara la suma de las variables.

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (suma == 1 && store != "") //Procedimiento de suma
            {
                numero2 = float.Parse(store);
                resultado = numero1 + numero2;
                txtScreen.Text = "" + resultado;
                store = "" + resultado;
                contador = 0;
                suma = 0;
                resta = 0;
                dividir = 0;
                multi = 0;
            }
            else
            {

                if (resta == 1) //Procedimiento de resta
                {
                    numero2 = float.Parse(store);
                    resultado = numero1 - numero2;
                    txtScreen.Text = "" + resultado;
                    store = "" + resultado;
                    contador = 0;
                    suma = 0;
                    resta = 0;
                    dividir = 0;
                    multi = 0;
                }
                else
                {

                    if (dividir == 1) //Procedimiento de Dividir
                    {
                        numero2 = float.Parse(store);
                        resultado = numero1 / numero2;
                        txtScreen.Text = "" + resultado;
                        store = ""+resultado;
                        contador = 0;
                        suma = 0;
                        resta = 0;
                        dividir = 0;
                        multi = 0;
                    }
                    else
                    {

                        if (multi == 1) //Procedimiento de Multiplicar
                        {
                            numero2 = float.Parse(store);
                            resultado = numero1 * numero2;
                            txtScreen.Text = "" + resultado;
                            store = "" + resultado;
                            contador = 0;
                            suma = 0;
                            resta = 0;
                            dividir = 0;
                            multi = 0;
                        }
                        else //Procedimiento de Error
                        {

                            MessageBox.Show("Error");

                        }

                    }

                }

            }
        }

        //Los botones de operación

            //Aqui el boton de sumar

        private void btnSumar_Click(object sender, EventArgs e)
        {

            if (contador== 0 && store != "")
            {

                numero1 = float.Parse(store);
                contador = 1;
                txtScreen.Text = "+";
                store = "0";
                suma = 1;

            }

        }

            //Aqui el boton de restar

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (contador == 0 && store != "")
            {

                numero1 = float.Parse(store);
                contador = 1;
                txtScreen.Text = "-";
                store = "0";
                resta = 1;

            }
        }

            //Aqui el boton de multiplicar

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (contador == 0 && store != "")
            {

                numero1 = float.Parse(store);
                contador = 1;
                txtScreen.Text = "X";
                store = "0";
                multi = 1;

            }
        }

            //Aqui el boton de dividir

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (contador == 0 && store != "")
            {

                numero1 = float.Parse(store);
                contador = 1;
                txtScreen.Text = "/";
                store = "0";
                dividir = 1;

            }
        }



    }
}
