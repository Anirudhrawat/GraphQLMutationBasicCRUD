using GraphQLMutationBasicCRUD.IService;
using GraphQLMutationBasicCRUD.Models;
using HotChocolate;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMutationBasicCRUD.GraphQL
{
    public class GroupType : ObjectType<Group>
    {
        protected override void Configure(IObjectTypeDescriptor<Group> descriptor)
        {
            var id = descriptor.Field(x => x.GroupId).Type<IdType>();
            descriptor.Field(x => x.GroupId).Type<IdType>();
            descriptor.Field(x => x.Name).Type<StringType>();
            descriptor.Field(x => x.ShortName).Type<StringType>();
            descriptor.Field<StudentResolver>(x => x.GetStudents(default, default));
        }
    }

    public class StudentResolver
    {
        private readonly IStudentService _studentService;

        public StudentResolver([Service] IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IEnumerable<Student> GetStudents(Group group, IResolverContext ctx)
        {
            return _studentService.GetAll().Where(x => x.GroupId == group.GroupId);
        }

    }
}
