﻿namespace DesislavsHotDogs.Core.Model
{
    public class CartItem
    {
        public CartItem()
        {
        }

        public HotDog HotDog
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

    }
}