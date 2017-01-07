using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allMyCircuts
{
    class Model
    {
        int currentNum = 0;
        int total = 0;
        String displayNum;
        String CurrentOperation = null;
        double currentDouble = 0.0;
        double doubleTotal = 0.0;
        bool isDecimal = false;
      

        public Model()
        {

        }

        public void num(int newNum, double newDouble)
        {
            if (CurrentOperation == "=")
            {
                displayNum = null;
                CurrentOperation = null;
            }
            else if (CurrentOperation == "+" || CurrentOperation == "-" || CurrentOperation == "*" || CurrentOperation == "/")
            {
               // displayNum = null;
                if (isDecimal)
                {
                    displayNum += newNum.ToString();
                    currentDouble = Convert.ToDouble(displayNum);


                }
                else
                {
                    displayNum += newNum.ToString();
                    currentNum = Convert.ToInt16(displayNum);
                }
            }
            else
            {


                if (isDecimal)
                {
                    displayNum += newNum.ToString();
                    currentDouble = Convert.ToDouble(displayNum);


                }
                else
                {
                    displayNum += newNum.ToString();
                    currentNum = Convert.ToInt16(displayNum);

                }
            }
               // total = currentNum;
                //doubleTotal = currentDouble;
            
        }//end num

        public String getDisplayNum()
        {
            return displayNum;
        }

        
        
        public void clear()
        {
            currentNum = 0;
            total = 0;

            displayNum = null;
            CurrentOperation = null;
            currentDouble = 0.0;
            doubleTotal = 0.0;
            isDecimal = false;
               
        }

        public void convertToDecimal()
        {
            if (!isDecimal)
            {
                isDecimal = true;
               // currentDouble = Convert.ToDouble(currentNum);
                displayNum += ".";
            }
          

        }

        public void add()
        {
           displayNum = null;
               
                if (total == 0 && doubleTotal == 0.0)
                {
                    if (isDecimal)
                    {
                        doubleTotal = currentDouble;
                        isDecimal = false;
                    }
                    else
                    {
                        total = currentNum;
                    }
                }
                else
               {
                   this.evaluate();
               }
                //isDecimal = false;
                 CurrentOperation = "+";
               // currentDouble = 0.0;
                //currentNum = 0;
            
        }

        public void multiply()
        {displayNum = null;
            
            if (total == 0 && doubleTotal == 0.0)
            {
                if (isDecimal)
                {
                    doubleTotal = currentDouble;
                    isDecimal = false;
                }
                else
                {
                    total = currentNum;
                }
            }
            else
            {
                this.evaluate();
            }
           
          //  isDecimal = false;
            CurrentOperation = "*";
            //currentDouble = 0.0;
            //currentNum = 0;
           
        }

        public void subtract()
        {displayNum = null;
           
            if (total == 0 && doubleTotal == 0.0)
            {
                if (isDecimal)
                {
                     doubleTotal = currentDouble;
                     isDecimal = false;
                }
                else
                {
                    total = currentNum;
                }
               
                
            }
            else
            {
                this.evaluate();
            }
           
           // isDecimal = false;
             CurrentOperation = "-";
            //currentDouble = 0.0;
            //currentNum = 0;
            
        }

        public void divide()
        {displayNum = null;
            
            if (total == 0 && doubleTotal == 0.0)
            {
                if (isDecimal)
                {
                    doubleTotal = currentDouble;
                    isDecimal = false;
                }
                else
                {
                    total = currentNum;
                }
            }
            else
            {
                this.evaluate();
            }
           CurrentOperation = "/";
           // isDecimal = false;
            
         
        }

        public void equal()
        {
            this.evaluate();
            CurrentOperation = "=";
            isDecimal = false;
           // operationSet = false;
        }//end equal

        private void evaluate()
        {
            
            if (isDecimal)
            {
                switch (CurrentOperation)
                {
                    case "+":
                        doubleTotal += currentDouble;
                        displayNum = doubleTotal.ToString();
                        break;
                    case "-":
                        doubleTotal -= currentDouble;
                        displayNum = doubleTotal.ToString();
                        break;
                    case "*":
                        doubleTotal *= currentDouble;
                        displayNum = doubleTotal.ToString();
                        break;
                    case "/":
                        doubleTotal /= currentDouble;
                        displayNum = doubleTotal.ToString();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (CurrentOperation)
                {
                    case "+":
                        total += currentNum;
                        displayNum = total.ToString();
                        break;
                    case "-":
                        total -= currentNum;
                        displayNum = total.ToString();
                        break;
                    case "*":
                        total *= currentNum;
                        displayNum = total.ToString();
                        break;
                    case "/":
                        total /= currentNum;
                        displayNum = total.ToString();
                        break;
                    default:
                        break;
                }
            }//end esle  

            //currentDouble = doubleTotal;
            //currentNum = total;
           
        }//end evaluate


    }
}
