using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class ValidarTrianguloService
    {

        public double calcularDistancia(Punto p1, Punto p2)
        {
            double Res = Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y));
            return Res;
        }

        public double obtenerMayor(double d1, double d2, double d3)
        {
            if (d1 >= d2 && d1 >= d3)
            {
                return d1;
            }
            else if (d2 >= d1 && d2 >= d3)
            {
                return d2;
            }
            else
            {
                return d3;
            }
        }
        
        public bool validarTriangulo(Triangulo triangulo)
        {
            double distancia1 = calcularDistancia(triangulo.punto1, triangulo.punto2);
            double distancia2 = calcularDistancia(triangulo.punto2, triangulo.punto3);
            double distancia3 = calcularDistancia(triangulo.punto3, triangulo.punto1);

            double ladoMayor = obtenerMayor(distancia1, distancia2, distancia3);
            double sumaLados = distancia1 + distancia2 + distancia3 - ladoMayor;

            return ladoMayor < sumaLados;
        }

        public string obtenerTipo(Triangulo triangulo)
        {
            double distancia1 = Math.Round(calcularDistancia(triangulo.punto1, triangulo.punto2),2);
            double distancia2 = Math.Round(calcularDistancia(triangulo.punto2, triangulo.punto3),2);
            double distancia3 = Math.Round(calcularDistancia(triangulo.punto3, triangulo.punto1),2);

            if (distancia1 == distancia2 && distancia2 == distancia3)
                return "Equilátero";
            else if (distancia1 == distancia2 || distancia1  == distancia3 || distancia2 == distancia3)
                return "Isósceles";
            else
                return "Escaleno";
        }
        public double CalcularArea(Triangulo triangulo)
        {
            double distancia1 = calcularDistancia(triangulo.punto1, triangulo.punto2);
            double distancia2 = calcularDistancia(triangulo.punto2, triangulo.punto3);
            double distancia3 = calcularDistancia(triangulo.punto3, triangulo.punto1);

            // Formula de Heron area = sqrt(s * (s - lado1) * (s - lado2) * (s - lado3))
            double semiperimetro = (distancia1 + distancia2 + distancia3) / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - distancia1) * 
                (semiperimetro - distancia2) * (semiperimetro - distancia3));
            return area;
        }
    }



}