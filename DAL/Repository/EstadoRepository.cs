using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class EstadoRepository : Repository<Estado>, IEstadoRepository
    {
        public EstadoRepository(DbContext context) : base(context)
        {
        }



        public EstoqueContext TravelAgencyContext
        {
            get { return Context as EstoqueContext; }
        }
    }
}
