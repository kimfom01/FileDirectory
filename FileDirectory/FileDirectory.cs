namespace FileDirectory;

public class FileDirectory : IFileDirectory
{
    public List<string> GetFileNames(string path)
    {
        var files = Directory.GetFiles(path).ToList();

        var directories = Directory.GetDirectories(path);

        foreach (var directory in directories)
        {
            files.AddRange(GetFileNames(directory));
        }

        return files;
    }
}
