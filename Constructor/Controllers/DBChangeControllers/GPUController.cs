using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructor.Storage.Managers.Assemblies;
using Constructor.Storage.Managers.GPUs;
using Constructor.Storage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Constructor.Controllers.DBChangeControllers
{
    [Route("api/[controller]/[action]")]
    public class GPUController : Controller
    {
        private readonly IGPUsManager Manager;
        //public static Guid Id;
        private readonly IAssembliesManager AssembliesManager;
        private readonly IAssemblyContainerManager ContainerManager;

        public GPUController(IGPUsManager _Manager, IAssembliesManager _AssembliesManager, IAssemblyContainerManager _ContainerManager)
        {
            Manager = _Manager;
            AssembliesManager= _AssembliesManager;
            ContainerManager = _ContainerManager;
        }

        
        [HttpGet("{_Container}")]
        public List<GPU> GetCompable(string _Container)
        {
           var  Id = Guid.Parse(_Container);
            ViewData["id"] = Id;
            ContainerManager.FillContainer(Id);
            return Manager.GetCompableGPUs(ContainerManager.Assembly);
        }

        [HttpGet("{id}")]
        public GPU GetById(string id)
        {
            return Manager.GetById(Guid.Parse(id));
        }

        [HttpGet]
        public List<GPU> GetAll()
        {
            return Manager.GetAll();
        }

        [HttpPost]
        public async Task<GPU> Add([FromBody] GPU gpu)
        {
            try
            {
                await Manager.Add(gpu);
                return gpu;
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
                return "false";
            }
        }

        [HttpPut("{id}")]
        public async Task<GPU> Redact(string id, [FromBody] GPU gpu)
        {
            try
            {
                await Manager.Redact(Guid.Parse(id), gpu);
                return gpu;
            }
            catch
            {
                return null;
            }
        }

        [HttpPost]
        public async Task<Assembly> SetToAssembly([FromBody] IdPair pair)
        {
            ContainerManager.FillContainer(Guid.Parse(pair.AssemblyId));
            Assembly _Assembly = ContainerManager.Downgrade();
            _Assembly.GPU = Guid.Parse(pair.DeviceId);
            await AssembliesManager.Redact(_Assembly);
            return _Assembly;
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
