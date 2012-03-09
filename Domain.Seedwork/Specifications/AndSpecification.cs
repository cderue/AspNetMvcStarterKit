using System;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Seedwork.Specifications
{
    public sealed class AndSpecification<TEntity>
       : CompositeSpecification<TEntity> where TEntity : class
    {
        private ISpecification<TEntity> _RightSideSpecification = null;
        private ISpecification<TEntity> _LeftSideSpecification = null;

        public AndSpecification(ISpecification<TEntity> leftSide, ISpecification<TEntity> rightSide)
        {
            if (leftSide == (ISpecification<TEntity>)null)
                throw new ArgumentNullException("leftSide");

            if (rightSide == (ISpecification<TEntity>)null)
                throw new ArgumentNullException("rightSide");

            this._LeftSideSpecification = leftSide;
            this._RightSideSpecification = rightSide;
        }

        public override ISpecification<TEntity> LeftSideSpecification
        {
            get { return _LeftSideSpecification; }
        }

        public override ISpecification<TEntity> RightSideSpecification
        {
            get { return _RightSideSpecification; }
        }

        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            //Expression<Func<TEntity, bool>> left = _LeftSideSpecification.SatisfiedBy();
            //Expression<Func<TEntity, bool>> right = _RightSideSpecification.SatisfiedBy();



            bool result = true;

            Expression<Func<TEntity, bool>> trueExpression = t => result;
            return trueExpression;
        }
    }
}