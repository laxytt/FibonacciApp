using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciApp
{
    public partial class FibonacciSeries : Form
    {
        public FibonacciSeries()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public static int fib(int n)                                         // Funkcja liczy n-ty wyraz ciągu fibonacciego
        {
            if (n == 0) return 1;
            if (n == 1) return 2;
            return fib(n - 1) + fib(n - 2);
        }

        private void button1_Click(object sender, EventArgs e)               // Generuje wydarzenie dla przycisku Generate
        {
         
            try                                                              // Obsługa wyjątku(błędu)
            {
                int Fn = 0;                                                  // zmienna, dla początkowego wyrazu ciągu
                int n = Convert.ToInt16(nValue.Text);                        // przypisuje zmiennej n wartość z textBoxa dla n



                for (int i = 0; i <= n; i++)                                 // pętla działająca dopóki iterowane i nie będzie mniejsze lub równe od n
                {

                    int y = fib(i);                                          // inicjiuje i przypisuje zmiennej x wartosc ciągu dla i
                    Fn += fib(i);                                            // fn = fn+fib(i), sumuje wszystkie wyrazy ciągu
                    chart1.Series[0].Points.AddXY(i + " n", y);              // rysuje wykres o wartosci x =i oraz y=y
                }
                sumValue.Text = (Fn).ToString();                               // przypisuje nam wartość Fn do okienka




            }catch (Exception)                                                 // catch wyłapuję bład 
            {
                MessageBox.Show("Podaj wartości liczbowe");                    // Wyyświetla messegeBox z komunikatem o błędzie
            }
        }
    }
    
}
