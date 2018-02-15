using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using DesislavsHotDogs.Core.Service;
using DesislavsHotDogs.Core.Model;
using DesislavsHotDogs.Adapters;

namespace DesislavsHotDogs
{
    [Activity(Label = "Welcome to Desislav's Hot Dogs", Icon = "@drawable/smallicon")]
    public class CartActivity : Activity
    {
        private CartDataService cartDataService;
        private List<CartItem> cartItems;
        private ListView cartListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CartView);

            cartDataService = new CartDataService();

            cartListView = FindViewById<ListView>(Resource.Id.cartListView);

            cartItems = cartDataService.GetCart().CartItems;
            cartListView.Adapter = new CartAdapter(this, cartItems);
        }
    }
}