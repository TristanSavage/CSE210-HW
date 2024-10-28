


class Reference
{
    // Attributes
    private List<string> _referenceInfo = new List<string>();

    private List<string> _scriptList = new List<string>();
    

    // Constructors
    public Reference()
    {

        // 1 Nephi 15:24
        _scriptList.Add("1 Nephi~15~24~And I said unto them that it was the word of God; and whoso would hearken unto the word of God, and would hold fast unto it, they would never perish; neither could the temptations and the fiery darts of the adversary overpower them unto blindness, to lead them away to destruction.");

        // Proverbs 3:5-6
        _scriptList.Add("Proverbs~3~5-6~Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        
        // Helaman 5:12
        _scriptList.Add("Helaman~5~12~And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        
        // John 14:6
        _scriptList.Add("john~14~6~Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.");
        
        // D&C 4:2
        _scriptList.Add("Doctrine & Covenants~4~2~Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day.");

        Random random = new Random();
        string response = "";
        bool choice = false;
        int index = 0;
        string script = _scriptList[index];
        string[] referenceSplit = script.Split(new char[] { '~' }, 2);
        List<string> referenceInfo = new List<string>();

        while (choice == false)
        {
        Console.Clear();
        index = random.Next(_scriptList.Count);
        script = _scriptList[index];
        referenceSplit = script.Split(new char[] { '~' });
        referenceInfo.Clear();

        foreach (string segment in referenceSplit)
        {
        referenceInfo.Add(segment);
        }

        Console.WriteLine($"{referenceInfo[0]} {referenceInfo[1]}:{referenceInfo[2]} {referenceInfo[3]}");
        Console.WriteLine("Would you like to memorize this scripture? (Yes/No)");
        Console.Write(" > ");
        response = Console.ReadLine();

        if (response == "Yes" || response == "yes" || response == "y" || response == "ye" || response == "ys")
        {
            choice = true;
            _referenceInfo = referenceInfo;
        }
        } 
    }


    // Behaviors
    public string GetReference()
    {

        return $"{_referenceInfo[0]} {_referenceInfo[1]}:{_referenceInfo[2]}";
    }

    public string GetText()
    {
        return _referenceInfo[3];
    }

}