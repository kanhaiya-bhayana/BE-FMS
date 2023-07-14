namespace FMS.Services.AzueFileUploadAPI.Model.Dto
{
    public class FileManagementDTO
    {
        public string? FileName { get; set; }
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        public string? FileType { get; set; }

        public string? Delimiter { get; set; }
        public string VendorName { get; set; }

        public IFormFile TemplateFile { get; set; }
        public IFormFile SampleFile { get; set; }

        public string? EmailID { get; set; }

        public string? SLA_Alert { get; set; }
        public string? Linefeed { get; set; }

    }
}
