bool PlayerLost = false;
int Number = 1;
int score = 0;

string input = string.Empty;
Console.WriteLine("Welcome to a game of Fizz Buzz where the goal is to teach you about division");
Console.WriteLine("""type "Fizz" if the number is divisible by 3""");
Console.WriteLine("""type "Buzz" if the number is divisible by 5""");
Console.WriteLine("""Press enter if it is neither""");

while (!PlayerLost)
{
    Console.WriteLine(Number);
    input = Console.ReadLine().ToString().ToUpper();

    if (input == "FIZZ"){
        if (DivisiblebyThree(Number)){
            Console.WriteLine("Correct!");
            Console.ReadLine();
            Console.Clear();
            score++;
            
        } else{
            Console.WriteLine("Wrong!  Game Over.");
            Console.WriteLine("Score: " + score);
            Console.ReadLine();
            PlayerLost = true;
        }
    } else if (input == "BUZZ"){
        if (DivisiblebyFive(Number))
        {
            Console.WriteLine("Correct!");
            Console.ReadLine();
            Console.Clear();
            score++;
            
        }else{
            Console.WriteLine("Wrong!  Game Over.");
            Console.WriteLine("Score: " + score);
            Console.ReadLine();
            PlayerLost = true;
        }
    }else{
        if (DivisiblebyThree(Number) || DivisiblebyFive(Number)){
            Console.WriteLine("Wrong!  Game Over.");
            Console.WriteLine("Score: " + score);
            Console.ReadLine();
            PlayerLost = true;
            
        }else{
            Console.WriteLine("Correct!");
            Console.ReadLine();
            Console.Clear();
            score++;
            
        }
    }
    ++Number;
}


bool DivisiblebyThree(int X)
{
    return (X % 3) == 0;
}

bool DivisiblebyFive(int X)
{
    return (X % 5) == 0;
}
