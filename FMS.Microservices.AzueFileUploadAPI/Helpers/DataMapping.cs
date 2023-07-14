using FMS.Services.AzueFileUploadAPI.Model;
using FMS.Services.AzueFileUploadAPI.Model.Dto;

namespace FMS.Services.AzueFileUploadAPI.Helpers
{
    public class DataMapping
    {
        public static FileManagement MapData(FileManagementDTO request)
        {
            FileManagement response = new FileManagement();
            if (request!=null)
            {
            response.FileDate = DateTime.Now.ToShortDateString();
            response.FileName = request.FileName;
            response.SourcePath = request.SourcePath;
            response.EmailID = request.EmailID;
            response.Delimiter = request.Delimiter;
            response.IsActive = "N";
            response.ClientID = "101";
            response.FileTypeID = request.FileType;
            response.InsertionMode = "";
            response.TemplateName = request.TemplateFile.FileName;
            response.FixedLength = "N";
            }
           
            return response;
        }
    }
}
