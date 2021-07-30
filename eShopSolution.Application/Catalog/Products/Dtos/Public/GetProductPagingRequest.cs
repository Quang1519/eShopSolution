using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Application.Dtos;

namespace eShopSolution.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase 
    {
        public int? CategoryId { get; set; }
    }
}
