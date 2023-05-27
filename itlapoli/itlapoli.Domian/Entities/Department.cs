using System;
using itlapoli.Domian.Core;


namespace itlapoli.Domian.Entities
{
    public class Department : BaseEntity
    {
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }
    }
}
