using System;

static class GameMaster
{
    public static string Describe(Character c) => $"You're a level {c.Level} {c.Class} with {c.HitPoints} hit points.";
    public static string Describe(Destination d) => $"You've arrived at {d.Name}, which has {d.Inhabitants} inhabitants.";
    public static string Describe(TravelMethod travelMethod) => travelMethod switch 
        {
            TravelMethod.Walking => "You're traveling to your destination by walking.",
            TravelMethod.Horseback => "You're traveling to your destination on horseback.",
            _ => ""
        };
    public static string Describe(Character character, Destination destination, TravelMethod travelMethod) =>
        $"{Describe(character)} {Describe(travelMethod)} {Describe(destination)}";
    public static string Describe(Character character, Destination destination) =>
        $"{Describe(character)} {Describe(TravelMethod.Walking)} {Describe(destination)}";
}

class Character
{
    public string Class { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
}

class Destination
{
    public string Name { get; set; }
    public int Inhabitants { get; set; }
}

enum TravelMethod
{
    Walking,
    Horseback
}
