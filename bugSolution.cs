public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize to 0

    public void MyMethod() {
        //Check for null before using property
        int value = MyProperty * 2; 
    }

    //Or handle potential nulls
    public void MyMethod2() {
        int value = (MyProperty == null) ? 0 : MyProperty * 2; // Handle null value
    }
}