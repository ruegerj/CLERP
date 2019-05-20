using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CLERP.API.Features.v1;
using CLERP.API.Infrastructure.Attributes;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace CLERP.API.Features.v1.ProductTypeArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ValidateModel]
    public class ProductTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Gets all product types
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: typeof(GetAll.ProductTypeGetAllResponse))]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> GetAllProductTypes()
        {
            return Ok(await _mediator.Send(new GetAll.ProductTypeGetAllRequest()));
        }

        /// <summary>
        /// Gets a product type by the id
        /// </summary>
        /// <param name="id">Id of the product type</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: typeof(ProductTypeResponse), Description = "ProductType found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.NotFound, responseType: typeof(MessageResponse), Description = "ProductType couldn't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> GetProductTypeById(Guid id)
        {
            var productType = await _mediator.Send(new GetById.ProductTypeGetByIdRequest() { ProductTypeId = id });

            if (productType == null)
            {
                return NotFound(new MessageResponse($"ProductType with the id: {id} couldn't be found"));
            }

            return Ok(productType);
        }

        /// <summary>
        /// Creates a new product type
        /// </summary>
        /// <param name="createData">Data for creating a new product type</param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK,
            responseType: typeof(Create.ProductTypeCreateResponse),
            Description = "ProductType successfuly created")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.Conflict,
            responseType: typeof(ConflictResponse),
            Description = "Entered data conflicts with existing")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> CreateProductType([FromBody] Create.ProductTypeCreateRequest createData)
        {
           return Ok(await _mediator.Send(createData));
        }

        /// <summary>
        /// Updates a product type
        /// </summary>
        /// <param name="updateData">Data for updating a product type</param>
        /// <param name="id">Id of the product type</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, 
            responseType: typeof(ProductTypeResponse), 
            Description = "ProductType successfuly updated")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest,
            responseType: typeof(BadRequestResponse),
            Description = "ProductType couldn't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> UpdateProductType([FromBody] Update.ProductTypeUpdateRequest updateData, Guid id)
        {
            updateData.ProductTypeGuid = id;

            return Ok(await _mediator.Send(updateData));
        }

        /// <summary>
        /// Deletes a product type
        /// </summary>
        /// <param name="id">Id of the prodcut type</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: null, Description = "ProductType deleted successfuly")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest,
            responseType: typeof(BadRequestResponse),
            Description = "ProductType coulnd't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> DeleteProductType(Guid id)
        {
            await _mediator.Send(new Delete.ProductTypeDeleteRequest() { ProductTypeGuid = id });

            return Ok();
        }
    }
}