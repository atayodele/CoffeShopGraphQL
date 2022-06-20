using GraphQL.Types;
using GraphQlProject.Models;

namespace GraphQlProject.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Email);
            Field(p => p.Phone);
            Field(p => p.TotalPeople);
            Field(p => p.Date);
            Field(p => p.Time);
        }
    }
}
