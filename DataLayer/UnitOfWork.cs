using System;
using System.Collections.Generic;
using SharpRepository.EfRepository;
using System.Text;
using Globals;

namespace DataLayer
{
    public class UnitOfWork
    {
        private readonly SprongContext _context;

        public EfRepository<Springer> SpringerRepository => new EfRepository<Springer>(_context);

        public EfRepository<Sprong> SprongRepository => new EfRepository<Sprong>(_context);

        public UnitOfWork(SprongContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
