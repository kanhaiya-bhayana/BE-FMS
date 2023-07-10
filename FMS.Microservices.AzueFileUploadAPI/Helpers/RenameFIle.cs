﻿namespace FMS.Services.AzueFileUploadAPI.Helpers
{
    public class RenameFIle : IFormFile
    {
        private readonly IFormFile _originalFile;
    private readonly string _newFileName;

    public RenameFIle(IFormFile originalFile, string newFileName)
    {
        _originalFile = originalFile;
        _newFileName = newFileName;
    }

    public string ContentType => _originalFile.ContentType;

    public string ContentDisposition => _originalFile.ContentDisposition;

    public IHeaderDictionary Headers => _originalFile.Headers;

    public long Length => _originalFile.Length;

    public string Name => _newFileName;

    public string FileName => _newFileName;

    public void CopyTo(Stream target)
    {
        _originalFile.CopyTo(target);
    }

    public Task CopyToAsync(Stream target, CancellationToken cancellationToken = default)
    {
        return _originalFile.CopyToAsync(target, cancellationToken);
    }

    public Stream OpenReadStream()
    {
        return _originalFile.OpenReadStream();
    }
}
}
    