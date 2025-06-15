public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(int length)
    {
        DateTime today = DateTime.Today;
        _date = today.ToString("dd MM yyyy");
        _length = length;
    }

    public abstract string GetSummary();
}