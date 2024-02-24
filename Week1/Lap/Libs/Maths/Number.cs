namespace Maths;
public class Number
{
    private int _number;//Field
    public int Value
    {
        get
        {
            return _number; //Property
        }
        set             //=> void set(int value)
        {
            _number = value;
        }
    }

    public int MaxValue => int.MaxValue; //unsigned int numbers 2^32 = 4294967296, signed int numbers 2^31 = -2147483648, 0,2^31 - 1 = 2147483647
    public int MinValue => int.MinValue;

    public Number()
    {

    }

    public Number(int x)
    {
        _number = x;
    }

    public int Multiply(int coefficient)
    {
        _number = coefficient * _number;
        return _number;
    }

    public int Multiply()
    {
        _number = 2 * _number;
        return _number;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}

