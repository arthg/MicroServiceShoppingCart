using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroServiceShoppingCart
{
    public interface IProductCatalogClient
    {
        Task<int[]> GetShoppingCartItems(int[] shoppingCartItems);
    }

    public class ProductCatalogClient : IProductCatalogClient
    {
        public async Task<int[]> GetShoppingCartItems(int[] shoppingCartItems)
        {
            return Enumerable.Empty<int>().ToArray();
        }

        private static async Task<HttpResponseMessage> RequestProductFromProductCatalogue(int[] productCatalogueIds)
        {
            var getProductPathTemplate = "/products?productIds=[{0}]";
            var productsResource = string.Format(getProductPathTemplate, string.Join(",", productCatalogueIds));
            using (var httpClient = new HttpClient())
            {
                var productCatalogBaseUrl = @"http://private-05cc8-chapter2productcatalogmicroservice.apiary-mock.com";
                httpClient.BaseAddress = new Uri(productCatalogBaseUrl);
                return await
                httpClient.GetAsync(productsResource).ConfigureAwait(false);
            }
        }
    }
}
