using System;
using System.Collections.Generic;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => shirtNum switch
    {
        1 => "goalie",
        2 => "left back",
        3 or 4 => "center back",
        5 => "right back",
        6 or 7 or 8 => "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => throw new ArgumentOutOfRangeException()
    };

    /*public static string AnalyzeOnField(int shirtNum) => playerDescriptionForNumber.ContainsKey(shirtNum)
        ? playerDescriptionForNumber[shirtNum]
        : throw new ArgumentOutOfRangeException();*/
    public static string AnalyzeOffField(object report) => report switch
    {
        int supporterCount => $"There are {supporterCount} supporters at the match.",
        string timeLeft => $"{timeLeft}",
        Foul foul => foul.GetDescription(),
        Injury injury => injury.GetDescription(),
        Incident incident => incident.GetDescription(),
        Manager manager => GetManagerDescription(manager),
        _ => throw new ArgumentException()
    };

    private static string GetManagerDescription(Manager manager) =>
        manager.Club is null ? manager.Name : $"{manager.Name} ({manager.Club})";

    /*private static readonly Dictionary<int, string> playerDescriptionForNumber = new Dictionary<int, string>
    {
        { 1, "goalie" },
        { 2, "left back" },
        { 3, "center back" },
        { 4, "center back" },
        { 5, "right back" },
        { 6, "midfielder" },
        { 7, "midfielder" },
        { 8, "midfielder" },
        { 9, "left wing" },
        { 10, "striker" },
        { 11, "right wing" }
    };*/

}
