

using AutoMapper;
using Entity;
using Graduation_Project.ViewModels;

namespace DataAccess.Mappings
{
    public class ViewModelMapping:Profile
    {
        public ViewModelMapping()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
        
    }
}
