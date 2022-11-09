using System.Net;
using static System.Net.Mime.MediaTypeNames;

static void CSharp()
{
    /// <summary>
    /// Use Meaningful Names
    /// Naming Variables is probably the hardest part of the entire development cycle, 
    /// Thinking of meaningful names for your variables and methods is quite time-consuming. 
    /// </summary>
    ///
    /// <param name="args"></param>
    int daysToAppocalypse;//Good
    int d;//bad

    /// <summary>
    /// Use Camel/Pascal Case Notation
    /// Basically, the first letter of the first word of the variable will be in lower case, 
    /// and the first letter of every other word that follows should be in upper case.
    /// </summary>
    /// <param name="args"></param>
    string firstName;//Good
    string FirstName;//bad

    /// <summary>
    /// Pascal Case Notation
    /// Here, the first letters of all your words should be in Upper Case. We use this kind of notation for naming Methods and Classes
    /// </summary>
    /// <param name="args"></param>
    
    //Bad
    class program
{
    static void main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
//Good
    class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}


/// <summary>
/// Pay attention to Formatting
/// Formatting your code improves code readability. Tabs over Spaces
/// </summary>
/// <param name="args"></param>
/// 
//Good
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
//Bad
class Program
{
    static void Main(string[] args)
    {Console.WriteLine("Hello World!");}
}


/// <summary>
/// Avoid Magic Strings/Numbers
///  Magic Strings are strings that are directly specified within the application
///  code which has a direct impact on the application behavior. In other words, do not use hardcoded strings or values in an application.
/// </summary>
/// <param name="args"></param>
/// 
//Good
const string ADMIN_ROLE = "Admin"
if(userRole == ADMIN_ROLE )
{
    //logic here
}
//Bad
if (userRole == "Admin")
{
    //logic here
}

/// <summary>
/// Use Method Chaining
/// This is a common technique used extensively in the default generated codes by Microsoft. 
/// </summary>
/// <param name="args"></param>
/// 
//Good
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
//Bad
public StudentFluent SomeMethod()
{
    return new StudentFluent().AddName("Mukesh Murugan").AddAge(25);
}


/// <summary>
/// Don’t use ‘throw ex’ in the catch block
/// You really don’t want to just ‘throw ex’ the exception after catching it and lose the stack trace data. Just use ‘throw’. 
/// By using this, you would be able to store the stack trace as well, which is kind of vital for diagnostics purposes.
/// </summary>
/// <param name="args"></param>
///
//Good
try
{
    // Do something..
}
catch (Exception ex)
{
    throw;
}
//Bad
try
{
    // Do something..
}
catch (Exception ex)
{
    throw ex;
}

/// <summary>
/// Use Ternary Operator
/// Consider the following example. I am sure that many of you still follow this practice.
/// </summary>
/// <param name="args"></param>
/// 
//Good
public string SomeMethod(int value)
{
    return value == 10 ? "Value is 10" : "Value is not 10";
}
//Bad
public string SomeMethod(int value)
{
    if (value == 10)
    {
        return "Value is 10";
    }
    else
    {
        return "Value is not 10";
    }
}



/// <summary>
/// Use Null Coalescing Operator
/// Similarly, we have yet another operator that can come in handy while you do null checks. ?? operator is known as Null Coalescing Operator in C#.
/// </summary>
/// <param name="args"></param>
/// 
//Good
public Student SomeMethod(Student student)
{
    return student ?? new Student() { Name = "Mukesh Murugan" };
}
//Bad
public Student SomeMethod(Student student)
{
    if (student != null)
    {
        return student;
    }
    else
    {
        return new Student() { Name = "Mukesh Murugan" };
    }
}


/// <summary>
/// Prefer String Interpolation
/// Everytime you want to add dynamic values to strings,we preffered Composite formatting or simply adding them with a plus operator.
/// </summary>
/// <param name="args"></param>
/// 
//Good
public string SomeMethod(Student student)
{
    return $"Student Name is {student.Name}. Age is {student.Age}";
}
//Bad
public string SomeMethod(Student student)
{
    return "Student Name is " + student.Name + ". Age is " + student.Age;
}


/// <summary>
/// Use Expression Bodied Methods
/// Such methods are used in scenarios where the method body is much smaller than even the method definition itself.
/// Why waste Brackets and lines of code, right? 
/// Here is how you would write a Expression Bodied Method.
/// </summary>
/// <param name="args"></param>
/// 
//Good
public string Message() => "Hello World!";


/// <summary>
/// Avoid Too Many Parameters
/// Too many parameters is always a nightmare. If you tend to have more than 3 parameter inputs to any method,
/// why not wrap it into a request object or something and then pass? 
/// </summary>
/// <param name="args"></param>
/// 
//Good
public Student SomeMethod(Student student)
{
    return student;
}
//Bad
public Student SomeMethod(string name, string city, int age, string section, DateTime dateOfBirth)
{
    return new Student()
    {
        Age = age,
        Name = name,
        //Other parameters too
    };
}

/// <summary>
/// Don’t ignore caught errors
/// This is something I kept on doing. There is a good chance that many of you too do this. We add a try catch block and just ignore the error handling, right?
/// It’s a good practice to handle such errors and log it to a table or disk.
/// </summary>
/// <param name="args"></param>
/// 
//Good
public void SomeMethod()
{
    try
    {
        DoSomething();
    }
    catch (Exception ex)
    {
        LogItSomewhere(ex);
    }
}
//Bad
public void SomeMethod()
{
    try
    {
        DoSomething();
    }
    catch
    {

    }
}

/// <summary>
/// Avoid passing many parameters to function. If you have more than 4-5 parameters use class or structure to pass it.
/// </summary>
/// <param name="args"></param>
/// 
//Good
public void UpdateAddress(Address address) { }
//Bad
public void UpdateAddress(int addressId, string country, string state, string phoneNumber, string pinCode, string address1, string address2) { }


    /// <summary>
    /// Error message to end use should be user friendly and self-explanatory but log the actual exception details using logger.
    /// Create constants for this and use them in application.
    /// </summary>
    /// <param name="args"></param>
    /// 
    //Good “Error occurred while connecting to database. Please contact administrator.” “Your session has been expired. Please login again.” 
    //Bad “Error in Application.”  
“There is an error in application.”  
}
