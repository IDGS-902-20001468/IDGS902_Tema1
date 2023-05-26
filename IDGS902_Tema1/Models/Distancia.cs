using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Models
{
    public class Distancia
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double Res { get; set; }

        public double calcular(double X1, double Y1, double X2, double Y2 ) {
            double Res = Math.Sqrt((X2 - X1)*(X2-X1)+ (Y2 - Y1) * (Y2 - Y1));
            return Res;
        }
    }

}