using System;
using System.Collections.Generic;
namespace modul6_1302213007;

public class SayaTubeUser
{
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        if (username == null || username.Length > 100)
            throw new ArgumentException("Invalid username length");

        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (SayaTubeVideo video in uploadedVideos)
        {
            totalPlayCount += video.getPlayCount();
        }
        return totalPlayCount;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null || video.getPlayCount() >= int.MaxValue)
            throw new ArgumentException("Invalid video");

        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {username}");
        int count = 0;
        foreach (SayaTubeVideo video in uploadedVideos)
        {
            if (count == 8)
                break;

            Console.WriteLine($"Video {++count} judul: {video.getTitle()}");
        }
    }
}
