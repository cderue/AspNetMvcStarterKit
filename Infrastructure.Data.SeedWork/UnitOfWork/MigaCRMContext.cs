using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Infrastructure.Data.Seedwork;

namespace MigaCRM.Data.UnitOfWork
{
    /*public class MainContext : DbContext, IQueryableUnitOfWork
    {
        private IDbSet<Domain..BaseLogique> _baseLogiqueJeu;
        public IDbSet<MigaCRM.Models.BaseLogique> BaseLogiqueJeu
        {
            get { return _baseLogiqueJeu; }
            set { _baseLogiqueJeu = value; }
        }

        private IDbSet<MigaCRM.Models.Contact> _contactJeu;
        public IDbSet<MigaCRM.Models.Contact> ContactJeu
        {
            get { return _contactJeu; }
            set { _contactJeu = value; }
        }

        private IDbSet<MigaCRM.Models.Action> _actionJeu;
        public IDbSet<MigaCRM.Models.Action> ActionJeu
        {
            get { return _actionJeu; }
            set { _actionJeu = value; }
        }

        private IDbSet<MigaCRM.Models.Produit> _produitJeu;
        public IDbSet<MigaCRM.Models.Produit> ProduitJeu
        {
            get { return _produitJeu; }
            set { _produitJeu = value; }
        }

        private IDbSet<MigaCRM.Models.Affaire> _affaireJeu;
        public IDbSet<MigaCRM.Models.Affaire> AffaireJeu
        {
            get { return _affaireJeu; }
            set { _affaireJeu = value; }
        }

        private IDbSet<MigaCRM.Models.Interlocuteur> _interlocuteurJeu;
        public IDbSet<MigaCRM.Models.Interlocuteur> InterlocuteurJeu
        {
            get { return _interlocuteurJeu; }
            set { _interlocuteurJeu = value; }
        }

        private IDbSet<MigaCRM.Models.Lien> _lienJeu;
        public IDbSet<MigaCRM.Models.Lien> LienJeu
        {
            get { return _lienJeu; }
            set { _lienJeu = value; }
        }

        private IDbSet<MigaCRM.Models.Adresse> _adresseJeu;
        public IDbSet<MigaCRM.Models.Adresse> AdresseJeu
        {
            get { return _adresseJeu; }
            set { _adresseJeu = value; }
        }

        private IDbSet<MigaCRM.Models.Autres> _autresJeu;
        public IDbSet<MigaCRM.Models.Autres> AutresJeu
        {
            get { return _autresJeu; }
            set { _autresJeu = value; }
        }

        private IDbSet<MigaCRM.Models.Classeur> _classeurJeu;
        public IDbSet<MigaCRM.Models.Classeur> ClasseurJeu
        {
            get { return _classeurJeu; }
            set { _classeurJeu = value; }
        }

        private IDbSet<MigaCRM.Models.Champ> _champJeu;
        public IDbSet<MigaCRM.Models.Champ> ChampJeu
        {
            get { return _champJeu; }
            set { _champJeu = value; }
        }

        private IDbSet<MigaCRM.Models.Offre> _offreJeu;
        public IDbSet<MigaCRM.Models.Offre> OffreJeu
        {
            get { return _offreJeu; }
            set { _offreJeu = value; }
        }

        public MigaCRMContext()
            : base("name=MigactionModelContainer")
        {
        }
        
        public System.Data.Entity.DbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public void Attach<TEntity>(TEntity item) where TEntity : class
        {
            base.Entry<TEntity>(item).State = System.Data.EntityState.Unchanged;
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : class
        {
            base.Entry<TEntity>(item).State = System.Data.EntityState.Modified;
        }

        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class
        {
            base.Entry<TEntity>(original).CurrentValues.SetValues(current);
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public void CommitAndRefreshChanges()
        {
            bool saveFailed = false;

            do
            {
                try
                {
                    base.SaveChanges();
                    saveFailed = false;

                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;
                    ex.Entries.ToList()
                              .ForEach(entry =>
                              {
                                  entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                              });

                }
            } while (saveFailed);

        }

        public void RollbackChanges()
        {
            base.ChangeTracker.Entries()
                              .ToList()
                              .ForEach(entry => entry.State = System.Data.EntityState.Unchanged);
        }

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            return base.Database.SqlQuery<TEntity>(sqlQuery, parameters);
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return base.Database.ExecuteSqlCommand(sqlCommand, parameters);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Configurations.Add(new BaseLogique_Mapping());
            modelBuilder.Configurations.Add(new Contact_Mapping());
            modelBuilder.Configurations.Add(new Action_Mapping());
            modelBuilder.Configurations.Add(new Produit_Mapping());
            modelBuilder.Configurations.Add(new Affaire_Mapping());
            modelBuilder.Configurations.Add(new Interlocuteur_Mapping());
            modelBuilder.Configurations.Add(new Lien_Mapping());
            modelBuilder.Configurations.Add(new Adresse_Mapping());
            modelBuilder.Configurations.Add(new Autres_Mapping());
            modelBuilder.Configurations.Add(new Classeur_Mapping());
            modelBuilder.Configurations.Add(new Champ_Mapping());
            modelBuilder.Configurations.Add(new Offre_Mapping());
        }
    }*/
}