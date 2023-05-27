using System;
using itlapoli.Domian.Core;


namespace itlapoli.Domian.Entities
{
    public class Student : Person
    {
        public DateTime? EnrollmentDate { get; set; }
    }
}
