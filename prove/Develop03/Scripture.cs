


class Scripture
{
    // Attributes
    private string _text = "";
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();

    // Constructors
    public Scripture()
    {

        _text = _reference.GetText();
        string[] words = _text.Split(' ');

        foreach (string word in words)
        {
            Word newWord = new Word(word,false);
            // newWord.SetWord(word);
            _words.Add(newWord);
        }
    }

    // Behaviors
    public void HideWords()
    {
        List<Word> revealedWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.GetHidden() == "False")
            {
                revealedWords.Add(word);
                // Console.WriteLine("success");
            }
            else
            {
                // Console.WriteLine(word.GetHidden());
            }
        }

        Random random = new Random();
        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            if (revealedWords.Count == 0)
            {
                break;
            }
            index = random.Next(revealedWords.Count);
            // Console.WriteLine($"Total index = {revealedWords.Count}");
            // Console.WriteLine($"Random index = {index}");
            revealedWords[index].HideWord();
            revealedWords.RemoveAt(index);
        }
    }

    public void Display()
    {
        Console.Clear();
        string reference = _reference.GetReference();
        Console.Write($"{reference}");
        foreach (Word word in _words)
        {
            Console.Write($" {word.GetWord()}");
        }
    }

    public bool CheckText()
    {
        int revealedCount = 0;
        foreach (Word word in _words)
        {
            if (word.GetHidden() == "False")
            {
                revealedCount += 1;
            }
        }

        if (revealedCount == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}