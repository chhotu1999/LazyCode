using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeroPasal.Model.Application.INV
{
    public class MvProduct
    {
        public required long ProductId { get; set; }
        public required string Product { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public string? HSCode { get; set; }
        public bool IsBatchable { get; set; }
        public bool IsExpirable { get; set; }
        public required int ProductTypeListItemId { get; set; }
        public required int ProductCategoryId { get; set; }
        public string? ProductCategory { get; set; }
        public required int BaseInventoryUnitTypeListItemId { get; set; }
        public string? BaseUnit { get; set; }
        public required int DefaultSalesInventoryUnitTypeListItemId { get; set; }
        public string? DefaultSalesUnit { get; set; }
    }
}
