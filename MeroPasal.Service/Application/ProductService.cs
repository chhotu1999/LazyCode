using MeroPasal.DataAccess;
using MeroPasal.Interface.Application.INV;
using MeroPasal.Model.Application.INV;
using MeroPasal.Model.Shared;
using Newtonsoft.Json;

namespace MeroPasal.Service.Application
{
    public class ProductService(IDataAccessService ds) : IProductService
    {
        public async Task<MvGridConfig<MvProduct>?> Product(MvParamReqOption<string> json)
        {
            try
            {
                string result = await ds.RetrievalProcedure("inv.SpProductSel", JsonConvert.SerializeObject(json));
                return JsonConvert.DeserializeObject<MvGridConfig<MvProduct>>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
