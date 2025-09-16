class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] textArray = text.Split(" ");
        _words = new List<Word>();
        foreach (string wordText in textArray)
            _words.Add(new Word(wordText));
    }

    public void HideRandomWords(int numberToHide)
    {
        bool areNumbersToHideReached = false;
        int counter = 0;
        while (!areNumbersToHideReached && counter < numberToHide && !IsCompletelyHidden())
        {
            int randomNumber = new Random().Next(_words.Count);
            if (!_words[randomNumber].IsHidden())
            {
                _words[randomNumber].Hide();
                counter++;
            }

        }            
    }
    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
            text += " "+word.GetDisplayText();
        return $"{_reference.GetDisplayText()} {text}";
    }
    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        foreach (Word word in _words)
            if (word.IsHidden() == false)
            {
                isCompletelyHidden = false;
                break;
            }
        return isCompletelyHidden;
    }
}