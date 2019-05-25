using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CLERP.API.Features.v1;
using CLERP.API.Infrastructure.Attributes;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
        /// Adds a product type as a new parent to a product type
        /// </summary>
        /// <param name="productTypeAddParenData">Data for adding a new parent product type</param>
        /// <returns></returns>
        [HttpPost("add-parent")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: null, Description = "Parent successfuly added")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest, 
            responseType: typeof(BadRequestResponse), 
            Description = "Product type or parent product type coulnd't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.Conflict, 
            responseType: typeof(ConflictResponse), 
            Description = "Entered data conflicts with existing")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> AddParentProductType([FromBody] AddParent.ProductTypeAddParentRequest productTypeAddParenData)
        {
            await _mediator.Send(productTypeAddParenData);

            return Ok();
        }

        /// <summary>
        /// Adds a product type as a new child to a product type
        /// </summary>
        /// <param name="productTypeAddChildData">Data for adding a new child product type</param>
        /// <returns></returns>
        [HttpPost("add-child")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: null, Description = "Child successfuly added")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest,
            responseType: typeof(BadRequestResponse),
            Description = "Product type or child product type coulnd't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.Conflict,
            responseType: typeof(ConflictResponse),
            Description = "Entered data conflicts with existing")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> AddChildProductType([FromBody] AddChild.ProductTypeAddChildRequest productTypeAddChildData)
        {
            await _mediator.Send(productTypeAddChildData);

            return Ok();
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
        /// Removes a parent product type from a product type (base)
        /// </summary>
        /// <param name="productTypeRemoveParentData">Data for removing the parent from the base product type</param>
        /// <returns></returns>
        [HttpDelete("remove-parent")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK,
            responseType: null,
            Description = "Parent successfuly removed from the product type")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest,
            responseType: typeof(BadRequestResponse),
            Description = "Parent or base product type couln't be found, or the base product type doesn't have this product type as parent")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> RemoveParentProductType([FromBody] RemoveParent.ProductTypeRemoveParentRequest productTypeRemoveParentData)
        {
            await _mediator.Send(productTypeRemoveParentData);

            return Ok();
        }

        /// <summary>
        /// Removes a child product type from a product type (base)
        /// </summary>
        /// <param name="productTypeRemoveChildData">Data for removing the child from the base product type</param>
        /// <returns></returns>
        [HttpDelete("remove-child")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK,
            responseType: null,
            Description = "Child successfuly removed from the product type")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest,
            responseType: typeof(BadRequestResponse),
            Description = "Child or base product type couln't be found, or the base product type doesn't have this product type as child")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> RemoveChildProductType([FromBody] RemoveChild.ProductTypeRemoveChildRequest productTypeRemoveChildData)
        {
            await _mediator.Send(productTypeRemoveChildData);

            return Ok();
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