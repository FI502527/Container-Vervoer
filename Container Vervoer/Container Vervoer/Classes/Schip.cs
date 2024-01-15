﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container_Vervoer.Classes
{
    public class Schip
    {
        public List<Rij> Rijen = new List<Rij>();
        public int MaxGewicht { get; }
        public int Breedte { get; }
        public int Lengte { get; }
        public Schip(int maxGewicht, int breedte, int lengte)
        {
            MaxGewicht = maxGewicht;
            Breedte = breedte;
            Lengte = lengte;
            MaakRijen();
        }
        public void MaakRijen()
        {
            for(int i = 0; i < Breedte; i++)
            {
                Rijen.Add(new Rij(Lengte));
            }
        }
        public int Gewicht()
        {
            int gewicht = 0;
            foreach(Rij rij in Rijen)
            {
                gewicht =+ rij.Gewicht();
            }
            return gewicht;
        }
    }
}
