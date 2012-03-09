using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Domain.Seedwork;
using Domain.Seedwork.Specifications;

namespace Infrastructure.Data.Seedwork.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {

        private IQueryableUnitOfWork _UnitOfWork;

        public IQueryableUnitOfWork UnitOfWork
        {
            get { return _UnitOfWork; }
        }
        
        /// <summary>
        /// Create a new instance of repository
        /// </summary>
        /// <param name="unitOfWork">Associated Unit Of Work</param>
        public GenericRepository(IQueryableUnitOfWork unitOfWork)
        {
            if (unitOfWork == (IUnitOfWork)null)
                throw new ArgumentNullException("unitOfWork");

            _UnitOfWork = unitOfWork;
        }



        public virtual void Add(TEntity item)
        {

            if (item != (TEntity)null)
                GetSet().Add(item); // add new item in this set
            else
            {
                // Log
            }

        }
        
        public virtual void Remove(TEntity item)
        {
            if (item != (TEntity)null)
            {
                //set as "removed"
                GetSet().Remove(item);
            }
            else
            {
                // Log
            }
        }

        public virtual void TrackItem(TEntity item)
        {
            
        }

        public virtual void Modify(TEntity item)
        {
            if (item != (TEntity)null)
            {
                //_UnitOfWork.SetModified(item);
            }
            else
            {
               
            }
        }

        public virtual TEntity Get(int id)
        {
            return GetSet().Find(id);
        }
        
        public virtual IEnumerable<TEntity> GetAll()
        {
            return GetSet().AsEnumerable();
        }
        
        public virtual IEnumerable<TEntity> AllMatching(ISpecification<TEntity> specification)
        {
            return GetSet().Where(specification.SatisfiedBy())
                           .AsEnumerable();
        }
       
        public virtual IEnumerable<TEntity> GetPaged<KProperty>(int pageIndex, int pageCount, System.Linq.Expressions.Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending)
        {
            var set = GetSet();

            if (ascending)
            {
                return set.OrderBy(orderByExpression)
                          .Skip(pageCount * pageIndex)
                          .Take(pageCount)
                          .AsEnumerable();
            }
            else
            {
                return set.OrderByDescending(orderByExpression)
                          .Skip(pageCount * pageIndex)
                          .Take(pageCount)
                          .AsEnumerable();
            }
        }
        
        public virtual IEnumerable<TEntity> GetFiltered(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return GetSet().Where(filter)
                           .AsEnumerable();
        }

        public virtual void Merge(TEntity persisted, TEntity current)
        {
            _UnitOfWork.ApplyCurrentValues(persisted, current);
        }

        private DbSet<TEntity> GetSet()
        {
            return _UnitOfWork.CreateSet<TEntity>();
        }
    }
}
        