/* // Работа с текстом 
Дан текст, в тексте, нужно все пробелы заменить черточками, маленькие
буквы к, заменить большими К,
а большие С, заменить маленькими с. */

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + " ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля. "
            + " Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r
// МЕТОД будет принимать строку и те символы, которые нужно будет 
/* // менять, старый символ и на который нужно будет заменить
Возвращаться будет строка
4 вид методов
 */
         //   входеой текст   конкретный симв  символ, на который менять
string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for( int i = 0; i< length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
//затем выводим текст
string newText = Replace(text, ' ', '|' );

Console.WriteLine();
newText = Replace(newText, 'к', 'К');

Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);