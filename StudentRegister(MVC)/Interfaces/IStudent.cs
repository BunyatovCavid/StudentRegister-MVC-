using StudentRegister_MVC_.Dtoes;
using StudentRegister_MVC_.Models.Domains.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentRegister_MVC_.Interfaces
{
    public interface IStudent
    {
       public List<Student> Get();
       public Student Post(StudentDto studentDto);
       public Student Put(StudentDto studentDto, int id);
       public string Delete(int id);

    }
}
