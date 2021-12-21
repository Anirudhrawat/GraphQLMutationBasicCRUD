using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMutationBasicCRUD.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
    }
}
