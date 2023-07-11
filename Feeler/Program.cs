/* //==================================================================================================================================\\
 * ||                                                   Introduction to C# programming                                                 ||
 * ||==================================================================================================================================||
 * ||                        ||==============================================================================||                        ||
 * ||                        ||::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::||                        ||
 * ||                        ||    > > > > > > > >       VARIABLES and DATA TYPES         < < < < < < < <    ||                        ||
 * ||                        ||::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::||                        ||
 * ||                        ||==============================================================================||                        ||
 * ||                        || char (characters) -----> a single character such as 'a' or '1'               ||                        ||
 * ||                        || string            -----> a string of characters such as words                ||                        ||
 * ||                        || int (egers)       -----> whole numbers to perform math                       ||                        ||
 * ||                        || double            -----> decimal numbers to perform math                     ||                        ||
 * ||                        || float             -----> large decimal numbers to perform math               ||                        ||
 * ||                        || boolean           -----> true or false values that function                  ||                        ||
 * ||                        ||                   like an on/off switch in code such as if-statements        ||                        ||
 * ||                        || DateTime          -----> Current Date and Time from system time              ||                        ||
 * ||                        ||::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::||                        ||
 * ||                        ||::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::||                        ||
 * ||                        ||==============================================================================||                        ||
 * ||                        ||::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::||                        ||
 * ||                        ||    > > > > > > > >  Other date and time variable types:    < < < < < < < <   ||                        ||
 * ||                        ||::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::||                        ||
 * ||                        ||==============================================================================||                        ||
 * ||                        || DateOnly date = new DateOnly();                                              ||                        ||
 * ||                        || TimeOnly time = new TimeOnly();                                              ||                        ||
 * ||                        ||::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::||                        ||
 * ||                        ||::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::||                        ||
 * ||                        ||==============================================================================||                        ||
 * ||==================================================================================================================================||
 * ||                                                                                                                                  ||
 *  \\================================================================================================================================//
 */
