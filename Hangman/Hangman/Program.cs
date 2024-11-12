using System.Text.RegularExpressions;

List<string> wordsToGuess = new List<string>
{
    "Arance",
    "Elefante",
    "Albero",
    "Zaino"

};
var validCharacters = new Regex("^[A-Z]$");
int attempts = 10;
List<string> letters = new();
Random random = new Random();
int wordIndex = random.Next(wordsToGuess.Count);
int missingChars = 0; 
string wordToGuess = wordsToGuess[wordIndex].ToUpper();
void GetWord(char word)
{
    foreach (char character in wordToGuess)
    {
        string letter = character.ToString();
        if (letters.Contains(letter))
        {
            Console.Write(letter);
            missingChars--;
        }
        else
        {
            Console.Write("_ ");
            missingChars++;
        }
    }
   
}

do
{
    Console.Write("Inserisci una lettera: ");
    char word = (char)Console.Read();
    GetWord(word);
}
while (true);
