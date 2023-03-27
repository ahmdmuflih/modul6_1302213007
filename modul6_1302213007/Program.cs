using System;
namespace modul6_1302213007;
public class Program
{
    public static void Main()
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Ahmad Muflih");

            for (int i = 1; i <= 15; i++)
            {
                SayaTubeVideo video = new SayaTubeVideo($"Review Film The Matrix {i} oleh Ahmad Muflih");
                video.IncreasePlayCount(1000000);
                user.AddVideo(video);
            }

            Console.WriteLine($"Total play count: {user.GetTotalVideoPlayCount()}");

            user.PrintAllVideoPlaycount();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count overflow");
        }
    }
}