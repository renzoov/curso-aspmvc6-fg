using AutoMapper;
using TareasMVC.Entidades;
using TareasMVC.Models;

namespace TareasMVC.Servicios
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Tarea, TareaDTO>();
        }
    }
}
