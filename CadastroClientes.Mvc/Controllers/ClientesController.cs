using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using CadastroClientes.Application.Interface;
using CadastroClientes.Domain.Entities;
using CadastroClientes.Mvc.ViewModels;

namespace CadastroClientes.Mvc.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteAppService;

        public ClientesController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var model = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteAppService.GetAll());

            return View(model);
        }

        // GET: Clientes/Details/5
        public ActionResult Especiais()
        {
            var model = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteAppService.ObterClientesEspeciais());

            return View(model);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _clienteAppService.GetById(id);

            var model = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(model);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(model);

            _clienteAppService.Add(clienteDomain);

            return RedirectToAction("Index");
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _clienteAppService.GetById(id);

            var model = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(model);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(model);

            _clienteAppService.Update(clienteDomain);

            return RedirectToAction("Index");
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _clienteAppService.GetById(id);

            var model = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(model);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClienteViewModel viewModel)
        {
            var model = Mapper.Map<ClienteViewModel, Cliente>(viewModel);

            _clienteAppService.Delete(model);

            return View(viewModel);
        }
    }
}
