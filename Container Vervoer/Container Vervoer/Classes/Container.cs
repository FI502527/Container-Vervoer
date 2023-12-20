using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container_Vervoer.Classes
{
    public class Container
    {
        public string Naam { get; set; }
        public int Gewicht { get; set; } //IN TON NIET KG
        public Type Type { get; }

        public Container(string naam, int gewicht, Type type)
        {
            Naam = naam;
            GewichtMaken(gewicht); // SET ALS PROPERTY 
            Type = type;
        }
        public void GewichtMaken(int gewicht) // PRIVATE
        {
            if (gewicht < 4)
            {
                Gewicht = 4; // VERVANG MET EXCEPTION
            }
            else if (gewicht > 30)
            {
                Gewicht = 30;
            }
            else
            {
                Gewicht = gewicht;
            }
        }
    }
}
