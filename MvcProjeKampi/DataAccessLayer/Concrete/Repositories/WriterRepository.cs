﻿using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using System.Linq.Expressions;
using System.Data.Entity;

namespace DataAccessLayer.Concrete.Repositories
{
    public class WriterRepository : IWriterDal
    {
        Context c = new Context();
        DbSet<Writer> _object;

        public void Delete(Writer p)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer p)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List()
        {
            throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer p)
        {
            throw new NotImplementedException();
        }
    }
}
