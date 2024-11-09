class PonderActivities : Activities
{
    // Attributes
    protected List<string> _promptList = new List<string>();
    protected List<string> _unusedPrompts = new List<string>();

    // Constructors

    // Behaviors
    protected string ChoosePrompt()
    {
        Random random = new Random();
        int index = random.Next(_unusedPrompts.Count);
        string promptQuestion = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);

        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts.AddRange(_promptList);
        }

        return promptQuestion;
    }
}