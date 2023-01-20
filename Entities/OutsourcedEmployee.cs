using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_3.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee (double additionalCharge) : base(string name, int hours, double valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
    }

}
