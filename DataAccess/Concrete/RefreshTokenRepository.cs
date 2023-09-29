using Core.DataAccess.Repositories;
using Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class RefreshTokenRepository : EfRepositoryBase<RefreshToken, BaseDbContext>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
