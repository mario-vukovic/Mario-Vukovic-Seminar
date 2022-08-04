using Mario_Vukovic_Seminar.Models.ViewModel;

namespace Mario_Vukovic_Seminar.Services.Interface;

public interface IFileStorageService
{
    Task<FileStorageViewModel> AddFileToStorage(IFormFile file);
    Task<bool> DeleteFile(int id);
    Task<FileStorageExpendedViewModel> GetFile(long id);
}