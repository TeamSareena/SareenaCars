namespace SareenaCars.Contracts
{
    using System;
    using Misc;

    public interface IGameObject
    {
        int Id { get; set; }

        ConsoleColor Color { get; set; }

        ushort Size { get; set; }

        Position Position { get; set; }

        string DisplaySymbol { get; set; }

    }
}
