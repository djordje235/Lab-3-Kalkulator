using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nekikalkulator
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
        }
        private double EvaluateExpression(string expression)
        {
           
            System.Data.DataTable dataTable = new System.Data.DataTable();

            
            return Convert.ToDouble(dataTable.Compute(expression, string.Empty));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += clickedButton.Text;
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains('.'))
            {
                
                TxtBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += clickedButton.Text;
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += clickedButton.Text;
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += clickedButton.Text;
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += clickedButton.Text;
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += clickedButton.Text;
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += clickedButton.Text;
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += clickedButton.Text;
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += clickedButton.Text;
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += clickedButton.Text;
        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBox.Text))
            {
              
                if (double.TryParse(TxtBox.Text, out double currentNumber))
                {
                   
                    currentNumber = -currentNumber;

                   
                    TxtBox.Text = currentNumber.ToString();
                }
                else
                {
                    
                    MessageBox.Show("Trenutni unos nije validan broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            
            TxtBox.Text += " " + clickedButton.Text + " ";  
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += " " + clickedButton.Text + " ";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += " " + clickedButton.Text + " ";
        }

        private void DevideBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            
            TxtBox.Text += " " + clickedButton.Text + " ";
            
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                string expression = TxtBox.Text;

             
                double result = EvaluateExpression(expression);


                TxtBox.Text = TxtBox.Text + " = " + result.ToString();

                MessageBox.Show(TxtBox.Text+ " = " + result.ToString());
              
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Greška: {ex.Message}", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CBtn_Click(object sender, EventArgs e)
        {

            TxtBox.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da napustite program?", "Potvrda izlaska", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void DateBtn_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(DateTime.Now.ToCustomDateTimeFormat());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            TxtBox.Text += " " + clickedButton.Text + " ";
        }
    }
}
