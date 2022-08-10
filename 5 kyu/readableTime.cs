using System;

public static class TimeFormat {

    public static string GetReadableTime(int seconds) {

        Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", seconds / 3600, (seconds % 3600) / 60, seconds % 60);
        
        return string.Format("{0:D2}:{1:D2}:{2:D2}", seconds / 3600, (seconds % 3600) / 60, seconds % 60);

    }

}
