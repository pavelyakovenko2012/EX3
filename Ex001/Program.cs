// Вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();











// Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "новый текст");







// Вид 3

int Method3();
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);










// Вид 4
// string Method4(int count, string text);
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//        result = result + text;
//        if++;
//     }
//     return result;
// }

string Method4(int count, string text);
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($" {i} * {j} = {i * j}");
    }
    Console.WriteLine();
}


// Работа с текстом. Заменить пробелы черточками, "к" на "К" и т.д.






string text = "Я живу с мыслью, что каждую минуту жизнь может измениться к лучшему. Мне так проще жить. Я все время жду хороших новостей, притягиваю их. А если случается плохое, я думаю: так-с, это плохое — ступенька к хорошему. Именно на контрасте с этим «пло- хо» я буду особенно ценить свое наступающее «хорошо», которое уже совсем близко. Очень хочу заразить этой мыслью окружающих.";





// string s = "qwerty"
//             012
// s[3] // r

// string Replase(string text, char oldValue, char newValue);
// {
//     string result = String.Empty;

//     int lendth = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replase(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replase(text, 'к', 'К');
// Console.WriteLine(newText);


int[] arr = {1,4,5,3,8,9,1,3};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosicion = i;

         for (int j = i + 1; j < array.Length; i++)
         {
            if(array[j] < array[minPosicion]) minPosicion = j;
         }

        int temporary = array[i];
        array[i] = array[minPosicion];
        array[minPosicion] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);