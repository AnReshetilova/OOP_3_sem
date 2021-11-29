using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int testplace = 10;
            string testcoord = "11;14;26;38";

            User user = new User(10, "11;14;26;38");
            PlaceHandler placeHandler = new PlaceHandler();
            PositionHandler positionHandler = new PositionHandler();
            ParamHandler paramHandler = new ParamHandler();

            user.Replace += positionHandler.Message;
            user.Replace += paramHandler.Message;
            user.Squeeze += placeHandler.Message;
            user.Squeeze += paramHandler.Message;

            OperationSqueezing operationSqueezing = (ref int testplace) => testplace /= 2;
            OperationMoving operationMoving = (ref string testcoord) => testcoord  = "12;14;26;38";

            if (!user.CheckPlace(testplace))
            {
                operationSqueezing(ref testplace);
            }

            if (!user.CheckPosition(testcoord))
            {
                operationMoving(ref testcoord);
            }

            Func<string, string> func;
            string str = "hEll!o  wOr,l?d ";

            func = StringEditor.DeleteSpaces;
            str = func(str);
            Console.WriteLine(str);

            func = StringEditor.DeleteSigns;
            str = func(str);
            Console.WriteLine(str);

            func = StringEditor.FirstLetterToUpper;
            str = func(str);
            Console.WriteLine(str);

            func = StringEditor.AddSmile;
            str = func(str);
            Console.WriteLine(str);
        }
    }
}
