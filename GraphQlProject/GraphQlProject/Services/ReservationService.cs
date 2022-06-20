using GraphQlProject.Data;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQlProject.Services
{
    public class ReservationService : IReservation
    {
        private readonly GraphQLDbContext _dbContext;
        public ReservationService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Reservation AddServation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return _dbContext.Reservations.ToList();
        }
    }
}
