namespace LibrarySim.FileWork;

internal class Loading
{
    private FileWork _file;

    public Loading(string path)
    {
        _file = new FileWork(path);
    }
    void WriteObject(object obj, int id)
    {
        _file.WriteLine(obj.ToString(), id);
    }
}
