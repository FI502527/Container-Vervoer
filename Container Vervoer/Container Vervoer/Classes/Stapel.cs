using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container_Vervoer.Classes
{
    public class Stapel
    {
        public List<Container> Containers = new List<Container>();

        public bool IsErWaardevolleContainer()
        {
            bool status = false;
            foreach (Container container in Containers)
            {
                if (container.Type == Type.Waardevol)
                {
                    status = true; // RETURN TRUE DIRECT
                }
            }
            return status;
        }
        public int HoeveelContainers() // NAAMGEVING
        {
            return Containers.Count;
        }
        public int HoeZwaar() // NAAMGEVING
        {
            int gewicht = 0;
            foreach (Container container in Containers)
            {
                gewicht += container.Gewicht;
            }
            return gewicht;
        } // METHODE CHECK HOEVEEL GEWICHT BOVENOP CONTAINER
        public bool IsErGenoegRuimte(Container container)
        {
            return HoeZwaar() + container.Gewicht < 120; // CONSTANT MAX GEWICHT
        }
        public bool VoegContainerToe(Container container)
        {
            if (IsErWaardevolleContainer() || !IsErGenoegRuimte(container))
            {
                return false;
            }
            Containers.Add(container);
            return true;
        }
    }
}
