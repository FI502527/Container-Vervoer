using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer_Tim.Model
{
    public class ContainersPlaatsen
    {
        public List<Containers> containersPlaatsen = new List<Containers>();
        public Schip schip;
        public ContainersPlaatsen(int lengte, int breedte, int maxGewicht)
        {
            schip = new Schip(maxGewicht, breedte, lengte);
        }
        public bool SorteerContainers()
        {
            return schip.VoegContainerToe(SorteerLijst(containersPlaatsen));
        }
        public List<Containers> SorteerLijst(List<Containers> containers)
        {
            return containers.Where(container => container.Type == Type.Gekoeld).ToList()
                .Concat(containers.Where(container => container.Type == Type.Normaal).ToList())
                .Concat(containers.Where(container => container.Type == Type.Waardevol).ToList())
                .ToList();
        }
    }
}
