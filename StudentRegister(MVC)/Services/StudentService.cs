using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentRegister_MVC_.Dtoes;
using StudentRegister_MVC_.Interfaces;
using StudentRegister_MVC_.Models.Domains;
using StudentRegister_MVC_.Models.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegister_MVC_.Services
{
    public class StudentService : IStudent
    {
        SchoolDbContext sdb;
        IMapper _mapper;

        public StudentService(IMapper mapper)
        {
            _mapper = mapper;
            sdb = new();
        }


        public List<Student> Get()
        {
            try
            {
                var data = sdb.Students.ToList();
                return data;
            }
            catch (Exception ex)
            {
                var lod = ex.Message;
                return null;
            }
        }

        public Student Post(StudentDto studentDto)
        {
            try
            {
                Student data = _mapper.Map<Student>(studentDto);
                Student check_Data = sdb.Students.FirstOrDefault(s => s.Name == studentDto.Name && s.Course == studentDto.Course && s.Age == studentDto.Age);
                if (check_Data == null)
                {
                    sdb.Students.Add(data);
                    sdb.SaveChanges();
                    return data;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                var lod = ex.Message;
                return null;
            }
        }

        public Student Put(StudentDto studentDto, int id)
        {
            try
            {
                var data = sdb.Students.FirstOrDefault(s => s.Id == id);
                Student new_data = _mapper.Map<Student>(studentDto);
                if (data != null)
                {
                    sdb.Students.Remove(data);
                }
                sdb.Students.Add(new_data);
                sdb.SaveChanges();
                return data;
            }
            catch (Exception ex)
            {
                var lod = ex.Message;
                return null;
            }
        }
        public string Delete(int id)
        {
            try
            {
                var data = sdb.Students.FirstOrDefault(s => s.Id == id);
                if (data != null)
                {
                    sdb.Students.Remove(data);
                }
                var check_data = sdb.Students.FirstOrDefault(s => s.Id == id);
                if (check_data == null) return "Succesful";
                else return "Failed";
            }
            catch (Exception ex)
            {
                var lod = ex.Message;
                return null;
            }
        }
    }
}
