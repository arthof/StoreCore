﻿using System;
using System.Collections.Generic;
using System.Text;
using StoreCore.DataMapper;

namespace StoreCore.Entity
{
    class CartProduct: AEntity
    {
        protected int cart_id = 0;
        protected Cart cart = null;
        protected int product_id = 0;
        protected Product product = null;
        protected int qty = 0;
        
        public CartProduct()
        {

        }

        public CartProduct(int cart_id, int product_id, int qty)
        {
            CartId = cart_id;
            ProductId = product_id;
            Qty = qty;
        }

        public int CartId
        {
            get
            {
                return cart_id;
            }
            set
            {
                cart_id = value;
            }
        }

        public int ProductId
        {
            get
            {
                return product_id;
            }
            set
            {
                product_id = value;
            }
        }

        public int Qty
        {
            get
            {
                return qty;
            }
            set
            {
                qty = value;
            }
        }

        public Cart Cart
        {
            get
            {
                return cart;
            }
            set
            {
                cart = value;
            }
        }

        public Product Product
        {
            get
            {
                if (product == null)
                    product = ProductDM.FindById(ProductId);
                return product;
            }
            set
            {
                product = value;
            }
        }
    }
}