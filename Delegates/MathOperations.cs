namespace Delegates;

internal class MathOperations
{
    private const int STABLE_NUMBER = 3;
    public int Multiplier(int a)
    {
        var b = a * STABLE_NUMBER;
        return b;
    }

    public int Sum(int a)
    {
        return a + STABLE_NUMBER;
    }

    public int Deducte(int a)
    {
        return a - STABLE_NUMBER;
    }
}