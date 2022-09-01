using Lab2_Images.Models;

namespace Lab2_Images.Services
{
    public interface IComputerVisionService
    {
        Task GetThumbnail(string imageId);
        Task<ImageAnalysisViewModel> AnalyzeImageUrl(string imageUrl);
    }
}
