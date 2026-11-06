using CustomCache.Models;

IDataDownloader<int> dataDownloader = new SlowDataDownloader<int>("Data/data1.json");

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

IDataDownloader<string> dataDownloaderStrings = new SlowDataDownloader<string>("Data/data2.json");

Console.WriteLine(dataDownloaderStrings.DownloadData("id1"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id2"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id3"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id1"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id3"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id1"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id2"));

IDataDownloader<bool> dataDownloaderBools = new SlowDataDownloader<bool>("Data/data3.json");

Console.WriteLine(dataDownloaderBools.DownloadData("id1"));
Console.WriteLine(dataDownloaderBools.DownloadData("id2"));
Console.WriteLine(dataDownloaderBools.DownloadData("id3"));
Console.WriteLine(dataDownloaderBools.DownloadData("id1"));
Console.WriteLine(dataDownloaderBools.DownloadData("id3"));
Console.WriteLine(dataDownloaderBools.DownloadData("id1"));
Console.WriteLine(dataDownloaderBools.DownloadData("id2"));