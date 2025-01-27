using Microsoft.EntityFrameworkCore;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using Netivot.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Data.Repositories
{
    public class AvrechRepository:Repository<AvrechEntity>, IAvrechRepository
    {
        public AvrechRepository(DataContext dataContext)
            : base(dataContext)
        {
           
        }
        public List<AvrechEntity> GetFull()
        {
            return _dbSet.Include(a => a.Mitchazkim).ToList();
        }
        
    }
}
