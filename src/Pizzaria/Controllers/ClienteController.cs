using System.Web.Mvc;
using Pizzaria.Models.DAO;
using Pizzaria.Models.Entity;
using Pizzaria.Models.Enum;

namespace Pizzaria.Controllers
{
    public class ClienteController : Controller
    {
        private RepositoryDAO<Cliente> clienteDAO = new RepositoryDAO<Cliente>();

        /// <summary>
        /// Página com todos os clientes
        /// </summary>
        public ActionResult Lista()
        {          
            var cliente = clienteDAO.ListAll();
            return View(cliente);
        }

        /// <summary>
        /// Cadastro do cliente
        /// </summary>
        public ActionResult Cadastro(int id = -1)
        {

            var cliente = new Cliente();

            int cidadeDrop = 0;
            //Edição
            if (id > 0)
            {
                cliente = clienteDAO.ListOneWhere(c => c.Id == id, c => c.Endereco, c => c.Pedidos);
                
                cidadeDrop = cliente.Endereco.Cidade.Id;
            }            

            var listaCidades = new RepositoryDAO<Cidade>().ListAll(c => c.Nome, Ordem.Asc);
           
            ViewBag.Cidade = new SelectList(
                listaCidades,
                "Id",
                "Nome",
                "Estado.Sigla",
                cidadeDrop
            );

            return View(cliente);
        }

        /// <summary>
        /// Salvar um cliente
        /// </summary>
        public ActionResult Salvar(Cliente cliente)
        {            
            if (cliente.Id > 0)
            {                
                clienteDAO.Update(cliente);
            }
            else
            {
                var endereco = new Endereco
                {
                    Logradouro = cliente.Endereco.Logradouro,
                    Bairro = cliente.Endereco.Bairro,
                    Numero = cliente.Endereco.Numero,
                    Cep = cliente.Endereco.Cep,
                    Complemento = cliente.Endereco.Complemento,
                    Cidade = new RepositoryDAO<Cidade>().ListOneWhere(c => c.Id == cliente.Endereco.Cidade.Id)
                };

                new RepositoryDAO<Endereco>().Create(endereco);
                cliente.Endereco = endereco;
                clienteDAO.Create(cliente);
            }

            return RedirectToAction("Cadastro", cliente);
        }

        /// <summary>
        /// Excluir cliente
        /// </summary>
        public ActionResult Excluir(Cliente cliente)
        {
            if (cliente != null)
            {
                cliente = clienteDAO.Get(cliente.Id);
                clienteDAO.Delete(cliente);
            }

            return RedirectToAction("Lista");
        }

    }
}