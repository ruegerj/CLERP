using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CLERP.API.Infrastructure.Attributes;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CLERP.API.Features.v1.ProductArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ValidateModel]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(GetAll.ProductGetAllResponse))]
        public async Task<ActionResult> GetAllProducts()
        {
            return Ok(await _mediator.Send(new GetAll.ProductGetAllRequest()));
        }

        /// <summary>
        /// Gets a product by the id
        /// </summary>
        /// <param name="id">Id of the requested product</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ProductResponse), Description = "Product found")]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Type = typeof(MessageResponse), Description = "Product couldn't be found")]
        public async Task<ActionResult> GetProductById(Guid id)
        {
            var productDto = await _mediator.Send(new GetById.ProductGetByIdRequest() { ProductId = id });

            if (productDto == null)
            {
                return NotFound(new MessageResponse($"Product with the id: {id} couldn't be found"));
            }

            return Ok(productDto);
        }

        /// <summary>
        /// Creates one or more new products
        /// </summary>
        /// <param name="createData">Data for creating new products</param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse((int)HttpStatusCode.OK,
            Type = typeof(Create.ProductCreateResponse),
            Description = "Product successfuly created")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Product type or compartment coulnd't be found")]
        public async Task<ActionResult> CreateProduct([FromBody] Create.ProductCreateRequest createData)
        {
            return Ok(await _mediator.Send(createData));
        }
    }
}