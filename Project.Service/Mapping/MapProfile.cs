using AutoMapper;
using Project.Core.DTOs;
using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile() { 
        
        CreateMap<Product,ProductDto>().ReverseMap();
        CreateMap<Category,CategoryDto>().ReverseMap();
        CreateMap<ProductFeature,ProductFeatureDto>().ReverseMap();
        CreateMap<ProductUpdateDto, Product>();
        CreateMap<Product, ProductWithCategoryDto>();
        CreateMap<Category, CategoryWithProductsDto>();

        }
    }
}
