using Microsoft.AspNetCore.Mvc;
using StudentRegister_MVC_.Dtoes;
using StudentRegister_MVC_.Interfaces;

namespace StudentRegister_MVC_.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IStudent _student;
        public RegisterController(IStudent student)
        {
           _student = student;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Get()
        {
            var data =  _student.Get();
            return View(data);
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post(StudentDto studentDto)
        {
            _student.Post(studentDto);
            return View();
        }
        public IActionResult Put()
        {
            return View();
        }
        [HttpPut]
        public IActionResult Put(StudentDto studentDto,int id)
        {
            _student.Put(studentDto, id);
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _student.Delete(id);
            return View();
        }
    }
}
