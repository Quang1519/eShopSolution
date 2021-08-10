using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catalog.Products.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
