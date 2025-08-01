using Amazon.S3;
using Amazon.S3.Transfer;

namespace AWSFileUploader.Services
{
    public class S3Service
    {
        private readonly IAmazonS3 _s3Client;
        private readonly string _bucketName;

        public S3Service(IConfiguration config)
        {
            _bucketName = config["AWS:BucketName"];
            _s3Client = new AmazonS3Client();
        }

        public async Task UploadFileAsync(IFormFile file)
        {
            using var stream = file.OpenReadStream();
            var uploadRequest = new TransferUtilityUploadRequest
            {
                InputStream = stream,
                Key = file.FileName,
                BucketName = _bucketName
            };
            var fileTransferUtility = new TransferUtility(_s3Client);
            await fileTransferUtility.UploadAsync(uploadRequest);
        }

        public async Task<List<string>> ListFilesAsync()
        {
            var response = await _s3Client.ListObjectsV2Async(_bucketName);
            return response.S3Objects.Select(o => o.Key).ToList();
        }
    }
}
