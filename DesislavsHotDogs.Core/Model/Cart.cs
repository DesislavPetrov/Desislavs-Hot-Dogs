using System.Collections.Generic;

namespace DesislavsHotDogs.Core.Model
{
    public class Cart
    {
        public Cart()
        {
        }

        public List<CartItem> CartItems
        {
            get;
            set;
        }
    }
}