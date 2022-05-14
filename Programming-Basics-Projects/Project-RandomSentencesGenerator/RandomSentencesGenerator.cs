string[] names = { "Peter", "Michell", "Jane", "Steve", };
string[] places = { "Sofiq", "Plovdiv", "Varna", "Burags" };
string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
string[] details = { "near the river", "at home", "in the park" };

while (true)
{
    string name = GetRndomWord(names);
    string place = GetRndomWord(places);
    string verb = GetRndomWord(verbs);
    string noun = GetRndomWord(nouns);
    string adverb = GetRndomWord(adverbs);
    string detail = GetRndomWord(details);

    string who = $"{name} from {place}";
    string action = $"{adverb} {verb} {noun}";
    string sentence = $"{who} {action} {detail}.";

    Console.WriteLine(sentence);

    Console.ReadLine();
}


string GetRndomWord(string[] words)
{
    Random random = new Random();
    string word = words[random.Next(words.Length)];
    return word;
}