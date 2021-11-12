using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodBYT.Models
{
    class ConcreteCalculator : AbstractCalculator
    {
        string operationSign;

        public ConcreteCalculator(String _operationSign)
        {
            operationSign = _operationSign;
        }
        protected override void Calculations()
        {
            if (operationSign.Equals("+")) { 
                Console.WriteLine(calculation.arg1 + calculation.arg2);
            }
            else if (operationSign.Equals("-")) { 
                Console.WriteLine(calculation.arg1 - calculation.arg2);
            }
            else if (operationSign.Equals("*")) { 
                Console.WriteLine(calculation.arg1 * calculation.arg2);
            }
            else if (operationSign.Equals("/")) { 
                Console.WriteLine(calculation.arg1 / calculation.arg2);
            }else { Console.WriteLine("sign is does not exist"); }
        }
    }
}
