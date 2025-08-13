using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Application.DTOs
{
    public class CreateProductDto
    {
        /// <summary>
        /// Nome do produto.
        /// </summary>
        /// <example>Notebook Gamer</example>
        [Required]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Preço do produto.
        /// </summary>
        /// <example>4999.90</example>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Categoria à qual o produto pertence.
        /// </summary>
        /// <example>Eletrônicos</example>
        [Required]
        public string Category { get; set; } = string.Empty;
    }
}
