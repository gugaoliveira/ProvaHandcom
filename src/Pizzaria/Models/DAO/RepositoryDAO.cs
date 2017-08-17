using System;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using NHibernate.Transform;
using Pizzaria.Models.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Pizzaria.Models.Enum;

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
                try
                {
                    return session.Get<T>(id);
                }
                catch (HibernateException hex)
                {
                    throw hex;
                }
                finally
                {
                    session.Close();
                }
            }
        }   


        /// <summary>
        /// Criar um objeto
        /// </summary>
        public void Create(T modelo)
        {
            using (ISession session = NHibernateConfig.OpenSession())
            {
                try
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(modelo);
                        transaction.Commit();
                    }
                }
                catch (HibernateException hex)
                {
                    throw hex;
                }
                finally
                {
                    session.Close();
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
                try
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Update(modelo);
                        transaction.Commit();
                    }
                }
                catch (HibernateException hex)
                {
                    throw hex;
                }
                finally
                {
                    session.Close();
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
                try
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(modelo);
                        transaction.Commit();
                    }
                }
                catch (HibernateException hex)
                {
                    throw hex;
                }
                finally
                {
                    session.Close();
                }
            }
        }

		/// <summary>
		/// Listar objetos que satisfaçam a condição
		/// </summary>
		public List<T> ListWhere(Expression<Func<T, bool>> where)
		{
			using (ISession session = NHibernateConfig.OpenSession())
			{
				try
				{
					var query = session.Query<T>().Where(where);
					return query.ToList();
				}
				catch (HibernateException hex)
				{
					throw hex;
				}
			}
		}

        /// <summary>
        /// Listar tudo
        ///  <param name="param">Parametro para ordenação</param>
        ///  <param name="order">Ordem, Asc ou Desc que o parametro será ordenado</param>
        ///  </summary>
        public ICollection<T> ListAll(Expression<Func<T, object>> param = null, Ordem order = Ordem.Asc)
        {
            using (ISession session = NHibernateConfig.OpenSession())
            {
                try
                {
                    var query = QueryOver.Of<T>();

                    if (param != null)
                    {
                        if(order == Ordem.Desc)
                        {
                            query = query.OrderBy(param).Desc();
                        }
                        else
                        {
                            query = query.OrderBy(param).Asc();
                        }
                    }                                                     

                    return query.GetExecutableQueryOver(session).List();
                }
                catch (HibernateException hex)
                {
                    throw hex;
                }               
            }
        }

        /// <summary>
        /// Listar objetos que satisfaçam a condição e seus relacionamentos
        /// <param name="where">Condição</param>
        /// <param name="eagerParams">Relacionamentos que precisam ser inicializados</param>
        /// </summary>
        public T ListOneWhere(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] eagerParams)
        {
            using (ISession session = NHibernateConfig.OpenSession())
            {
                try
                {
                    var query = session.QueryOver<T>().Where(where).TransformUsing(Transformers.DistinctRootEntity);

                    if (eagerParams != null && eagerParams.Length > 0)
                    {
                        foreach (var item in eagerParams)
                            query = query.Fetch(item).Eager;                        
                    }                                     

                    return query.SingleOrDefault();
                }
                catch (HibernateException hex)
                {
                    throw hex;
                }
            }
        }
    }
}