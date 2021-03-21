using System;
using System.Net;
using Serilog;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Dtos.Transacao;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Transacao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacoesController : ControllerBase
    {

        public ITransacaoService _service { get; set; }
        public static IWebHostEnvironment _environment;

        public TransacoesController(ITransacaoService service, IWebHostEnvironment environment)
        {
            _service = service;
            _environment = environment;
        }

        // [Authorize("Bearer")]
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Get(id);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }


        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("{mesReferenciaId}/{tipoOperacao}")]
        public async Task<ActionResult> GetAllTransacao(Guid mesReferenciaId, TipoOperacao tipoOperacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _service.GetAllTransacao(mesReferenciaId,tipoOperacao));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet("resumoMes/{mesReferenciaId}")]
        public async Task<ActionResult> GetResumoMes(Guid mesReferenciaId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _service.GetResumoMes(mesReferenciaId));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TransacaoDto dtoCreate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Post(dtoCreate);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        // [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] TransacaoDto dtoUpdate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Put(dtoUpdate);
                if (result == null)
                {
                    return BadRequest();
                }

                return Ok(result);

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        // [Authorize("Bearer")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
