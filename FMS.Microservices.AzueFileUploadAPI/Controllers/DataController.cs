using FMS.Services.AzueFileUploadAPI.Model.DropdownOptions;
using FMS.Services.AzueFileUploadAPI.Services.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FMS.Services.AzueFileUploadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IDrowpdownOptionsService _dropdownOptions;
        public DataController(IDrowpdownOptionsService drowpdownOptionsService)
        {
            _dropdownOptions = drowpdownOptionsService;
        }

        [HttpGet("GetDelimiters")]
        public async Task<IActionResult> GetDelimiters()
        {
            try
            {
                var dropdownOptions = await _dropdownOptions.GetDelimiterOptionsAsync();
                return new JsonResult(dropdownOptions);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetVendorDetails")]
        public async Task<IActionResult> GetVendorDetails()
        {
            try
            {
                var dropdownOptions = await _dropdownOptions.GetVendorOptionsAsync();
                return new JsonResult(dropdownOptions);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
