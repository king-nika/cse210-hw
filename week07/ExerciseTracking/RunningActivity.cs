public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(int length, double distance) : base(length)
    {
        _distance = distance;
    }

    private double GetSpeed()
    {
        double speed = (_distance / _length) * 60;
        return speed;
    }

    private double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min) - Distance {_distance} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}