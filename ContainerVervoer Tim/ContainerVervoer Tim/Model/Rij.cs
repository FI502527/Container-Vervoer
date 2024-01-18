using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer_Tim.Model
{
    public class Rij
    {
        public List<ContainerStapel> Stapel = new List<ContainerStapel>();
        public Rij(int lengte)
        {
            MaakStapel(lengte);
        }
        public void MaakStapel(int lengte)
        {
            for(int i = 0; i < lengte; i++)
            {
                Stapel.Add(new ContainerStapel());
            }
        }
        public bool VoegContainerToe(Containers container)
        {
            switch (container.Type)
            {
                case Type.Waardevol:
                    return VoegWaardevolToe(container);
                case Type.Gekoeld:
                    return VoegGekoeldToe(container);
                case Type.Normaal:
                    return VoegNormaalToe(container);
            }
            return false;
        }
        public bool VoegWaardevolToe(Containers container)
        {
            for (int nummer = 0; nummer < Stapel.Count; nummer++)
            {
                if (nummer % 2 == 0)
                {
                    if (Stapel[nummer].VoegContainerToe(container))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool VoegGekoeldToe(Containers container) 
        {
            ContainerStapel eersteRij = Stapel.First();
            eersteRij.VoegContainerToe(container);
            return true;
        }
        public bool VoegNormaalToe(Containers container)
        {
            foreach (ContainerStapel stapel in Stapel.Skip(1))
            {
                if(stapel.VoegContainerToe(container) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public int HoeZwaar()
        {
            int gewicht = 0;
            foreach(ContainerStapel stapel in Stapel)
            {
                int huidigeGewicht = stapel.HoeZwaar();
                gewicht = gewicht + huidigeGewicht;
            }
            return gewicht;
        }
    }
}
