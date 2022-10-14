using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class StudentService
    {
        public static List<StudentModel>Get()
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<Student, StudentModel>();
                });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<StudentModel>>(StudentRepo.Get());
            return data;
        }
        public static void Create(StudentModel s)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<StudentModel, Student>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Student>(s);
            StudentRepo.Create(data);
        }
        public static StudentModel Get(int id)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<Student, StudentModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<StudentModel>(StudentRepo.Get(id));
            return data;

        }
        public static void Edit(StudentModel s)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<StudentModel, Student>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Student>(s);
            StudentRepo.Edit(data);
        }
        public static void Delete(StudentModel s)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<StudentModel, Student>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Student>(s);
            StudentRepo.Delete(data);
        }

    }
    
}
