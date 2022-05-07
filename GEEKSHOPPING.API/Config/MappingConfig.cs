using AutoMapper;
using GEEKSHOPPING.API.Data.VO;
using GEEKSHOPPING.API.Model;

namespace GEEKSHOPPING.API.Config
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
