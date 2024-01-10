﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container_Vervoer.Classes
{
    public class ContainerStapel
    {
        List<Container> Stapel = new List<Container>();
        public bool WaardevolCheck()
        {
            bool status = false;
            foreach(Container container in Stapel)
            {
                if(container.Type == Type.Waardevol)
                {
                    status = true;
                    break;
                }
            }
            return status;
        }
        public int AantalContainers()
        {
            return Stapel.Count;
        }
        public int Gewicht()
        {
            int gewicht = 0;
            foreach(Container container in Stapel)
            {
                gewicht = +container.Gewicht;
            }
            return gewicht;
        }
        public bool RuimteCheck(Container container)
        {
            if (Gewicht() + container.Gewicht < 120)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Toevoegen(Container container)
        {
            if(WaardevolCheck() || !RuimteCheck(container))
            {
                return false;
            }
            Stapel.Add(container);
            return true;
        }
    }
}
