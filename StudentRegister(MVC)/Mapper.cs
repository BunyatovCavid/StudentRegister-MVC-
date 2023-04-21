using AutoMapper;
using StudentRegister_MVC_.Dtoes;
using StudentRegister_MVC_.Models.Domains.Entities;

namespace StudentRegister_MVC_
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<StudentDto, Student>();
        }
    }
}
