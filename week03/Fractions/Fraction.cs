public class Fraction
{
    // attributes
    private int _top;
    private int _bottom;

    // constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // methods
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string strFrac = $"{_top}/{_bottom}";
        return strFrac;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}