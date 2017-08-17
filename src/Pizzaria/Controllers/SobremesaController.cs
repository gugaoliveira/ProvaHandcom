using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;

namespace Pizzaria.Controllers
{
    public class SobremesaController : Controller
    {
        private RepositoryDAO<Sobremesa> sobremesaDAO = new RepositoryDAO<Sobremesa>();

        /// <summary>
        /// Página com todas as sobremesas
        /// </summary>
        public ActionResult Lista()
        {          
            var sobremesa = sobremesaDAO.ListAll();
            return View(sobremesa);
        }

        /// <summary>
        /// Cadastro da sobremesa
        /// </summary>
        public ActionResult Cadastro(int id = -1)
        {
            var sobremesa = new Sobremesa();

            //Edição
            if (id > 0)
            {
                sobremesa = sobremesaDAO.ListOneWhere(c => c.Id == id);              
            }  

            return View(sobremesa);
        }

        /// <summary>
        /// Salvar uma sobremesa
        /// </summary>
        public ActionResult Salvar(Sobremesa sobremesa)
        {            
            if (sobremesa.Id > 0)
            {
                sobremesaDAO.Update(sobremesa);
            }
            else
            {               
                sobremesaDAO.Create(sobremesa);
            }

            return RedirectToAction("Cadastro", sobremesa);
        }

        /// <summary>
        /// Excluir sobremesa
        /// </summary>
        public ActionResult Excluir(Sobremesa sobremesa)
        {
            if (sobremesa != null)
            {
                sobremesa = sobremesaDAO.Get(sobremesa.Id);
                sobremesaDAO.Delete(sobremesa);
            }

            return RedirectToAction("Lista");
        }

    }
}