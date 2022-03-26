using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers.FileHelperr
{
    public interface IFileHelper
    {
        IResult Upload(IFormFile file, string root);
        IResult Delete(string filePath);
        IResult Update(IFormFile file, string filePath, string root);
    }
}
