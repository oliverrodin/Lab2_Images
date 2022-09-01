using System.Drawing;
using System.Net.Mime;
using Lab2_Images.Models;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

namespace Lab2_Images.Services
{
    public class ComputerVisionService : IComputerVisionService
    {
        private string subscriptionKey = "8dae027ebc114fd0adf3120b3a509569";
        private string subscriptionEndpoint = "https://orcogsvc2.cognitiveservices.azure.com/";

        public ComputerVisionClient Authenticate()
        {
            ComputerVisionClient client = new ComputerVisionClient(new ApiKeyServiceClientCredentials(subscriptionKey))
            {
                Endpoint = subscriptionEndpoint
            };
            return client;
        }


        public async Task GetThumbnail(string imageId)
        {
            ComputerVisionClient client = Authenticate();
            var thumbnail = await client.GenerateThumbnailAsync(100, 100, imageId, true);

            string thumbnailFileName = "thumbnail.jpg";
            using (Stream thumbFile = File.Create(thumbnailFileName))
            {
                thumbnail.CopyTo(thumbFile);
            }
        }

        public async Task<ImageAnalysisViewModel> AnalyzeImageUrl(string imageUrl)
        {
            ImageAnalysis result;


            try
            {
                ComputerVisionClient client = Authenticate();

                List<VisualFeatureTypes?> features = new List<VisualFeatureTypes?>() {
                    VisualFeatureTypes.Categories, 
                    VisualFeatureTypes.Description,
                    VisualFeatureTypes.Faces, 
                    VisualFeatureTypes.ImageType,
                    VisualFeatureTypes.Tags, 
                    VisualFeatureTypes.Adult,
                    VisualFeatureTypes.Color, 
                    VisualFeatureTypes.Brands,
                    VisualFeatureTypes.Objects,
                };

                
                result = await client.AnalyzeImageAsync(imageUrl, visualFeatures: features);




                

                ImageAnalysisViewModel imageAnalysis = new ImageAnalysisViewModel();
                imageAnalysis.ImageAnalysisResult = result;
                imageAnalysis.ImageUrl = imageUrl;

                return imageAnalysis;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
