﻿using Xero.Demo.Api.Domain;
using Xero.Demo.Api.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static Xero.Demo.Api.Domain.Models.CONSTANTS;

namespace Xero.Demo.Api.Endpoints.V2.Products
{
    public partial class ProductsController : BaseApiController
    {
        /// <summary>
        /// TO-DO :: Add product.
        /// </summary>
        /// <param name="product">Enter the product</param>
        /// <param name="culture">Enter the culture</param>
        /// <returns></returns>
        [ApiVersion(ApiVersionNumbers.V2)]
        [HttpPost("", Name = RouteNames.PostAsync)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostAsync(Product product, string culture)
        {
            await Task.Delay(1);                                                  // simulating asynchronous/ non-blocking call
            return CreatedAtRoute(
                    RouteNames.GetByIdAsync,
                    new { id = product.Id, culture },
                    product
                );
        }
    }
}