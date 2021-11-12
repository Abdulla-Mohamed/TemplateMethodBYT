using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodBYT.Models
{
    class Client
    {
        public static void ClientCode(AbstractCalculator abstractCalculator)
        {
            abstractCalculator.TemplateMethod();
        }
    }
}
