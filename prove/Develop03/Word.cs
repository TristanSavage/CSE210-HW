
class Word
{
    // Attributes
    private string _word;
    private bool _hidden = false;

    // Constructors
    public Word(string word, bool hidden)
    {
        _word = word;
        _hidden = hidden;
    }

    // Behaviors
    // public void SetWord(string word)
    // {
    //     _word = word;
    // }

    public string GetWord()
    {
        return _word;
    }

    public string GetHidden()
    {
        return _hidden.ToString();
    }

    public void HideWord()
    {
        _hidden = true;

        char[] letters = _word.ToCharArray();
        List<char> chars = new List<char>();
        
        foreach (char letter in letters)
        {
            chars.Add('_');
        }

        _word = String.Concat(chars);
    }

}
