using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    internal class Game
    {
        private List<TrainStation> stations;
        public Game() 
        {
            
            stations = new List<TrainStation>()
            {
                new TrainStation("Oslo S"),
                new TrainStation("Nasjonaltheateret"),
                new TrainStation("Skøyen"),
                new TrainStation("Lysaker"),
                new TrainStation("Sandvika"),
                new TrainStation("Asker"),
                new TrainStation("Drammen"),
            };
        }
        public void RunTrain(Train train)
        {
            for (int i = 0; i < stations.Count; i++) 
            {
                Console.WriteLine($"The train is entering {stations[i]._name}");
                stations[i].PassengersOff(train);
                Console.WriteLine($"{stations[i].passengersOff} passengers got off the train");
                stations[i].PassengersOn(train);
                Console.WriteLine($"{stations[i].passengersOn} passengers got on the train");
                Console.WriteLine($"Train is leaving {stations[i]._name} with {train.currentPassengers} passengers");

            }
        }
    }
}
