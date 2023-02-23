using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using danj_backend.Data;
using danj_backend.Repository;

namespace danj_backend.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class CoreBaseController<TEntity, TRepository> : ControllerBase
    where TEntity : class, IEntity
    where TRepository : IUsersRepository<TEntity>
    {
        private readonly TRepository repository;

        public CoreBaseController(TRepository repository){
            this.repository = repository;
        }

        [Route("add-admin"), HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity users){
            await repository.AddUserAdmin(users);
            return Ok("Success");
        }

        [Route("check-email/{email}"), HttpGet]
        public ActionResult CheckIfTheresAdmin(string email){
            var result = repository.FindEmailExist(r => r.email == email);
            if(result != null) {
                return Ok("exist");
            }
            return Ok("not_exist");
        }
    }
}