namespace Feeler
{
    internal class Program
    {
        //start of the chores app
        //some special variables that will be explained later
        const string u_ = "\x1B[4m";
        const string _u = "\x1B[0m";
        //here we create some variables to store data in while we use our app :)
        string title = "";
        string firstName = "";
        string lastName = "";
        string toDo = "";
        int priorityRating = 0;
        TimeOnly timeDue = new TimeOnly();
        DateTime today = DateTime.Now;
        bool error = true;
        void Main(string[] args)//main method (the program's main logic)
        {

            //we print today's date and the current time to the console screen
            Console.WriteLine("Oh, hello there, , wow - it feels like I just woke up....\nO.O");
            Console.WriteLine("What day is it?...one sec...\no.O\n-.-\nO.o\n");
            Console.WriteLine($"Oh wow, the time and date right now is {today}...I've been asleep since the stone<d> age.\n>.<");
            Console.WriteLine("I can't remember the last time I had to process anything\n~.~");
            Console.WriteLine("Oh, you're still here..and uhh..I..just met you..just like you have met me.\no.o");
            Console.WriteLine("My name is Feeler btw.\n^.^");

            //we instruct the user that the next action expected is to input their first name
            //Console.WriteLine() is used to print text to the console screen, making it an output function
            Console.WriteLine($"Could you please input your {u_}first name{_u} for me ?\n^w^");
            enterToContinue();
            //Now that the user has received the above instructions, we allow them to respon with an input
            //Console.ReadLine gets the last line that was input into the console screen after the enter key is pressed
            //and enter is pressed, expecting it to be the user's first name
            firstName = $"{Console.ReadLine().Trim()}";//Trim() removes spaces before and after the letters of the text

            //we instruct the user that the next action expected is to input their last name and title seperately.
            Console.WriteLine($"Nice to meet you {firstName}...uh... are you a Mr or a Miss?....or Mrs or Dr.?\nWhat is you {u_}title{_u}?");
            //here we get and store into title the last line that was input into the console screen
            //and enter is pressed, expecting it to be the user's last name
            enterToContinue();
            title = $"{Console.ReadLine().Replace('.', ' ').Trim()}";
            Console.WriteLine($"Ahhh, {title} {firstName}...? wait...uhh, that sounds weird...\nx.x\n" +
                               $"Could you also input your {u_}last name{_u}, please ?");
            //here we get and store into lastName the last line that was input into the console screen
            //and enter is pressed, expecting it to be the user's last name
            enterToContinue();
            lastName = $"{Console.ReadLine().Trim()}";

            //we ask the user to name a toDo item
            Console.WriteLine($"Well, erm...{firstName}, you said you had something to remember for later, a to-do item ... \n" +
                              $"Today you need to have done {u_}             {_u} ?");
            enterToContinue();
            //here we get and store into toDo the last line that was input into the console screen
            //and enter is pressed, expecting it to be the user's toDo item
            enterToContinue();
            toDo = $"{Console.ReadLine().Trim()}";

            //we ask the user to add a time for the toDo item
            Console.WriteLine($"{toDo}...hmmm, on a scale from 1 (not at all) up to and including 5 (life or death),\n" +
                              $"how urgent is completing {toDo} to you ?");
            /*
            * here we get and store into priorityRating the last line that was input into the console screen
            * and enter is pressed, expecting it to be the user's toDo item priority level
            * |-------------------------------------------------------------------------------------------------------------------------------------|
            * |since we have to convert a String                           *(a string refers to a line of any characters)                           |
            * |to an Integer or int for short                              *(an Integer refers to a whole number that can perform math functions)   |
            * |here we use a try-catch statement, and basically prevents your program from crashing and burning if there is an                      |
            * |error that occurs INSIDE of the try statement. if anything breaks or crashes, the line of code that caused the error                 |
            * |is retracted and the logic SKIPS to the catch segment of the statement, meaning that IF the program crashes,                         | 
            * |you can use the CATCH segment to carry on running your program, even  fixing the error in question if you plan well                  |
            * |-------------------------------------------------------------------------------------------------------------------------------------|
            */

            // a while-loop is a statement that will run until a condition is met,
            // example : while(error is not true) do the following { code inside here }
            error = true;//we always assume there is an error BEFORE the first time we try and run a condition statement,
                         //such as if and while
            while (error == true)// this will always be true until the number is correctly converted from text to int and
                                 // is less than or equal to 5
            {
                try//we try to run this code below, knowing there could be some errors - but any error that do occur, will be handled
                {
                    //convert the text input from the console app to integer type
                    enterToContinue();
                    priorityRating = int.Parse(Console.ReadLine().Trim());
                    if (priorityRating <= 5 && priorityRating >= 1)//checks if the rating would fall between 1 and 5
                    {
                        error = false;
                        break;
                    }
                    else//if the user encountered an error, we create the opportunity to fix it here
                    {
                        error = true;
                        Console.WriteLine("Hmmm, it seems as if your number is out of bounds...\n" +
                                           "Please remember to use a number between 1 and 5...");
                    }
                }
                catch (Exception)//if the program crashes completely, this catch segment will catch the error and run the 
                                 //code inside of its brackets
                {
                    Console.WriteLine("Hmmm, it seems as if something went wrong...\n" +
                                       "Please remember to use a numerical character between 1 and 5...");
                    error = true;
                }
            }

            // lastly, we capture the time that this toDo item is projected to be completed. It will use the same error-checking
            // and logic that the previous priorityRating method used, just for a time type variable instead of an integer

            error = true;// we reset the error boolean to true, assuming that there's an error and executing the while-loop
            while (error == true)// this will always be true until the number is correctly converted from text to int and
                                 // is less than or equal to 5
            {
                Console.WriteLine($"{toDo} needs to get done by which time ?\n(HH:MM)\n*24-hour format works best");
                try//we try to run this code below, knowing there could be some errors - but any error that do occur, will be handled
                {
                    enterToContinue();
                    timeDue = TimeOnly.Parse($"{Console.ReadLine().Trim()}");
                    Console.WriteLine($"Is the time {timeDue} due for {toDo} correct?\nPlease choose an option :\n <Y>/<N> ?");
                    string yesno = Console.ReadLine()
                                          .Trim();
                    if (yesno.ToLower() == "y")
                    {
                        error = false;
                        break;
                    }
                    else
                    {
                        error = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Hmmm, it seems as if something went wrong...\n" +
                                       "Please remember to use a 24-h time format HH:MM");
                    error = true;
                }
            }
            Console.WriteLine("Well, let's see what I've learnt so far....");
            string output = $"Your first name is, {firstName}...and your last name is, {lastName}, or so you have told me... \t>.o\n" +
                            $"I know that at {timeDue} you have to had completed {toDo}\n" +
                            $"It has a priority rating of {priorityRating}/5.\n" +
                            $"Good luck {title}. {firstName.Substring(0,1)}. {lastName}!";

            Console.ReadLine();
        }//main method end
        public void enterToContinue() { Console.WriteLine($"\nPress <Enter> to {u_}continue{_u}.\n"); }
    }//main class end
}