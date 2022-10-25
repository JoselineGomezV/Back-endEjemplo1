using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back_endEjemplo1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }
        public void suma()
        {
            this.Res = this.Num1 + this.Num2;
        }
        public void resta()
        {
            this.Res = this.Num1 - this.Num2;
        }
    }
}