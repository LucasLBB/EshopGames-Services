using AutoMapper;
using EShopGames.ProductAPI.Data.ValueObjects;
using EShopGames.ProductAPI.Model;

namespace EShopGames.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
