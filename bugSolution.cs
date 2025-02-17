public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        // Initialize MyProperty before use
        MyProperty = 10; // Or assign a default value in the constructor
        int y = x + MyProperty; 
    }
}