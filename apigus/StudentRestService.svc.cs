using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace apigus
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentRestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentRestService.svc or StudentRestService.svc.cs at the Solution Explorer and start debugging.
    public class StudentRestService : IStudentRestService
    {
        static IStudentRepository repo = new StudentRepository();
        public List<Student> GetStudentList()
        {
            return repo.GetAllStudents();
        }

        public Student GetStudentByNoMhs(string NoMahasiswa)
        {
            return repo.GetStudentByNoMhs(NoMahasiswa);
        }

        public string AddStudent(Student student, string NoMahasiswa)
        {
            Student newStudent = repo.AddNewStudent(student);
            return "Nomor Mahasiswa=" + newStudent.NoMahasiswa;
        }

        public bool DeleteAStudent(string NoMahasiswa)
        {
            return repo.DeleteAStudent(NoMahasiswa);
        }

        public Student GetStudentByName(string Nama)
        {
            return repo.GetStudentByName(Nama);
        }

    }
}
