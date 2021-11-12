using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodBYT.Models
{
    class Calculation
    {
        public float arg1 { get; set; }
        public float arg2 { get; set; }
        public string operationSign { get; set; }
        public float result { get; set; }


       public Calculation (float _arg1, float _arg2)
        {
            arg1 = _arg1;
            arg2 = _arg2;
        }
    }
}
