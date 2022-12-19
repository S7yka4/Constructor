using Constructor.Storage.Managers;
using Constructor.Storage.Managers.Assemblies;

using Constructor.Storage.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Constructor.Controllers.DBChangeControllers
{
    [Route("api/[controller]/[action]")]
    public class CpuFanController : Controller
    {
        private readonly ICpuFansManager Manager;
        private readonly IAssemblyContainerManager ContainerManager;
        private readonly IAssembliesManager AssembliesManager;
        public static Guid AssemblyId;

        public CpuFanController(ICpuFansManager _Manager, IAssembliesManager _AssembliesManager, IAssemblyContainerManager _ContainerManager)
        {
            Manager = _Manager;
            AssembliesManager = _AssembliesManager;
            ContainerManager = _ContainerManager;
        }

        [HttpGet("{Id}")]
        public List<CpuFan> GetCompable(string Id)
        {
            AssemblyId = Guid.Parse(Id);
            ViewData["id"] = AssemblyId;
            ContainerManager.FillContainer(AssemblyId);
            return Manager.GetCompableCpuFans(ContainerManager.Assembly);
        }

        [HttpGet]
        public List<CpuFan> GetAll()
        {
            return Manager.GetAll();
        }

        [HttpPost]
        async public Task<CpuFan> Add([FromBody] CpuFan entity)
        {
            try
            {
                await Manager.Add(entity);
                return entity;
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
        public async Task<CpuFan> Redact(string id,[FromBody]CpuFan entity)
        {
            try
            {
                await Manager.Redact( entity,Guid.Parse(id));
                return entity;
            }
            catch
            {
                return entity;
            }
        }

        [HttpPost]
        async public Task<Assembly> SetToAssembly([FromBody]IdPair pair)
        {
            var Assembly = AssembliesManager.Find(Guid.Parse(pair.AssemblyId));
            Assembly.CpuFan = Guid.Parse(pair.DeviceId);
            await AssembliesManager.Redact(Assembly);
            return Assembly;
        }

        [HttpGet("{id}")]
        public CpuFan GetById(string id)
        {
            return Manager.GetById(Guid.Parse(id));
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
