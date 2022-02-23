using apiPruebaTecnica.Context;
using apiPruebaTecnica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly appDBContext context;
        public ClientesController(appDBContext context)
        {

            this.context = context;
        }
        // GET
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.clientes.ToList());
            }
            catch(Exception Ex)
            {
                return BadRequest(Ex.Message);
            }
        }

        // GET BY ID
        [HttpGet("{id}",Name ="GetCliente")]

        public ActionResult Get(Guid id)

        {
            try
            {
                var cliente = context.clientes.FirstOrDefault(g=>g.id==id);
                return Ok(cliente);

            }
            catch (Exception Ex)
            {
                return BadRequest(Ex.Message);
            }
        }

        // POST 
        [HttpPost]
        public ActionResult Post([FromBody] Clientes cliente)
        {

            try
            {
                context.clientes.Add(cliente);
                context.SaveChanges();
                return CreatedAtRoute("GetCliente", new { id = cliente }, cliente);

            }
            catch (Exception Ex)
            {
                return BadRequest(Ex.Message);
            }
        }

        // PUT 
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Clientes cliente)
        {
            try
            {
                if (cliente.id == id)
                {
                    context.Entry(cliente).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetCliente", new { id = cliente }, cliente);
                }
                else
                {
                    return BadRequest( );

                }


            }
            catch (Exception Ex)
            {
                return BadRequest(Ex.Message);
            }
        }

        // DELETE
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                var cliente = context.clientes.FirstOrDefault(g => g.id == id);
                if (cliente != null)
                {
                    context.clientes.Remove(cliente);
                    context.SaveChanges();
                    return Ok(id);

                }
                else
                {
                    return BadRequest();
                }

                return CreatedAtRoute("GetCliente", new { id = cliente }, cliente);

            }
            catch (Exception Ex)
            {
                return BadRequest(Ex.Message);
            }
        }
    }
}
