using Azure;
using MeroPasal.Api.Controllers.Shared;
using MeroPasal.Interface.Application.INV;
using MeroPasal.Model.Application.INV;
using MeroPasal.Model.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace MeroPasal.Api.Controllers.Application.INV
{
    public class ProductController(IProductService ps) : SharedController
    {

        [HttpGet]
        public async Task<IActionResult> Product([FromQuery] MvParamReqOption<string> json)
        {
            Log.Information("====================> GET: Product");
            try
            {
                var response = await ps.Product(json);
                return Ok(ApiResponse.Success(response));

            }
            catch(Exception ex) 
            {
                return BadRequest(ApiResponse.Fail(ex.Message));
            }
        }


    }
}
