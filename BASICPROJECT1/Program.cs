using BASICPROJECT1;
public class Test
{
    public void IntegerArray()
    {
        int[] a = { 1, 2, 3 };
        int[] b = { 4, 5};
        int[] c = a.Concat(b).ToArray();
        Console.WriteLine(string.Join(", ", c));
    }
}
