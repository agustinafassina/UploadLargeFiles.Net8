using Microsoft.AspNetCore.Mvc;

namespace UploadLargeFileNet8.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class FileController : ControllerBase
{
    public FileController()
    {
    }

    [HttpPost("upload")]
    public async Task<IActionResult> Post(IFormFile file)
    {
        string fileName = file.FileName;
        using (var stream = System.IO.File.Create(fileName))
        {
            await file.CopyToAsync(stream);
        }

        return Ok();
    }
}
