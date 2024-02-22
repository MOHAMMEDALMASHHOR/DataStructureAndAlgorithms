namespace Maths;

public class Number
{
    private int _number;
    public Number(int number)
    {
        _number=number;
    }
    public int Multiplier(int number){
        _number=number * _number;
        return _number;
    }
    public int Multiplier(){
        _number*=2;
        return _number;
    }
}
