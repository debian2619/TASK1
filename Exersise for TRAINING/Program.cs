//view3
//что то возвращают и ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);
//view4
//что то принимают и что то возвращают
string Method4(int count, string text)
{
    int i = 0;
    result = StringEmpty;
    while(i < count)
    {
       result = result + text;
       i++;   
    }
    return result;
}
string result =  Method4(10, "z");
Console.WriteLine(result);



