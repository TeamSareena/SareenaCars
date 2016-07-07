namespace SareenaCars.Contracts
{

    public interface ICollectable
    {
        double PointsGiven { get; set; }

        double FuelGiven { get; set; }

        double HealthGiven { get; set; }

        double ArmorGiven { get; set; }
    }
}
