using Microsoft.AspNetCore.Mvc;
using AWSFileUploader.Services;

namespace AWSFileUploader.Controllers
{
    public class FileController : Controller
    {
        private readonly S3Service _s3Service;

        public FileController(S3Service s3Service)
        {
            _s3Service = s3Service;
        }

        public async Task<IActionResult> Index()
        {
            var files = await _s3Service.ListFilesAsync();
            return View(files);
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file != null)
                await _s3Service.UploadFileAsync(file);

            return RedirectToAction("Index");
        }
    }
}
