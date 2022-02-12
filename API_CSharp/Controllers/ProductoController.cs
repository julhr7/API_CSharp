using API_CSharp.Data;
using API_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_CSharp.Controllers
{
    public class ProductoController : ApiController
    {
        // GET: api/<controller>
        [HttpGet]
        public List<Producto> Get()
        {
            return ProductoData.Listar();
        }

        // GET api/<controller>/5
        //[HttpGet("{id}")]
        public Producto Get(int id)
        {
            return ProductoData.Obtener(id);
        }

        // POST api/<controller>
        [HttpPost]
        public bool Post([FromBody]Producto oProducto)
        {
            return ProductoData.Registrar(oProducto);
        }

        // PUT api/<controller>/5
        //[HttpPut("{id}")]
        public bool Put([FromBody]Producto oProducto)
        {
            return ProductoData.Modificar(oProducto);
        }

        // DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return ProductoData.Eliminar(id);
        }
    }
}