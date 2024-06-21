using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    internal class TrainCart
    {
        public int cartID;
        public int seats;
        public TrainCart(int cartId)
        {
            cartID = cartId;
            seats = 25;
        }
    }
}
