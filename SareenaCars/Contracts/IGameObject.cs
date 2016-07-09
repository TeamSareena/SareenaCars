namespace SareenaCars.Contracts
{
    using System;

    public interface IGameObject
    {
        int Id { get; set; }
        ConsoleColor Color { get; set; }
        int Width { get; }
        int Height { get; }
    }
}
