//Reference_Value();

using Maths;

static void Reference_Value()
{
    int a = 5;
    System.Console.WriteLine(a);
    Multiplier_Shallow(a);
    System.Console.WriteLine(a);
    Multiplier_Deep(ref a);
    System.Console.WriteLine(a);
    static int Multiplier_Shallow(int a)
    {
        a = a * 2;
        return a;
    }
    //5 -5
    static int Multiplier_Deep(ref int a)
    {
        a = a * 2;
        return a;
    }
}

var number = new Number(1);
System.Console.WriteLine(number.Multiplier());