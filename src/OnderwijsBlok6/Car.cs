using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnderwijsBlok6
{
    public class Car
    {
        private double fuelLevel = 0;
        private int milesPerGallon;

        public Car(int milesPerGallon)
        {
            this.milesPerGallon = milesPerGallon;
        }

        public void drive(int distance)
        {
            double neededFuel = distance / this.milesPerGallon;

            if (this.fuelLevel > neededFuel)
            {
                this.fuelLevel -= neededFuel;
            }
            else
            {
                Console.WriteLine("Deze afstand kan niet met de huidige tank worden verreden. Ga eerst tanken.");
            }
        }

        public double GetFuelLevel()
        {
            return fuelLevel;
        }

        public void addGas(int volume)
        {
            this.fuelLevel += volume;
        }
    }
}
