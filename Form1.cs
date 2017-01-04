using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allMyCircuts
{
    public partial class Form1 : Form
    {
        Model myModel;

        public Form1()
        {
            InitializeComponent();
            myModel = new Model();
            lblDisplay.Text = "0";
        }

        private void numButton_Click(object sender, EventArgs e)
        {
            //todo switch case for numbers
            Button button = sender as Button;
           // lblDisplay.Text = button.Text;
            switch (button.Text)
            {
                case "0":
                  //  lblDisplay.Text = button.Text;
                   // myModel.getDisplayNum();
                    myModel.num(0);
                    break;
                case "1":
                   // lblDisplay.Text = button.Text;
                   // myModel.getDisplayNum();
                    myModel.num(1);
                    break;
                case "2":
                   // lblDisplay.Text = button.Text;
                   // myModel.getDisplayNum();
                    myModel.num(2);
                    break;
                case "3":
                  //  lblDisplay.Text = button.Text;
                   // myModel.getDisplayNum();
                    myModel.num(3);
                    break;
                case "4":
                  //  lblDisplay.Text = button.Text;
                   // myModel.getDisplayNum();
                    myModel.num(4);
                    break;
                case "5":
                   // lblDisplay.Text = button.Text;
                  //  myModel.getDisplayNum();
                    myModel.num(5);
                    break;
                case "6":
                   // lblDisplay.Text = button.Text;
                  //  myModel.getDisplayNum();
                    myModel.num(6);
                    break;
                case "7":
                   // lblDisplay.Text = button.Text;
                  //  myModel.getDisplayNum();
                    myModel.num(7);
                    break;
                case "8":
                   // lblDisplay.Text = button.Text;
                  //  myModel.getDisplayNum();
                    myModel.num(8);
                    break;
                case "9":
                   // lblDisplay.Text = button.Text;
                  //  myModel.getDisplayNum();
                    myModel.num(9);
                    break;
                default:
                    lblDisplay.Text = "ERROR";
                    break;
            }
           lblDisplay.Text = myModel.getDisplayNum();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            myModel.convertToDecimal();
           // myModel.getDisplayNum();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }


        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

      /*  private void Form1_Load(object sender, EventArgs e)
        {

        } */

        private void clear_Click(object sender, EventArgs e)
        {
           
            
             myModel.clear();
             lblDisplay.Text = "0";
        }

        

        
    }
}
