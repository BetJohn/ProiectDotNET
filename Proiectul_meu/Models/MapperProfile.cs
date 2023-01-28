using AutoMapper;
using Proiectul_meu.Models.DTO;

namespace Proiectul_meu.Models
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Tricou, TricouDTO>();
            CreateMap<TricouDTO, Tricou>();
            
            CreateMap<Pantaloni, PantaloniDTO>();
            CreateMap<PantaloniDTO, Pantaloni>();

            CreateMap<Sosete, SoseteDTO>();
            CreateMap<SoseteDTO, Sosete>();

            CreateMap<Trening, TreningDTO>();
            CreateMap<TreningDTO, Trening>();

            CreateMap<TricouLaTrening, TricouLaTreningDTO>();
            CreateMap<TricouLaTreningDTO, TricouLaTrening>();

            CreateMap<Bluza, BluzaDTO>();
            CreateMap<BluzaDTO, Bluza>();
            /*CreateMap<Course, CourseWithStudentsDto>().ForMember(
                dest => dest.Students,
                opt => opt.MapFrom(src => src.StudentsInCourses.Select(x => x.Student))
            );
            */

        }

    }
}
