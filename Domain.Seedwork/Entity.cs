using System;
using System.Linq;

namespace Domain.Seedwork
{
    public abstract class Entity
    {
        private Guid _id;

        /// <summary>
        /// Get or set the persisten object identifier
        /// </summary>
        public virtual Guid Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Check if this entity is transient, ie, without identity at this moment
        /// </summary>
        /// <returns>True if entity is transient, else false</returns>
        public bool IsTransient()
        {
            return this.Id == Guid.Empty;
        }

        /// <summary>
        /// Change current identity for a new non transient identity
        /// </summary>
        /// <param name="identity">the new identity</param>
        public void ChangeCurrentIdentity(Guid identity)
        {
            if (identity != Guid.Empty)
                this.Id = identity;
        }
    }
}