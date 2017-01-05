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
        String PrevOperation;

        public Model()
        {

        }

        public void num(int newNum)
        {
            if (CurrentOperation == "=")
            {
                displayNum = null;
                CurrentOperation = null;
            }

            if (CurrentOperation == null)
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
            else 
            {
                // displayNum = null;
                doubleTotal = currentDouble;
                total = currentNum;

               

                if (isDecimal)
                {
                    displayNum += newNum.ToString();
                    currentDouble = Convert.ToDouble(displayNum);

                    
                   // displayNum = doubleTotal.ToString();
                }
                else
                {
                    displayNum += newNum.ToString();
                    currentNum = Convert.ToInt16(displayNum);

                    
                }//end esle

               
            }//endelse
            
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
            CurrentOperation = "+";
           // PrevOperation = CurrentOperation;
           
           // currentDouble = doubleTotal;
           // currentNum = total;
            
            isDecimal = false;
            displayNum = null;
        }

        public void multiply()
        {
            CurrentOperation = "*";
            isDecimal = false;
            displayNum = null;
        }

        public void subtract()
        {
            CurrentOperation = "-";
            isDecimal = false;
            displayNum = null;
        }

        public void divide()
        {
            CurrentOperation = "/";
            isDecimal = false;
            displayNum = null;
        }

        public void equal()
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
            
            currentDouble = doubleTotal;
            currentNum = total;
            CurrentOperation = "=";
        }//end equal


    }
}
