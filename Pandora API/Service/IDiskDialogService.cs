namespace Pandora.API.Service;

public interface IDiskDialogService
{
    Task<FileInfo?> OpenFileAsync();
    Task<DirectoryInfo?> OpenFolderAsync();
}
