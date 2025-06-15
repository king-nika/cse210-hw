public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(int length, int laps) : base(length)
    {
        _laps = laps;
    }

    private double GetDistance()
    {
        double distance = _laps * 50.0 / 1000;
        return distance;
    }

    private double GetSpeed()
    {
        double speed = (GetDistance() / _length) * 60;
        return speed;
    }

    private double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}