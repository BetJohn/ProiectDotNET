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
