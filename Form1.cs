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
        double temp;
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
                    myModel.num(0,0.0);
                    break;
                case "1":
                 // temp =  Convert.ToDouble(lblDisplay.Text) ;
                   // myModel.getDisplayNum();
                    myModel.num(1,temp);
                    break;
                case "2":
                   // temp = Convert.ToDouble(lblDisplay.Text);
                   // myModel.getDisplayNum();
                    myModel.num(2,temp);
                    break;
                case "3":
                   // temp = Convert.ToDouble(lblDisplay.Text);
                   // myModel.getDisplayNum();
                    myModel.num(3,temp);
                    break;
                case "4":
                    //temp = Convert.ToDouble(lblDisplay.Text);
                   // myModel.getDisplayNum();
                    myModel.num(4,temp);
                    break;
                case "5":
                   //temp =  Convert.ToDouble(lblDisplay.Text) ;
                  //  myModel.getDisplayNum();
                    myModel.num(5,temp);
                    break;
                case "6":
                    //temp = Convert.ToDouble(lblDisplay.Text);
                  //  myModel.getDisplayNum();
                    myModel.num(6,temp);
                    break;
                case "7":
                   // temp = Convert.ToDouble(lblDisplay.Text);
                  //  myModel.getDisplayNum();
                    myModel.num(7,temp);
                    break;
                case "8":
                    //temp = Convert.ToDouble(lblDisplay.Text);
                  //  myModel.getDisplayNum();
                    myModel.num(8,temp);
                    break;
                case "9":
                   // temp = Convert.ToDouble(lblDisplay.Text);
                  //  myModel.getDisplayNum();
                    myModel.num(9,temp);
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
            myModel.equal();
           lblDisplay.Text =  myModel.getDisplayNum();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            myModel.add();
           lblDisplay.Text = myModel.getDisplayNum();
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            myModel.subtract();
            lblDisplay.Text = myModel.getDisplayNum();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            myModel.multiply();
            lblDisplay.Text = myModel.getDisplayNum();
        }


        private void btnDivide_Click(object sender, EventArgs e)
        {
            myModel.divide();
            lblDisplay.Text = myModel.getDisplayNum();
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
