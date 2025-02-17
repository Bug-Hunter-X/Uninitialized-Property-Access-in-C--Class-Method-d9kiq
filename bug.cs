public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        // ... some code
        int y = x + MyProperty; // potential bug: MyProperty might not be initialized
    }
}