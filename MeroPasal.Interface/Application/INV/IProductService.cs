using MeroPasal.Model.Application.INV;
using MeroPasal.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeroPasal.Interface.Application.INV
{
    public interface IProductService
    {
        /// <summary>
        /// Get Product
        /// </summary>
        /// <returns>MvProduct</returns>
        Task<MvGridConfig<MvProduct>?> Product(MvParamReqOption<string> json);
    }
}
