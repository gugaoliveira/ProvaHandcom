using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;
using Pizzaria.Models.Enum;
using System.Collections.Generic;

namespace Pizzaria.Controllers
{
    public class PizzaController : Controller
    {
        private RepositoryDAO<Pizza> pizzaDAO = new RepositoryDAO<Pizza>();

        /// <summary>
        /// Página com todas as clientes
        /// </summary>
        public ActionResult Lista()
        {          
            var pizza = pizzaDAO.ListAll(c => c.Nome, Ordem.Asc);
            return View(pizza);
        }

        /// <summary>
        /// Cadastro da pizza
        /// </summary>
        public ActionResult Cadastro(int id = -1)
        {
            var pizza = new Pizza();
            //Edição
            if (id > 0)
            {
                pizza = pizzaDAO.ListOneWhere(c => c.Id == id);
            }
            
            return View(pizza);
        }

        /// <summary>
        /// Salvar uma pizza
        /// </summary>
        public ActionResult Salvar(Pizza pizza)
        {            
            if (pizza.Id > 0)
            {
                pizzaDAO.Update(pizza);
            }
            else
            {               
                pizzaDAO.Create(pizza);
            }

            return RedirectToAction("Cadastro", pizza);
        }

        /// <summary>
        /// Excluir pizza
        /// </summary>
        public ActionResult Excluir(Pizza pizza)
        {
            if (pizza != null)
            {
                pizza = pizzaDAO.Get(pizza.Id);
                pizzaDAO.Delete(pizza);
            }

            return RedirectToAction("Lista");
        }

    }
}