﻿using System;
using System.Linq;

namespace Domain.Seedwork.Specifications
{
    public abstract class CompositeSpecification<TEntity>
        : Specification<TEntity> where TEntity : class
    {
        /// <summary>
        /// Left side specification for this composite element
        /// </summary>
        public abstract ISpecification<TEntity> LeftSideSpecification { get; }

        /// <summary>
        /// Right side specification for this composite element
        /// </summary>
        public abstract ISpecification<TEntity> RightSideSpecification { get; }
    }
}