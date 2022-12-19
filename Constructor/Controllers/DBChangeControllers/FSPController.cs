using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructor.Storage.Managers.Assemblies;
using Constructor.Storage.Managers.FSPs;
using Constructor.Storage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Constructor.Controllers.DBChangeControllers
{
    [Route("api/[controller]/[action]")]
    public class FSPController : Controller
    {
        private readonly IFSPsManager Manager;
        public static Guid Id;
        private readonly IAssembliesManager AssembliesManager;
        private readonly IAssemblyContainerManager ContainerManager;

        public FSPController(IFSPsManager _Manager, IAssembliesManager _AssembliesManager, IAssemblyContainerManager _ContainerManager)
        {
            Manager = _Manager;
            AssembliesManager = _AssembliesManager;
            ContainerManager = _ContainerManager;
        }



        [HttpGet("{id}")]
        public List<FSP> GetCompable(string id)
        {
            Id = Guid.Parse(id);
            ViewData["id"] = Id;
            ContainerManager.FillContainer(Id);
            return Manager.GetCompableFSPs(ContainerManager.Assembly);
        }

        [HttpGet]
        public List<FSP> GetAll()
        {
            return Manager.GetAll();
        }

        [HttpPost]
        public async Task<Assembly> SetToAssembly([FromBody] IdPair pair)
        {
            try
            {
                ContainerManager.FillContainer(Guid.Parse(pair.AssemblyId));
                var Assembly = ContainerManager.Downgrade();
                Assembly.FSP = Guid.Parse(pair.DeviceId);
                await AssembliesManager.Redact(Assembly);
                return Assembly;
            }
            catch
            {
                return null;
            }
        }

        [HttpPost]
        async public Task<FSP> Add([FromBody] FSP fsp)
        {
            try
            {
                await Manager.Add(fsp);
                return fsp;
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

        [HttpGet("{Id}")]
        public FSP GetById(string Id)
        {
            return Manager.GetById(Guid.Parse(Id));
        }

        [HttpPut("{id}")]
        public async Task<FSP> Redact(string id,[FromBody]FSP fsp)
        {
            try
            {
                await Manager.Redact(Guid.Parse(id), fsp);
                return fsp;
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
