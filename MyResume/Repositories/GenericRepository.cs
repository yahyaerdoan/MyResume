using MyResume.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyResume.Repositories
{
    public class GenericRepository<TEntity> where TEntity: class, new() 
    {
        DbResumeContext dbResumeContext = new DbResumeContext();

        public List<TEntity> TList()
        {
            return dbResumeContext.Set<TEntity>().ToList();
        }

        public void TAdd(TEntity entity)
        {
            dbResumeContext.Set<TEntity>().Add(entity);
            dbResumeContext.SaveChanges();
        }

        public void TDelete(TEntity entity)
        {
            dbResumeContext.Set<TEntity>().Remove(entity);
            dbResumeContext.SaveChanges();
        }

        public TEntity TGetById(int id)
        {
            return dbResumeContext.Set<TEntity>().Find(id);           
        }

        public void TUpdate(TEntity entity)
        {
            dbResumeContext.SaveChanges();
        }
    }
}