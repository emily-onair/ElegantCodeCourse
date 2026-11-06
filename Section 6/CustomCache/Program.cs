using CustomCache.Models;

SlowDataDownloader<int>dataDownloader = new("Data/data1.json");

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

SlowDataDownloader<string>dataDownloaderStrings = new("Data/data2.json");

Console.WriteLine(dataDownloaderStrings.DownloadData("id1"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id2"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id3"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id1"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id3"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id1"));
Console.WriteLine(dataDownloaderStrings.DownloadData("id2"));

SlowDataDownloader<bool> dataDownloaderBools = new("Data/data3.json");

Console.WriteLine(dataDownloaderBools.DownloadData("id1"));
Console.WriteLine(dataDownloaderBools.DownloadData("id2"));
Console.WriteLine(dataDownloaderBools.DownloadData("id3"));
Console.WriteLine(dataDownloaderBools.DownloadData("id1"));
Console.WriteLine(dataDownloaderBools.DownloadData("id3"));
Console.WriteLine(dataDownloaderBools.DownloadData("id1"));
Console.WriteLine(dataDownloaderBools.DownloadData("id2"));