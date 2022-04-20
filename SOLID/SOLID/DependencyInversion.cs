using System.Text.Json;

namespace SOLID;

//string origin = "";
//Monitor monitor = new Monitor(origin);
//await monitor.Show();
//FileDB fileDB= new FileDB(dbPath, origin);
//await FileDB.Save();
public class Monitor
{
    private string _origin;

    public Monitor(string origin)
    {
        _origin = origin;
    }

    public async Task Show()
    {
        //Objeto se crea dentro del metodo show() Dependen los modulos
        InfoByFile info = new InfoByFile(_origin);
        var posts = await info.Get();
        foreach (var post in posts )
            Console.WriteLine(post.title);
        
    }
}

public class FileDB
{
    private string _path;
    private string _origin;

    public FileDB(string path, string origin)
    {
        _path = path;
        _origin = origin;
    }

    public async Task Save()
    {
        InfoByFile info = new InfoByFile(_origin);
        var posts = await info.Get();
        string json = JsonSerializer.Serialize(posts);
        await File.WriteAllTextAsync(_path, json);


    }
}


public class InfoByFile
{
    private string _path;

    public InfoByFile(string path)
    {
        _path = path;
    }

    public async Task<IEnumerable<Post>> Get()
    {
        var contentStream = new FileStream(_path, FileMode.Open, FileAccess.Read);
        IEnumerable<Post> posts =
            await JsonSerializer.DeserializeAsync<IEnumerable<Post>>(contentStream);
        return posts;
    }
}

public class Post
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public bool completed { get; set; }
    
}

