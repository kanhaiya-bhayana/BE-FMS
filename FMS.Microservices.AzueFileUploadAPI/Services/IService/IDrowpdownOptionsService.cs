using FMS.Services.AzueFileUploadAPI.Model.DropdownOptions;
using System.Threading.Tasks;

namespace FMS.Services.AzueFileUploadAPI.Services.IService
{
    public interface IDrowpdownOptionsService
    {
        Task<IEnumerable<DelimiterOptions>> GetDelimiterOptionsAsync();
        Task<IEnumerable<VendorOptions>> GetVendorOptionsAsync();
    }
}
