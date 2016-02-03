using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace apigus
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int NoMahasiswa {get; set;}
        [DataMember]
        public string Nama { get; set; }
        [DataMember]
        public string Alamat { get; set; }
        [DataMember]
        public int Umur { get; set; }
    }

    public partial class Students
    {
        private static readonly Students _instance = new Students();

        private Students() {}

        public static Students Instance
        {
            get { return _instance; }
        }

        public List<Student> StudentList
        {
            get { return students; }
        }

        private List<Student> students = new List<Student>()
        {
            new Student() {NoMahasiswa=1, Nama="agus",Alamat="Bogor", Umur=18}
        };
    }
}