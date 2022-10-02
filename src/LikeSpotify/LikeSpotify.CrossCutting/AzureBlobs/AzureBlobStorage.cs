using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace LikeSpotify.CrossCutting.AzureBlobs
{
    public class AzureBlobStorage
    {
        private readonly IConfiguration _configuration;


        public AzureBlobStorage(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task<string> UploadFile(string fileName, Stream buffer, string directory = "")
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(this._configuration["BlobStorageConnection"]);
            BlobContainerClient container = null;

            if (string.IsNullOrWhiteSpace(directory) == false)
            {
                container = blobServiceClient.GetBlobContainerClient($"images/{directory}");
                await container.UploadBlobAsync(fileName, buffer);
                return $"{this._configuration["BlobStorageBasePath"]}/images/{directory}/{fileName}";
            }

            container = blobServiceClient.GetBlobContainerClient($"images");
            await container.UploadBlobAsync(fileName, buffer);

            return $"{this._configuration["BlobStorageBasePath"]}/images/{fileName}";

        }
    }
}
