namespace TemperatureChallenge
{
    public interface ITemperature
    {
        double AvgTemperature { get; }
        int MaxTemperature { get; }
        int MinTemperature { get; }

        void Insert(int temperature);
        void Insert(string temperature);
    }
}