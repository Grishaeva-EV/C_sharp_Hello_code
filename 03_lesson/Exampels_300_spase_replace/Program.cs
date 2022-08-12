// Exampels_300_spase_replace
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, 
// а большие “С” заменить маленькими “с”.

// — Я думаю, — сказал князь, улыбаясь, — что,
// ежели бы вас послали вместо нашего милого
// Винценгероде, вы бы взяли приступом согласие
// прусского короля. Вы так красноречивы. Вы
// дадите мне чаю?

string text = " — Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого "
+ "Винценгероде, вы бы взяли приступом согласие "
+ "прусского короля. Вы так красноречивы. Вы "
+ "дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;

    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue)
        {
            result = result + $"{newValue}"; 
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }

    return result;
}

string newText = Replace(text, ' ', '|');

System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);
System.Console.WriteLine();