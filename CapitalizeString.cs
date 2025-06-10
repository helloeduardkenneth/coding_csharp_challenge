// 5. Capitalize String using built-in function - CSharp (Practice)

// Create a function for Capitalization
public static string CapitalizeSentences(string input)
{
    var sentences = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < sentences.Length; i++)
    {
        string sentence = sentences[i].Trim();
        Console.WriteLine(sentence);

        if (sentence.Length > 0)
        {
            sentences[i] = sentence.Substring(0,1).ToUpper() + sentence.Substring(1).ToLower();
        }
    }
    return string.Join(". ", sentences).Trim() + (input.EndsWith(".") ? "." : "");
}

string str = "THIS IS UPPERCASE. this is lowercase.";

Console.WriteLine(CapitalizeSentences(str));