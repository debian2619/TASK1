//view3
//что то возвращают и ничего не принимают
//int Method3()
//{
    //return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);
//view4
//что то принимают и что то возвращают
//string Method4(int count, string text)
//{
    //int i = 0;
    //string result = String.Empty;

    //while(i < count)
    //{
       //result = result + text;
       //i++;   
    //}
    //return result;
//}

//string Method4(int count, string text)
//{
    //string result = String.Empty;
    //for(int i = 0; i < count; i++)
    //{
       //result = result + text;
    //}
    //return result;
//}
//string result =  Method4(10, "z");
//Console.WriteLine(result);
//string Method4(int count, string text)

    //string result = String.Empty;
//таблица умножения
//for(int i = 2; i <= 10; i++)
//{
    //for(int j = 2; j <= 10; j++)
        //{
            //Console.WriteLine($"{i} * {j} = {i * j}");
        //}
        //Console.WriteLine();

//}
    

string text = "Educated people must satisfy the following conditions:"
            + "They respect the human person, always condescending, gentle, polite, compliant ..."

            + "They respect other people's property, and therefore pay their debts."

            + "They do not lie even in trifles ... They do not climb with frankness when they are not asked ... "

            + "They do not humiliate themselves in order to arouse sympathy in another ..."

            + "They are not vain..."

            + "If they have talent in themselves, they respect it… They sacrifice everything for it…"

            + "They bring up aesthetics in themselves"

            + "Here we need uninterrupted day and night work, eternal reading, will ... Every hour is precious here.";
string Replace(string text, char oldValue,  char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";

    }
    return result;

}
string newText = Replace(text, ' ', '-');
Console.WriteLine(newText);
Console.WriteLine();
Console.WriteLine(newText, 'e', 'E');
Console.WriteLine(newText);





   







   
    

