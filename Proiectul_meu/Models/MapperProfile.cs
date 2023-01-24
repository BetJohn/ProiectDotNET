using AutoMapper;

namespace Proiectul_meu.Models
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Tricou, TricouDTO>();
            
            /*CreateMap<Course, CourseWithStudentsDto>().ForMember(
                dest => dest.Students,
                opt => opt.MapFrom(src => src.StudentsInCourses.Select(x => x.Student))
            );
            */

        }

    }
}
