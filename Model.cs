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
        String CurrentOperation;
        public Model()
        {

        }

        public void num(int newNum)
        {
            currentNum = newNum;
        }

        public String getDisplayNum()
        {
            displayNum += currentNum.ToString();

            return displayNum;
        }

    }
}
