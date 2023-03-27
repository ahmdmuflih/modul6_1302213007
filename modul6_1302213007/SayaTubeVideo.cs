using System;
using System.Collections.Generic;
namespace modul6_1302213007;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (title == null || title.Length > 200)
            throw new ArgumentException("Invalid title length");

        this.id = new Random().Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || (long)playCount + count > int.MaxValue)
            throw new ArgumentException("Invalid play count");

        checked { playCount += count; }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}, Title: {title}, Play Count: {playCount}");
    }

    public int getPlayCount()
    {
        return playCount;
    }

    public string getTitle()
    {
        return title;
    }
}