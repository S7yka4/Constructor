using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructor.Storage.Managers.Assemblies;
using Constructor.Storage.Managers.Motherboards;
using Constructor.Storage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Constructor.Controllers.DBChangeControllers
{
    [Route("api/[controller]/[action]")]
    public class MotherboardController : Controller
    {
        private readonly IMotherboardsManager Manager;
        private readonly IAssemblyContainerManager ContainerManager;
        private readonly IAssembliesManager AssembliesManager;
        //public static Guid Id;

        public MotherboardController(IMotherboardsManager _Manager, IAssembliesManager _AssembliesManager,IAssemblyContainerManager _ContainerManager)
        {
            Manager = _Manager;
            ContainerManager = _ContainerManager;
            AssembliesManager = _AssembliesManager;
        }



        [HttpGet("{_Container}")]
        public List<Motherboard> GetCompable(string _Container)
        {
            var Id = Guid.Parse(_Container);
            ViewData["id"] = Id;
            ContainerManager.FillContainer(Id);
            return Manager.GetCompableMotherboards(ContainerManager.Assembly);
        }

        [HttpGet]
        public List<Motherboard> GetAll()
        {
            return Manager.GetAll();
        }

        [HttpGet("{id}")]
        public Motherboard GetById(string id)
        {
            return Manager.GetById(Guid.Parse(id));
        }

        [HttpPost]
        public async Task<Assembly> SetToAssembly([FromBody]IdPair pair)
        {
            try
            {
                ContainerManager.FillContainer(Guid.Parse(pair.AssemblyId));
                var Assembly = ContainerManager.Downgrade();
                Assembly.Motherboard = Guid.Parse(pair.DeviceId);
                await AssembliesManager.Redact(Assembly);
                return Assembly;
            }
            catch
            {
                return null;
            }

        }

        [HttpPost]
        public async Task<Motherboard> Add([FromBody] Motherboard motherboard)
        {
            try
            {
                await Manager.Add(motherboard);
                return motherboard;
            }
            catch
            {
                return null;
            }
        }

        [HttpDelete("{id}")]
        public async Task<string> Delete(string id)
        {
            try
            {
                await Manager.Delete(Guid.Parse(id));
                return "success";
            }
            catch
            {
                return "error";
            }
        }

        [HttpPut("{id}")]
        public async Task<Motherboard> Redact(string id, [FromBody] Motherboard motherboard)
        {
            try
            {

                await Manager.Redact(Guid.Parse(id), motherboard);
                return motherboard;
            }
            catch
            {
                return null;
            }
        }

        [HttpGet]
        public ViewResult RedactPage(Guid id)
        {
            return View(Manager.GetById(id));
        }

        [HttpGet]
        public ViewResult ShowMore(Guid id)
        {

            return View(Manager.GetById(id));
        }
    }
}
