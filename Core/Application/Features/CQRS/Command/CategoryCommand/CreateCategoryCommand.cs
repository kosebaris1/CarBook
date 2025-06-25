using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Command.CategoryCommand
{
    public class CreateCategoryCommand
    {
        public string Name { get; set; }
    }
}
