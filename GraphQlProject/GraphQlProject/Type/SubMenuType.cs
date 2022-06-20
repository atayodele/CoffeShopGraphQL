using GraphQL.Types;
using GraphQlProject.Models;

namespace GraphQlProject.Type
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.ImageUrl);
            Field(p => p.Description);
            Field(p => p.Price);
            Field(p => p.MenuId);
        }
    }
}
