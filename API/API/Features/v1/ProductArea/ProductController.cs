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
            Description = "Products successfuly created")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Product types or compartments coulnd't be found")]
        public async Task<ActionResult> CreateProduct([FromBody] Create.ProductCreateRequest createData)
        {
            return Ok(await _mediator.Send(createData));
        }

        /// <summary>
        /// Updates a product
        /// </summary>
        /// <param name="updateData">Data for updating a product</param>
        /// <param name="id">Id of the product which should be updated</param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK,
            Type = typeof(ProductResponse),
            Description = "Product successfuly updated")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Product coulnd't be found")]
        public async Task<ActionResult> UpdateProduct([FromBody] Update.ProductUpdateRequest updateData, Guid id)
        {
            updateData.ProductGuid = id;

            return Ok(await _mediator.Send(updateData));
        }

        /// <summary>
        /// Deletes a product
        /// </summary>
        /// <param name="id">Id of the product</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = null, Description = "Product deleted successfuly")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Product coulnd't be found")]
        public async Task<ActionResult> DeleteProduct(Guid id)
        {
            await _mediator.Send(new Delete.ProductDeleteRequest() { ProductGuid = id });

            return Ok();
        }
    }
}