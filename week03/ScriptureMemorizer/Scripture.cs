public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        var unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();

        if (unhiddenWords.Count == 0) return;

        int countToHide = Math.Min(numberToHide, unhiddenWords.Count);

        for (int i = 0; i < countToHide; i++)
        {
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            unhiddenWords.RemoveAt(index); // prevent hiding same word again
        }
    }
    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {displayText}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.TrueForAll(word => word.IsHidden());
    }

    public void ShowAllWords()
    {
        _words.ForEach(word => word.Show());
    }

}