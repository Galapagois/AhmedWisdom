using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedWisdom
{
    class Program
    {
        static void Main(string[] args)
        {
            string hr = "--------------------------------------------------------------------------------";
            string[] pearls = new string[] { "You should never|trust your friends.",
                "P*********a is|illegal.",
                "Hello, nice to meet you! Tell me about|a time you had a nightmare.",
                "Don't self-analyse|too much.",
                "Have you considered|going blonde?",
                "I abide by the three second|eye contact rule.",
                "How do you know if|a girl likes you?",
                "I would get rid of|l******s.",
                "I love me some|cheese.",
                "Many women are more|judgemental than men.",
                "I have been told that|I am a disruption.",
                "Nothing is for certain until|you are proven wrong.",
                "I myself love to learn from my mistakes,|even if they are very painful. [Clears throat]",
                "I sometimes dream of|this office.",
                "I had a house guest once.|They wanted to leave... but they had no choice.",
                "I am not a|naughty boy.",
                "It's fun to be|stupid from time to time.",
                "Excuse me, I've seen|you've undone your pants by accident.",
                "At the club, I try to|split the girl from her 'pack'.",
                "I like boys -|you know that.",
                "You'd make a great pool boy, because|housewives would want to do you.",
                "H***y housewives don't give a s**t about|a man's mental state or capacity if he's up for a good time.",
                "I'm not a predator, I'm just|a man who takes opportunities.",
                "I don't need to know|where I live.",
                "You've got to|be sad to be happy.",
                "American Beauty!|That's my favourite last movie.",
                "I already have|everything I need.",
                "I ask questions because|I care.",
                "I always enjoy|every bit of Ruaidhri Time I get.",
                "I take pictures with|my eyes, man.",
                "On the train, I sometimes|talk to the women I see.",
                "I love|you too.",
                "I would prefer for people not to die from|countless human mistakes.",
                "Makeup is|a sticky situation.",
                "Women,|they stay in the house.",
                "How dense is your head? Not as dense as|mine, b***h!",
                "We don't share this world with|the chickens.",
                "I don't even have|toes.",
                "Always look before you|jump.",
                "It makes my day to hear|you've lost something.",
                "I've touched her, and now she's|dying of AIDS.",
                "Never memorise - it's|a waste of time.",
                "Green is the colour of 'go'. That means|I'm approachable."
            };

            Random rand = new Random();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(hr);
            Console.WriteLine("                              THE WISDOM OF AHMED");
            Console.WriteLine(hr);
            Console.WriteLine("  These are all real quotes, none of which are endorsed by any sensible human.");
            Console.WriteLine(hr);
            Console.ResetColor();

            do
            {
                Console.WriteLine("1) Pearl of Wisdom\n2) New Pearl\n3) Exit");
                Console.WriteLine(hr);
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case ("1"):
                        Console.WriteLine(hr);
                        int pearlChoice = rand.Next(0, pearls.Length);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\"{0}\"", pearls[pearlChoice].Replace("|"," "));
                        Console.ResetColor();
                        Console.WriteLine(hr);
                        break;
                    case ("2"):
                        int randChoice = rand.Next(0, pearls.Length);
                        string[] separated = pearls[randChoice].Split('|');
                        int randChoice2 = rand.Next(0, pearls.Length);
                        while (randChoice == randChoice2)
                        {
                            randChoice2 = rand.Next(0, pearls.Length);
                        }
                        string[] separated2 = pearls[randChoice2].Split('|');
                        Console.WriteLine(hr);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\"{0} {1}\"",separated[0],separated2[1]);
                        Console.ResetColor();
                        Console.WriteLine(hr);
                        break;
                    case ("3"):
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(hr);
                        Console.WriteLine("Not a valid option.");
                        Console.WriteLine(hr);
                        break;
                }
            } while (true);
        }
    }
}
