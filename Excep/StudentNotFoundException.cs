using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMutationBasicCRUD.Excep
{
    public class StudentNotFoundException: Exception
    {
        public int StudentId { get; internal set; }
    }
}
