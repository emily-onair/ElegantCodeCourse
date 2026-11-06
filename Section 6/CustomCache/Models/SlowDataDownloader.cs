using System.Text.Json;

namespace CustomCache.Models;

public class SlowDataDownloader<T>(string filepath) : IDataDownloader<T>
{
    private readonly string _filepath = filepath;

    public T DownloadData(string resourceId)
    {
        //let's imagine this method downloads real data,
        //and it does it slowly
        if (Cache.ContainsKey(resourceId))
        {
            return Cache[resourceId];
        }
        Thread.Sleep(2000);
        string jsonString = File.ReadAllText(_filepath);
        var json = JsonSerializer.Deserialize<Dictionary<string, T>>(jsonString);
        Cache.Add(resourceId, json[resourceId]);
        return json[resourceId];
    }

    public Dictionary<string, T> Cache = new Dictionary<string, T>();
}