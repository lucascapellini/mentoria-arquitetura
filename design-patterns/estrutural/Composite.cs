interface Folder
{
    int getSize();
    void moveToLocation(string path);
}

class File : Folder
{
    private int size;
    private string path;

    public File(int size, string path)
    {
        this.size = size;
        this.path = path;
    }
    public int getSize()
    {
        return this.size;
    }

    public void moveToLocation(string path)
    {
        this.path = path;
    }
}

class CompositeFolder : Folder
{
    private string path;
    private List<Folder> children;

    public CompositeFolder(string path)
    {
        this.path = path;
    }

    public void create(Folder child)
    {
        this.children.Add(child);
    }

    public void delete(Folder child)
    {
        this.children.Remove(child);
    }

    public void moveToLocation(string path)
    {
        this.path = path;
    }

    public int getSize()
    {
        int sumOfAllSizes = 0;
        foreach (Folder child in this.children)
        {
            sumOfAllSizes += child.getSize();
        }
        return sumOfAllSizes;
    }
}