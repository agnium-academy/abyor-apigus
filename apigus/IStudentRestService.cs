using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace apigus
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentRestService" in both code and config file together.
    [ServiceContract]
    public interface IStudentRestService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
                                   BodyStyle = WebMessageBodyStyle.Bare,
                                   UriTemplate = "Students/")]
        List<Student> GetStudentList();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json, UriTemplate = "StudentNoMhs/{NoMahasiswa}")]
        Student GetStudentByNoMhs(string NoMahasiswa);

        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json, UriTemplate = "AddStudent/{NoMahasiswa}")]
        string AddStudent(Student student, string NoMahasiswa);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "StudentNama/{Nama}")]
        Student GetStudentByName(string Nama);
    }

}
