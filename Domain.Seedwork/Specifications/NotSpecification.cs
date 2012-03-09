﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Seedwork.Specifications
{
     public sealed class NotSpecification<TEntity>
        : Specification<TEntity> where TEntity : class
    {
        Expression<Func<TEntity, bool>> _OriginalCriteria;

        /// <summary>
        /// Constructor for NotSpecificaiton
        /// </summary>
        /// <param name="originalSpecification">Original specification</param>
        public NotSpecification(ISpecification<TEntity> originalSpecification)
        {

            if (originalSpecification == (ISpecification<TEntity>)null)
                throw new ArgumentNullException("originalSpecification");

            _OriginalCriteria = originalSpecification.SatisfiedBy();
        }

        /// <summary>
        /// Constructor for NotSpecification
        /// </summary>
        /// <param name="originalSpecification">Original specificaiton</param>
        public NotSpecification(Expression<Func<TEntity,bool>> originalSpecification)
        {
            if (originalSpecification == (Expression<Func<TEntity,bool>>)null)
                throw new ArgumentNullException("originalSpecification");

            _OriginalCriteria = originalSpecification;
        }

        /// <summary>
        /// <see cref="Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.ISpecification{TValueObject}"/>
        /// </summary>
        /// <returns><see cref="Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.ISpecification{TValueObject}"/></returns>
        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            
            return Expression.Lambda<Func<TEntity,bool>>(Expression.Not(_OriginalCriteria.Body),
                                                         _OriginalCriteria.Parameters.Single());
        }
    }
}