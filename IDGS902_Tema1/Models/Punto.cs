using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Models
{
    public class Punto
    {
        public double x { get; set; }
        public double y { get; set; }

    }

    public class Triangulo
    {
        public Punto punto1 { get; set; }
        public Punto punto2 { get; set; }
        public Punto punto3 { get; set; }
    }
}