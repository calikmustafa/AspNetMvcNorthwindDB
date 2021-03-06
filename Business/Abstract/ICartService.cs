using Entities.Concrete;
using Entities.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveToCart(Cart cart, int productId);
        List<CartLine> CartLines(Cart cart);
        
    }
}
