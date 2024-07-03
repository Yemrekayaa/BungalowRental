using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Application.Features.CQRS.Results.BrandResults
{
    public class GetBrandQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}