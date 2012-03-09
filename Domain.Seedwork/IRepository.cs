using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Seedwork
{
   
        public interface IRepository<TEntity> where TEntity : class
        {
            IUnitOfWork UnitOfWork { get; }
            
            /// <summary>
            /// Add item into repository
            /// </summary>
            /// <param name="item">Item to add to repository</param>
            void Add(TEntity item);

            /// <summary>
            /// Delete item 
            /// </summary>
            /// <param name="item">Item to delete</param>
            void Remove(TEntity item);

            /// <summary>
            /// Set item as modified
            /// </summary>
            /// <param name="item">Item to modify</param>
            void Modify(TEntity item);

            /// <summary>
            /// Get element by entity key
            /// </summary>
            /// <param name="entityKeyValues">entity key values, the order the are same of order in mapping.</param>
            /// <returns></returns>
            TEntity Get(int id);

            /// <summary>
            /// Get all elements of type {T} in repository
            /// </summary>
            /// <returns>List of selected elements</returns>
            IEnumerable<TEntity> GetAll();

            /// <summary>
            /// Get all elements of type {T} that matching a
            /// Specification <paramref name="specification"/>
            /// </summary>
            /// <param name="specification">Specification that result meet</param>
            /// <returns></returns>
            IEnumerable<TEntity> AllMatching(Domain.Seedwork.Specifications.ISpecification<TEntity> specification);

            /// <summary>
            /// Get  elements of type {T} in repository
            /// </summary>
            /// <param name="filter">Filter that each element do match</param>
            /// <returns>List of selected elements</returns>
            IEnumerable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter);
        }
    }
