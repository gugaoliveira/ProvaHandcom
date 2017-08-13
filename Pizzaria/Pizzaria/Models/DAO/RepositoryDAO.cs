using NHibernate;
using Pizzaria.Models.Entity;

namespace Pizzaria.Models.DAO
{
    /// <summary>
    /// Acesso ao banco de dados
    /// </summary>
    public class RepositoryDAO<T> where T : BaseEntity
    {
        /// <summary>
        /// Listar um objeto
        /// </summary>
        public T Get(int id)
		{
			using (ISession session = NHibernateConfig.OpenSession())
			{
				return session.Get<T>(id);
			}
		}

        /// <summary>
        /// Criar um objeto
        /// </summary>
        public void Create(T modelo)
        {
            using (ISession session = NHibernateConfig.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
					session.Save(modelo);
                    transaction.Commit();
                }
            }            
        }

        /// <summary>
        /// Atualizar um objeto
        /// </summary>

        public void Update(T modelo)
        {
            using (ISession session = NHibernateConfig.OpenSession())
            {
				using (ITransaction transaction = session.BeginTransaction())
				{
					session.Update(modelo);
					transaction.Commit();
				}
			}
        }

        /// <summary>
        /// Deletar um objeto
        /// </summary>
        public void Delete(T modelo)
        {
            using (ISession session = NHibernateConfig.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(modelo);
                    transaction.Commit();
                }
            }
        }
    }
}