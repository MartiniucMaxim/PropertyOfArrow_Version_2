// See https://aka.ms/new-console-template for more information

class Arrow
{
    //enum with ArrowHead  elements:
    //  Wood/Obsidian/Steel
    public enum ArrowHead
    {
        Wood,
        Obsidian,
        Steel,
        Null
    }
    //enum with FletchingType elements 
    // GooseFeathered,TurkeyFeathered,Plastic
    public enum FletchingType
    {
        GooseFeathered,
        TurkeyFeathered,
        Plastic,
        Null
    }

    //Make three fields with private access
    private ArrowHead _arrowHead;
    private FletchingType _fletchingType;
    private int _length;


    //Making property for ArrowHeadType
    public ArrowHead ArrowHeadType
    {
        get { return _arrowHead; }
    }
    //Making property for FletchingTypeChoice 
    public FletchingType FletchingTypeChoice
    {
        get { return _fletchingType; }
    }

    //Making property for Length
    public  int Length
    {
        get { return _length; }
    }

    public Arrow()
    {
        _arrowHead = GetArrowHeadFromUser();
        _fletchingType = GetFletchingTypeFromUser();
        _length = GetLengthFromUser();
    }


    //Making methods which allow user choose ArrowHead choice
    //From enum ArrowHead
    private ArrowHead GetArrowHeadFromUser()
    {
        int arrowHead = Convert.ToInt32(Console.ReadLine());
        switch (arrowHead)
        {
            case (int)ArrowHead.Wood:
                Console.WriteLine($"Your arrows will have a {ArrowHead.Wood} arrowhead");
                return ArrowHead.Wood;
            case (int)ArrowHead.Obsidian:
                Console.WriteLine($"Your arrows will have an {ArrowHead.Obsidian} arrowhead");
                return ArrowHead.Obsidian;
            case (int)ArrowHead.Steel:
                Console.WriteLine($"Your arrows will have an {ArrowHead.Steel}");
                return ArrowHead.Steel;
            default:
                Console.WriteLine($"Your arrow have {ArrowHead.Null} arrowhead. You hadn't choose anything from Wood/Obsidian/Steel choice");
                return ArrowHead.Null;
                //break;
        }
    }

    //Making methods which allow user choose FletchingType choice
    //Depending on enum FletchingType 
    private FletchingType GetFletchingTypeFromUser()
    {
        int fletchingType = Convert.ToInt32(Console.ReadLine()); ;
        switch (fletchingType)
        {
            case (int)FletchingType.GooseFeathered:
                Console.WriteLine($"Your fletching type is {FletchingType.GooseFeathered}");
                return FletchingType.GooseFeathered;
            case (int)FletchingType.TurkeyFeathered:
                Console.WriteLine($"Your fletching type is {FletchingType.TurkeyFeathered}");
                return FletchingType.TurkeyFeathered;
            case (int)FletchingType.Plastic:
                Console.WriteLine($"Your fletching type is {FletchingType.Plastic}");
                return FletchingType.Plastic;
            default:
                Console.WriteLine($"Your fletching type is {FletchingType.Null}. Choose between Goose/Turkey/Plastic feathers.");
                return FletchingType.Null;
                //break;
        }
    }

    //Making Method which allow user input Length type
    private int GetLengthFromUser()
    {
        int length = Convert.ToInt32(Console.ReadLine());
        if (length >= 60 && length <= 100)
        {
            Console.WriteLine($"Your arrow have length:{length}");
        }
        return length;
    }

    //Method, where calculates costs from arrowHead/FletchingType/Length 
    //And results with addition of three costs into one.
    private float GetCost()
    {
        float totalCost = 0;
        float arrowHeadCost = _arrowHead switch
        {
            ArrowHead.Wood => 3f,
            ArrowHead.Obsidian => 5f,
            ArrowHead.Steel => 10f,
            ArrowHead.Null => 0f
        };

        float fletchingCost = _fletchingType switch
        {
            FletchingType.GooseFeathered => 3f,
            FletchingType.TurkeyFeathered => 5f,
            FletchingType.Plastic => 10f,
            FletchingType.Null => 0f
        };
        float lengthCost = _length * 0.05f;
        return totalCost = fletchingCost + arrowHeadCost + lengthCost;
        
    }
    public static void Main(String[] args)
    {
        Arrow myArrow = new();
        Console.WriteLine($"The final price for arrow is:{myArrow.GetCost()} gold");
    }
}
