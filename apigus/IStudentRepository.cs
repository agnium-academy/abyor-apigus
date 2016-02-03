using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apigus
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentByNoMhs(string NoMahasiswa);
        Student AddNewStudent(Student item);
        bool DeleteAStudent(string NoMahasiswa);
        bool UpdateAStudent(Student item);
        bool AssignStudent(string kelas);
    }
}
