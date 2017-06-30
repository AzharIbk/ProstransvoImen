using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    namespace NAccount
    {
        class Account
        {

            string accNumber;
            string pass;
            double amount;

            string CreateAccNumber()
            {
                Random rnum = new Random();
                accNumber = rnum.Next(1, 100).ToString();
                return accNumber;
            }

            string CreatePass()
            {
                Random rnum = new Random();
                pass="pass"+rnum
            }         

        }
    }
}
