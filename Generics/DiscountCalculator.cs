namespace Generics
{
    public partial class Program
    {
        public class DiscountCalculator<TProduct> where TProduct : Product
        {
            public float CalculateDiscount(TProduct product)
            {
                return product.Price;
            }
        }
    }

}
