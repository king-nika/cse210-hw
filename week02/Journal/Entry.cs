public class Entry
{
    public string _prompt { get; set; }
    public string _response { get; set; }
    public string _date { get; set; }

    // Parameterless constructor needed for deserialization
    public Entry() { }

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\nResponse: {_response}\n");
    }
}
