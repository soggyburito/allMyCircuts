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

        public void num(int newNum)
        {
            currentNum = newNum;
            
        }

        public String getDisplayNum()
        {
            if (isDecimal)
            {
                displayNum += currentNum.ToString();
               currentDouble = Convert.ToDouble(displayNum);
                
                return displayNum;
            }
            else
            {
                displayNum += currentNum.ToString();
              currentNum = Convert.ToInt16(displayNum);
                return displayNum;
            }

            
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




    }
}
