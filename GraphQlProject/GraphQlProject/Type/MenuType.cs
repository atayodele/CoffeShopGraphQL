using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;

namespace GraphQlProject.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        //public MenuType()
        //{
        //    Field(p => p.Id);
        //    Field(p => p.Name);
        //    Field(p => p.ImageUrl);
        //}
        //NESTED QUERY
        public MenuType(ISubMenu subMenuService)
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.ImageUrl);
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context => { return subMenuService.GetSubMenus(context.Source.Id); });
        }
    }
}
