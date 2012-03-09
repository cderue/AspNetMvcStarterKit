using System;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Seedwork.Specifications
{
    public sealed class TrueSpecification<TEntity>
        : Specification<TEntity> where TEntity : class
    {
        /// <summary>
        /// <see cref=" Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification{TValueObject}"/>
        /// </summary>
        /// <returns><see cref=" Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification{TValueObject}"/></returns>
        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            bool result = true;

            Expression<Func<TEntity, bool>> trueExpression = t => result;
            return trueExpression;
        }
    }
}