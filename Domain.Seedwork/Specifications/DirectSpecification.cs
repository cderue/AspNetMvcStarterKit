using System;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Seedwork.Specifications
{
    public sealed class DirectSpecification<TEntity>
        : Specification<TEntity>
        where TEntity : class
    {
        Expression<Func<TEntity, bool>> _MatchingCriteria;

        /// <summary>
        /// Default constructor for Direct Specification
        /// </summary>
        /// <param name="matchingCriteria">A Matching Criteria</param>
        public DirectSpecification(Expression<Func<TEntity, bool>> matchingCriteria)
        {
            if (matchingCriteria == (Expression<Func<TEntity, bool>>)null)
                throw new ArgumentNullException("matchingCriteria");

            _MatchingCriteria = matchingCriteria;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            return _MatchingCriteria;
        }
    }
}