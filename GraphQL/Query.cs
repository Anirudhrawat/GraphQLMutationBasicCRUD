using GraphQLMutationBasicCRUD.IService;
using GraphQLMutationBasicCRUD.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMutationBasicCRUD.GraphQL
{
    public class Query
    {
        private readonly IGroupService _groupService;
        private readonly IStudentService _studentService;

        public Query(IGroupService gropuservice, IStudentService studentService)
        {
            _groupService = gropuservice;
            _studentService = studentService;
        }

        [UsePaging(SchemaType = typeof(GroupType))]
        [UseFiltering]
        public IQueryable<Group> Groups => _groupService.GetAll();
        
        [UsePaging(SchemaType = typeof(StudentType))]
        [UseFiltering]
        public IQueryable<Student> Students => _studentService.GetAll();
    }
}
