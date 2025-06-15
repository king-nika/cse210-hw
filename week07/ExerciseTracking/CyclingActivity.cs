public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(int length, double speed) : base(length)
    {
        _speed = speed;
    }

    private double GetDistance()
    {
        double distance = (_length / 60) * _speed;
        return distance;
    }

    private double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min) - Distance {GetDistance()} km, Speed {_speed} kph, Pace: {GetPace()} min per km";
    }
}