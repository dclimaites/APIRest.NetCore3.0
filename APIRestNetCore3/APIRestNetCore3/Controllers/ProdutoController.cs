using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;

namespace APIRestNetCore3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private ProductRepository _productRepository;
        public ProdutoController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
    }
}