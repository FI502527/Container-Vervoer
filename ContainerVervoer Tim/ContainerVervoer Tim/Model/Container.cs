using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer_Tim.Model
{
    public class Containers
    {
        public string Naam { get; set; }
        public int Gewicht { get; set; } //IN TON NIET KG
        public Type Type { get; }

        public Containers(string naam, int gewicht, Type type)
        {
            Naam = naam;
            GewichtMaken(gewicht);
            Type = type;
        }
        public void GewichtMaken(int gewicht)
        {
            if (gewicht < 4 || gewicht > 30)
            {
                Console.WriteLine("Gewicht moet tussen 4 en 30 ton zijn!");
            }
            Gewicht = gewicht;
        }
        public override string ToString()
        {
            return $"Container {Naam} is {Gewicht} ton en {Type}.";
        }
    }
}
