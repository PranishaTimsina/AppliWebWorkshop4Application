public class ParameterDemo
{
    // Parameter Method
    public void Increase(ref int number)
    {
        number += 10;
    }
    //Out Parameter Method
    public void GetFullName(out string fullname)
    {
        fullname = "Pranisha Timsina";

    }
    // Params parameter method
    public int SumAll(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        return total;
    }
}