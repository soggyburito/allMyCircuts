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
        bool operationChanged = false;
        bool isDouble = false;

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
            else
            {
                if (operationChanged)
                {
                    if (displayNum != "-") {
                        displayNum = null;
                    }
                    
                    operationChanged = false;
                }

                if (isDecimal||isDouble)
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
            operationChanged = false;
            isDouble = false;
        }

        public void convertToDecimal()
        {
            if (!isDecimal)
            {
                isDecimal = true;
                isDouble = true;
               // currentDouble = Convert.ToDouble(currentNum);
                displayNum += ".";
            }
          

        }

        public void convertToNegative(){
            if (displayNum == null)
            {
                displayNum = "-";
            }
            else if (currentNum == 0 || currentDouble == 0)
            {
                displayNum = "-";
                
            }
            else
            {
                displayNum = displayNum.Insert(0, "-");
                if (isDecimal || isDouble)
                {

                    currentDouble = Convert.ToDouble(displayNum);


                }
                else
                {

                    currentNum = Convert.ToInt16(displayNum);

                }//end inner else
            }// end outer else

        }

        public void operations(String newOp)
        {
           
           // displayNum = null;
            if (total == 0 && doubleTotal == 0.0)
            {
                doubleTotal = currentDouble;
                total = currentNum;
            }
            else
            {
                if (isDecimal||isDouble)
                {
                    
                    switch (CurrentOperation)
                    {
                        case "+":
                            doubleTotal += currentDouble;
                            //displayNum = doubleTotal.ToString();
                            break;
                        case "-":
                            doubleTotal -= currentDouble;
                            //displayNum = doubleTotal.ToString();
                            break;
                        case "*":
                            doubleTotal *= currentDouble;
                           // displayNum = doubleTotal.ToString();
                            break;
                        case "/":
                            doubleTotal /= currentDouble;
                           // displayNum = doubleTotal.ToString();
                            break;
                        case "%":
                            doubleTotal = doubleTotal%currentDouble;
                          //  displayNum = doubleTotal.ToString();
                            break;
                        default:
                            displayNum = doubleTotal.ToString();
                            isDouble = false;
                            break;
                    }//end switch
                    currentDouble = 0.0;
                    displayNum = doubleTotal.ToString();
                }
                else
                {
                    switch (CurrentOperation)
                    {
                        case "+":
                            total += currentNum;
                          //  displayNum = total.ToString();
                            break;
                        case "-":
                            total -= currentNum;
                           // displayNum = total.ToString();
                            break;
                        case "*":
                            total *= currentNum;
                            //displayNum = total.ToString();
                            break;
                        case "/":
                            total /= currentNum;
                            //displayNum = total.ToString();
                            break;
                        case "%":
                            total = total%currentNum;
                            //displayNum = total.ToString();
                            break;
                        default:
                            displayNum = total.ToString();
                            break;
                    }//end switch
                    currentNum = 0;
                    displayNum = total.ToString();
                }//end esle 
                
            }//end else

            operationChanged = true;
            
            CurrentOperation = newOp;
            isDecimal = false;
        }//end operations

    }
}
