using System.Text.RegularExpressions;

List<string> wordsToGuess = new List<string>
{
    "Arance",
    "Elefante",
    "Albero",
    "Zaino"

};
var validCharacters = new Regex("^[A-Z]$");
int lives = 10;
List<string> letters = new();
Random random = new Random();
int wordIndex = random.Next(wordsToGuess.Count);
int missingChars = 0; 
string wordToGuess = wordsToGuess[wordIndex].ToUpper();
void GetWord()
{
    Console.WriteLine($"Ti rimangono {lives} vite.");
    foreach (char character in wordToGuess)
    {
        string letter = character.ToString();
        if (letters.Contains(letter))
        {
            Console.Write(letter);
        }
        else
        {
            Console.Write("_ ");
            missingChars++;
        }
    }
    Console.WriteLine();
}

do
{
    GetWord();
    Console.WriteLine("Inserisci una lettera: ");
    string word = Console.ReadKey().Key.ToString().ToUpper();
    Console.WriteLine();
    letters.Add(word);
    if (!wordToGuess.Contains(word))
        lives--;
}
while (lives > 0);
