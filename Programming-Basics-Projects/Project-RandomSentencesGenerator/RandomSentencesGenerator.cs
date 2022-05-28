string[] names = { "Peter", "Michell", "Jane", "Steve" };
string[] places = { "Sofiq", "Plovdiv", "Varna", "Burags" };
string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
string[] details = { "near the river", "at home", "in the park" };

Console.WriteLine("Hello, this is your first random-generated sentence: ");

while (true)
{
    string name = GetRandomWord(names);
    string place = GetRandomWord(places);
    string verb = GetRandomWord(verbs);
    string noun = GetRandomWord(nouns);
    string adverb = GetRandomWord(adverbs);
    string detail = GetRandomWord(details);

    string who = $"{name} from {place}";
    string action = $"{adverb} {verb} {noun}";
    string sentence = $"{who} {action} {detail}.";

    Console.WriteLine(sentence);
    Console.WriteLine("Click [Enter] to generate a new one.");

    Console.ReadLine();
}

static string GetRandomWord(string[] words)
{
    Random random = new Random();
    string word = words[random.Next(words.Length)];
    return word;
}