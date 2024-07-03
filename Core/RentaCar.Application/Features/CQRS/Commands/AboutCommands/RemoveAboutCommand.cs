using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Application.Features.CQRS.Commands.AboutCommands
{
    public class RemoveAboutCommand
    {
       public int Id {get; set;}

        public RemoveAboutCommand(int id)
        {
            Id = id;
        }
    }
}