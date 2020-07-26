using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activity
{
    public class List
    {
        public class Query : IRequest<List<Domain.Activity>> { }

        public class Handler : IRequestHandler<Query, List<Domain.Activity>>
        {
            private readonly DataContext _dataContext;
            public Handler(DataContext dataContext)
            {
                _dataContext = dataContext;
            }

            public async Task<List<Domain.Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                var activities = await _dataContext.Activities.ToListAsync();

                return activities;
            }
        }
    }
}