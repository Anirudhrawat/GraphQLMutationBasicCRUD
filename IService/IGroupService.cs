using GraphQLMutationBasicCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMutationBasicCRUD.IService
{
    public interface IGroupService
    {
        IQueryable<Group> GetAll();
    }
}
