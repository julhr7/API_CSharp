using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_CSharp.Controllers
{
    public class ProductosController : ApiController
    {
        [HttpGet]
        [Route("api/productos/{PageSize}/{PageNumber}")]
        public List<Entity.Producto> Get(int PageSize, int PageNumber)
        {
            return Regla.Rproducto.ListarPaginada(PageSize, PageNumber);
        }

        // GET: api/<controller>
        [HttpGet]
        public List<Entity.Producto> Get()
        {
            return Regla.Rproducto.Listar();
        }

        // GET api/<controller>/5
        //[HttpGet("{id}")]
        public Entity.Producto Get(int id)
        {
            return Regla.Rproducto.Obtener(id);
        }

        // POST api/<controller>
        [HttpPost]
        public bool Post([FromBody]Entity.Producto oProducto)
        {
            return Regla.Rproducto.Registrar(oProducto);
        }

        // PUT api/<controller>/5
        //[HttpPut("{id}")]
        public bool Put([FromBody]Entity.Producto oProducto)
        {
            return Regla.Rproducto.Modificar(oProducto);
        }

        // DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return Regla.Rproducto.Eliminar(id);
        }
    }
}
