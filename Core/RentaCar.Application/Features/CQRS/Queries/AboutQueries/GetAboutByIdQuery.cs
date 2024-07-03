using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Application.Features.CQRS.Queries.AboutQueries
{
    public class GetAboutByIdQuery
    {
        public int Id { get; set; }

        public GetAboutByIdQuery(int id)
        {
            Id = id;
        }
    }
}