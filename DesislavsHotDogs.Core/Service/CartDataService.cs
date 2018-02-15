using DesislavsHotDogs.Core.Model;
using DesislavsHotDogs.Core.Repository;

namespace DesislavsHotDogs.Core.Service
{
    public class CartDataService
    {
        private static CartRepository cartRepository = new CartRepository();

        public CartDataService()
        {
        }

        public void AddCartItem(HotDog hotDog, int amount)
        {
            cartRepository.AddCartItem(hotDog, amount);
        }

        public Cart GetCart()
        {
            return cartRepository.GetCart();
        }

    }
}
