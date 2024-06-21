using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    internal class TrainStation
    {
        public string _name;
        public int passengersOff;
        public int passengersOn;
        public TrainStation(string name)
        {
            _name = name;
        }
        public int RndPassengers(int min, int max)
        {
            Random rand = new Random();
            int rnd = rand.Next(min,max);
            return rnd;
        }
        public void PassengersOn(Train train)
        {
            if (train.currentPassengers < train._seats) 
            {
                int rnd = RndPassengers(0,51);
                int newPassengers = train.currentPassengers + rnd;
                passengersOn = rnd;
                train.currentPassengers = newPassengers;
            }
        }
        public void PassengersOff(Train train)
        {
            int rnd = RndPassengers(0, train.currentPassengers + 1);
            int newPassengers = train.currentPassengers - rnd;
            passengersOff = rnd;
            train.currentPassengers = newPassengers;
        }
    }
}
