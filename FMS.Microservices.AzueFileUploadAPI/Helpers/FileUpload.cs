﻿using FMS.Services.AzueFileUploadAPI.Model.Dto;
using FMS.Services.AzueFileUploadAPI.Services;

namespace FMS.Services.AzueFileUploadAPI.Helpers
{
    public class FileUpload
    {
        private readonly IAzureUploadFileService _azureUploadFileService;

        public FileUpload(IAzureUploadFileService azureUploadFileService)
        {
            _azureUploadFileService = azureUploadFileService;
        }
        public async Task<AzureBlobResponseDto> FileUploadAsync(IFormFile formFile)
        {
            AzureBlobResponseDto response = await _azureUploadFileService.UploadAsync(formFile);
            return response;
        }
    }
}
