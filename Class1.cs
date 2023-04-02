using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8
{
    public class Trip
    {
        private string destination;
        private double distanceTraveld;
        private decimal fuelCost;
        private double gallonsConsumed;

        public Trip(string dest, double distance, decimal cost, double gallons)
        {
            Destination = dest;
            DistanceTraveld = distance;
            FuelCost = cost;
            GallonsConsumed = gallons;
        }


        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }
        public double DistanceTraveld
        {
            get
            {
                return distanceTraveld;
            }
            set
            {
                distanceTraveld = value;
            }

        }
        public decimal FuelCost
        {
            get
            {
                return fuelCost;
            }
            set
            {
                fuelCost = value;
            }
        }
        public double GallonsConsumed
        {
            get
            {
                return gallonsConsumed;
            }
            set
            {
                gallonsConsumed = value;
            }
        }
        public double MilesPerGallon()
        {
            return DistanceTraveld / GallonsConsumed;
        }
        public decimal CostPerMile()
        {
            return FuelCost / Convert.ToDecimal(DistanceTraveld);
        }
        public override string ToString()
        {
            return "Destination: " + Destination + "\nTotal Miles: " + DistanceTraveld + "\nFuel Consumed: " + GallonsConsumed.ToString("f1") + " gallons" + "\nCost: " + MilesPerGallon().ToString("f0") + "\nCost Per Mile: " + CostPerMile().ToString("c");







        }
    }
}
