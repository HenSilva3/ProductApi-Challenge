using Microsoft.AspNetCore.Mvc;
using ProductApi.Application.DTOs;
using ProductApi.Application.Interfaces;

namespace ProductApi.Web.Controllers
{
    [ApiController]
    [Route("produto")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Lista todos os produtos cadastrados.
        /// </summary>
        /// <returns>Uma lista de produtos.</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetProductsAsync();
            return Ok(products);
        }

        /// <summary>
        /// Cria um novo produto.
        /// </summary>
        /// <param name="productDto">Dados do produto a ser criado.</param>
        /// <returns>O produto recém-criado.</returns>
        /// <response code="201">Retorna o produto recém-criado</response>
        /// <response code="400">Se os dados do produto forem inválidos</response>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductDto productDto)
        {
            var product = await _productService.CreateProductAsync(productDto);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }
    }
}
