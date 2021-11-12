using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodBYT.Models
{
    abstract class AbstractCalculator
    {
        public float Arg1 { get; set; }
        public float Arg2 { get; set; }
        public Calculation calculation { get; set; }

        public void TemplateMethod()
        {
            InsertArg1();
            InsertArg2();
            InsertCalculation();
            Calculations();
        }
        protected void InsertArg1()
        {
            Console.WriteLine("TEMPLATE CALCULATOR");
            Console.WriteLine("Enter ARG1");
            Arg1 = float.Parse(Console.ReadLine());
        }

        protected void InsertArg2()
        {
            Console.WriteLine("Enter ARG2");
            Arg2 = float.Parse(Console.ReadLine());
        }

        private void InsertCalculation()
        {
            calculation = new Calculation(Arg1, Arg2);
        }


        protected abstract void Calculations();
    }
}
