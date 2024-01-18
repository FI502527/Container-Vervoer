using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer_Tim.Model
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
        public int HoeZwaarSchip()
        {
            int gewicht = 0;
            foreach(Rij rij in Rijen)
            {
                int gewichtRij = rij.HoeZwaar();
                gewicht = gewicht + gewichtRij;
            }
            return gewicht;
        }
        public bool VoegContainerToe(List<Containers> containers)
        {
            int gewichtContainers = containers.Sum(container => container.Gewicht);
            if (gewichtContainers + HoeZwaarSchip() < MaxGewicht / 2 || gewichtContainers + HoeZwaarSchip() > MaxGewicht)
            {
                MessageBox.Show("Gewicht te zwaar of te licht.", "Er is iets mis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            foreach(Containers container in containers)
            {
                LegContainer(container);
            }
            return true;
        }
        public bool LegContainer(Containers container)
        {
            if (Rijen.Count % 2 != 0)
            {
                if (Rijen[Rijen.Count / 2].VoegContainerToe(container))
                {
                    return true;
                }
            }
            return LegOpPlaats(container);
        }
        public bool LegOpPlaats(Containers container)
        {
            return (LinkseRij().Sum(row => row.HoeZwaar()) <= RechtseRij().Sum(row => row.HoeZwaar())
                ? LinksPlaatsen(container)
                : RechtsPlaatsen(container));
        }
        public List<Rij> LinkseRij()
        {
            List<Rij> linkseRij = Rijen.GetRange(0, Rijen.Count / 2);
            linkseRij.Reverse();
            return linkseRij;
        }
        public List<Rij> RechtseRij()
        {
            return Rijen.GetRange(Rijen.Count % 2 == 0 ? Rijen.Count / 2 : Rijen.Count / 2 + 1, Rijen.Count / 2);
        }
        public bool LinksPlaatsen(Containers container)
        {
            foreach(Rij rij in LinkseRij())
            {
                if (rij.VoegContainerToe(container))
                {
                    return true;
                }
            }
            return false;
        }
        public bool RechtsPlaatsen(Containers container)
        {
            foreach (Rij rij in RechtseRij())
            {
                if (rij.VoegContainerToe(container))
                {
                    return true;
                }
            }
            return false;
        }
        public int LinkseGewicht()
        {
            int linkseGewicht = 0;
            foreach(Rij rij in LinkseRij())
            {
                int gewicht = rij.HoeZwaar();
                linkseGewicht = linkseGewicht + gewicht;
            }
            return linkseGewicht;
        }
        public int RechtseGewicht()
        {
            int rechtseGewicht = 0;
            foreach (Rij rij in RechtseRij())
            {
                int gewicht = rij.HoeZwaar();
                rechtseGewicht = rechtseGewicht + gewicht;
            }
            return rechtseGewicht;
        }
        public bool IsErBalans()
        {
            if (Math.Abs(RechtseGewicht() - LinkseGewicht()) <= 0.2 * HoeZwaarSchip())
            {
                return true;
            }
            return false;
        }
    }
}
