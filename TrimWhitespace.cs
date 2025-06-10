// 3. Trim whitespace from strings using built in function - CSharp (Practice)

string sentence = "***This is my description.***";

char[] charsToTrim = { '*', '!' };

string trimmedSentence = sentence.Trim(charsToTrim);

Console.WriteLine(trimmedSentence);