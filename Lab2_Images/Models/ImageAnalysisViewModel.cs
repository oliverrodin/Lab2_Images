using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

namespace Lab2_Images.Models
{
    public class ImageAnalysisViewModel
    {
        public string ImageUrl { get; set; }
        public ImageAnalysis ImageAnalysisResult { get; set; }
        

    }
}
