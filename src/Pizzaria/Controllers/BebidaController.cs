using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;
using Pizzaria.Models.Enum;

namespace Pizzaria.Controllers
{
    public class BebidaController : Controller
    {
        private RepositoryDAO<Bebida> bebidaDAO = new RepositoryDAO<Bebida>();

        /// <summary>
        /// Página com todas as bebidas
        /// </summary>
        public ActionResult Lista()
        {          
            var bebida = bebidaDAO.ListAll(c => c.Nome, Ordem.Asc);
            return View(bebida);
        }

        /// <summary>
        /// Cadastro da bebida
        /// </summary>
        public ActionResult Cadastro(int id = -1)
        {
            var bebida = new Bebida();

            //Edição
            if (id > 0)
            {
                bebida = bebidaDAO.ListOneWhere(c => c.Id == id);              
            }  

            return View(bebida);
        }

        /// <summary>
        /// Salvar uma bebida
        /// </summary>
        public ActionResult Salvar(Bebida bebida)
        {            
            if (bebida.Id > 0)
            {
                bebidaDAO.Update(bebida);
            }
            else
            {               
                bebidaDAO.Create(bebida);
            }

            return RedirectToAction("Cadastro", bebida);
        }

        /// <summary>
        /// Excluir bebida
        /// </summary>
        public ActionResult Excluir(Bebida bebida)
        {
            if (bebida != null)
            {
                bebida = bebidaDAO.Get(bebida.Id);
                bebidaDAO.Delete(bebida);
            }

            return RedirectToAction("Lista");
        }

    }
}