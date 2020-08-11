using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalAssignClassLib
{
    public class CalAssign
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public double Add()
        {
            return num1 + num2;
        }
        public double Sub()
        {
            return num1 - num2;
        }
        public double Mul()
        {
            return num1 * num2;
        }
        public double Div()
        {
            return num1 / num2;
        }
    }
}
