using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Queries
{
    public class GetBannerByIdQuery
    {
        public int Id { get; set; }

        public GetBannerByIdQuery(int id)
        {
            Id = id;
        }
    }
}
