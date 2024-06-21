using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Train
    {
        private List<TrainCart> cart;
        public int _seats {  get; set; }
        public int currentPassengers { get; set; }
        public Train()
        {
            cart = new List<TrainCart>() 
            { 
                new TrainCart(1),
                new TrainCart(2),
                new TrainCart(3),
                new TrainCart(4),
                new TrainCart(5),
            };
            _seats = CalculateSeats();
        }
        public int CalculateSeats() 
        {
            int finalSeatCount = cart[0].seats + cart[1].seats + cart[2].seats + cart[3].seats + cart[4].seats;
            return finalSeatCount;
        }

    }
}
