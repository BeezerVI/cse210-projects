// Make fractions hear.
using System.Runtime.CompilerServices;

public class Fraction
{
    private int _bottom;
    private int _top;

    public int GetTop(){
        return _top;
    }
    public void SetTop(int top){
        _top = top;
    }
    public int GetBottom(){
        return _bottom;
    }
    public void SetBottom(int bottom){
        _bottom = bottom;
    }

    public string GetFractionString() {
        string top = _top.ToString();
        string bottom = _bottom.ToString();
        return $"{top}/{bottom}";
    }

    public double GetDecimalValue(){
        double value = _top / _bottom;
        return value;
    }

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
}