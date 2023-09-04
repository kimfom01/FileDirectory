namespace FileDirectory;

public interface IFileDirectory
{
    List<string> GetFileNames(string path);
}