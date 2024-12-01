int[] schedule = [800, 1200, 1600, 2000];

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    int currentGMTAbs = Math.Abs(currentGMT);
    int newGMTAbs = Math.Abs(newGMT);

    if (currentGMTAbs > 12 || newGMTAbs > 12)
        Console.WriteLine("Invalid GMT");
    else if ((currentGMT <= 0 && newGMT <= 0) || (currentGMT >= 0 && newGMT >= 0))
        diff = 100 * (currentGMTAbs - newGMTAbs);
    else
        diff = 100 * (currentGMTAbs + newGMTAbs);

    foreach (var time in times)
    {
        int newTime = (time + diff) % 2400;
        Console.WriteLine($"{time} -> {newTime}");
    }
}

DisplayAdjustedTimes(schedule, 6, -6);
