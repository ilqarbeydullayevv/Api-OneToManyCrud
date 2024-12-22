using ApiCrud.apı.DTOs.Categories;
using ApiCrud.apı.DTOs.Products;
using ApiCrud.Core.Entities;
using AutoMapper;

namespace ApiCrud.apı.Mapper
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<CreateCategoryDTo, Category>();
            CreateMap<UpdateCategoryDTo, Category>();

            CreateMap<CreateProductDTo, Product>();

            CreateMap<UpdateProductDTo, Product>();

        }
    }
}
