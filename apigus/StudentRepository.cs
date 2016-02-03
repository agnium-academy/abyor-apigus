using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apigus
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> students = new List<Student>();
        private int counter = 1;

        public StudentRepository()
        {

            AddNewStudent(new Student { Nama = "Agus", Alamat = "Bogor", Umur = 17 });
            AddNewStudent(new Student { Nama = "Haidar", Alamat = "Depok", Umur = 30 });
            AddNewStudent(new Student { Nama = "Ucuk", Alamat = "Bogor", Umur = 32 });
            AddNewStudent(new Student { Nama = "Trio", Alamat = "Bogor", Umur = 28 });
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudentByNoMhs(string NoMahasiswa)
        {
            return students.Find(b => b.NoMahasiswa == int.Parse(NoMahasiswa));
        }

        public Student GetStudentByName(string Nama)
        {
            return students.Find(b => b.Nama.Contains(Nama));
        }

        public Student AddNewStudent(Student newStudent)
        {
            if (newStudent == null)
                throw new ArgumentNullException("newStudent");
            newStudent.NoMahasiswa = counter++;
            students.Add(newStudent);
            return newStudent;
        }

        public bool DeleteAStudent(string NoMahasiswa)
        {
            int idx = students.FindIndex(b => b.NoMahasiswa == int.Parse(NoMahasiswa));
            if (idx == -1)
                return false;
            students.RemoveAll(b => b.NoMahasiswa == int.Parse(NoMahasiswa));
            return true;
        }

        public bool UpdateAStudent(Student updatedStudent)
        {
            if (updatedStudent == null)
                throw new ArgumentNullException("updatedStudent");
            int idx = students.FindIndex(b => b.NoMahasiswa == updatedStudent.NoMahasiswa);
            if (idx == -1)
                return false;
            students.RemoveAt(idx);
            students.Add(updatedStudent);
            return true;
        }
    }

 
}