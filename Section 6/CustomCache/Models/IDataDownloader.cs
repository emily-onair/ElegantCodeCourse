namespace CustomCache.Models;

public interface IDataDownloader <T>
{
    T DownloadData(string resourceId);
}