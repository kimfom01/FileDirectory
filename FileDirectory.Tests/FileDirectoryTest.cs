namespace FileDirectory.Tests;

[TestFixture]
public class FileDirectoryTest
{
    [Test]
    public void TestGetFileNames()
    {
        IFileDirectory fileDirectory = new FileDirectory();

        var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\test";

        var actual = fileDirectory.GetFileNames(path);

        var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        var expected = new List<string>
        {
            desktopPath + "\\test\\dashboard.jpg",
            desktopPath + "\\test\\folder\\Admin.png",
            desktopPath + "\\test\\folder\\Screenshot 2023-09-03 140659.png",
            desktopPath + "\\test\\folder\\sub\\Add Guest.png",
            desktopPath + "\\test\\folder\\sub\\Admin.png",
            desktopPath + "\\test\\folder 2\\Add Guest.png",
            desktopPath + "\\test\\folder 2\\Admin.png"
        };

        Assert.That(actual, Is.EqualTo(expected));
    }
}
