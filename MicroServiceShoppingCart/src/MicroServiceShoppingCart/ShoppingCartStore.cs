using System;

namespace MicroServiceShoppingCart
{
    public class ShoppingCart
    {
        public void AddItems(int[] shoppingCartItems, IEventStore eventStore)
        {

        }

        public void RemoveItems(int[] shoppingCartItems, IEventStore eventStore)
        {

        }
    }

    public interface IShoppingCartStore
    {
        ShoppingCart Get(int userId);
        void Save(ShoppingCart shoppingCart);
    }

    public class ShoppingCartStore : IShoppingCartStore
    {
        public ShoppingCart Get(int userId)
        {
            return new ShoppingCart();
        }

        public void Save(ShoppingCart shoppingCart)
        {
        }
    }
}
