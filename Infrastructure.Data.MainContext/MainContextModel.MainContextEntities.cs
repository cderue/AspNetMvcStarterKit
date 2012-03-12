//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 3/12/2012 4:06:35 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MainContextModel
{
    public partial class MainContextEntities : DbContext
    {
        #region Constructors

        /// <summary>
        /// Initialize a new MainContextEntities object.
        /// </summary>
        public MainContextEntities() :
                base(@"name=MainContextEntitiesConnectionString")
        {
            Configure();
        }

        /// <summary>
        /// Initializes a new MainContextEntities object using the connection string found in the 'MainContextEntities' section of the application configuration file.
        /// </summary>
        public MainContextEntities(string connectionString) :
                base(connectionString)
        {
            Configure();
        }

        private void Configure()
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.ValidateOnSaveEnabled = true;
        }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            throw new UnintentionalCodeFirstException();
        }

    
        /// <summary>
        /// There are no comments for Contact in the schema.
        /// </summary>
        public DbSet<Contact> Contacts { get; set; }
    }
}
