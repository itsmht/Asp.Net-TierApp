using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRepo
    {
        static TierEntities db;
        static StudentRepo()
        {
            db = new TierEntities(); 
        }
        public static List<Student>Get()
        {
            return db.Students.ToList();
        }
        public static Student Get(int id)
        {
            return db.Students.FirstOrDefault(e => e.student_id == id);

        }
        public static void Create(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();

        }
        public static void Edit(Student s)
        {
            var ds = db.Students.FirstOrDefault(e=>e.student_id==s.student_id);
            db.Entry(ds).CurrentValues.SetValues(s);
            db.SaveChanges();
        }
        public static void Delete(Student s)
        {
            var ds = db.Students.FirstOrDefault(e => e.student_id == s.student_id);
            db.Students.Remove(ds);
            db.SaveChanges();


        }

    }
}
