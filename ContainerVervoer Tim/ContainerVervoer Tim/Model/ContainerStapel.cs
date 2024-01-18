using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer_Tim.Model
{
    public class ContainerStapel
    {
        public List<Containers> Containers = new List<Containers>();
        public override string ToString()
        {
            string bericht = "Stapel: ";
            if(Containers.Count > 0)
            {
                foreach(Containers container in Containers)
                {
                    bericht += "\n" + container.ToString();
                    return bericht;
                }
            }
            return "Er zit niks in de stapel.";
        }

        public bool IsContainerWaardevol()
        {
            bool status = false;
            foreach (Containers container in Containers)
            {
                if(container.Type == Type.Waardevol) status = true;
            }
            return status;
        }
        public int HoeveelContainers()
        {
            int aantal = Containers.Count;
            return aantal;
        }
        public int HoeZwaar()
        {
            int gewicht = 0;
            foreach(Containers container in Containers)
            {
                gewicht = gewicht + container.Gewicht;
            }
            return gewicht;
        }
        public bool IsErGenoegRuimte(Containers container)
        {
            bool status = false;
            int gewicht = HoeZwaar();
            if(gewicht + container.Gewicht < 120)
            {
                status = true;
            }
            return status;
        }
        public bool VoegContainerToe(Containers container)
        {
            if(IsContainerWaardevol() == true || IsErGenoegRuimte(container) == false)
            {
                return false;
            }
            Containers.Add(container);
            return true;
        }
    }
}
