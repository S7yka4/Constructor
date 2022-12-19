using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructor.Storage.Managers;
using Constructor.Storage.Managers.Assemblies;
using Constructor.Storage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Constructor.Controllers.DBChangeControllers
{
    [Route("api/[controller]/[action]")]
    public class CPUController : Controller
    {

        private readonly ICPUsManager Manager;
        public static Guid AssemblyId;
        private readonly IAssembliesManager AssembliesManager;
        private readonly IAssemblyContainerManager ContainerManager;

        public CPUController(ICPUsManager _manager, IAssembliesManager _AssembliesManager, IAssemblyContainerManager _ContainerManager)
        {
            Manager = _manager;
            AssembliesManager = _AssembliesManager;
            ContainerManager = _ContainerManager;
        }

        [HttpGet("{Id}")]
        public List<CPU> GetCompable(Guid Id)
        {
            AssemblyId = Id;
            ViewData["id"] = AssemblyId;
            ContainerManager.FillContainer(AssemblyId);
            return Manager.GetCompableCPU(ContainerManager.Assembly);
        }

        [HttpGet("{Id}")]
        public CPU GetById(Guid Id)
        {
            try
            {
                return Manager.GetById(Id);
            }
            catch
            {
                return null;
            }
        }

        [HttpGet]
        public List<CPU> GetAll()
        {
            return Manager.GetAll();
        }

        [HttpPost]
        public async Task<CPU> Add([FromBody]CPU cpu)
        {
            try
            {
                
                await Manager.Add(cpu);
                return cpu;
            }
            catch
            {
                return null;
            }
        }

        [HttpDelete("{id}")]
        public async Task<string> Delete(Guid id)
        {
            try
            {
                await Manager.Delete(id);
                return "success";
            }
            catch
            {
                return "error";
            }
        }

        [HttpPut("{id}")]
        public async Task<CPU> Redact(Guid id, [FromBody]CPU cpu)
        {
            try
            {
                
                await Manager.Redact(id, cpu);
                return cpu;
            }
            catch
            {
                return null;
            }
        }

        [HttpPost]
        async public Task<Assembly> SetToAssembly([FromBody] IdPair pair)
        {
            var Assembly = AssembliesManager.Find(Guid.Parse(pair.AssemblyId));
            Assembly.CPU = Guid.Parse(pair.DeviceId);
            await AssembliesManager.Redact(Assembly);
            return Assembly;
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
