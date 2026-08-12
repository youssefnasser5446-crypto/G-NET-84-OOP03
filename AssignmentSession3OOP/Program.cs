namespace AssignmentSession3OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            /*
              a)  What is the difference between Method Overloading and Method Overriding?

            ans => 1] Method overloading occurs at compile time, whereas method overriding occurs at runtime.
                   2] Method overloading same name but different parameter list, but overriding must same signature.

            b)  What is the difference between Static Binding and Dynamic Binding?

                 ans => Static binding is fast because it is executed at compile-time; 
            the reference determines which method is called. In contrast,
            dynamic binding is slower than static binding because the call occurs at runtime,
            and the object determines which method is called.  

             */

            #endregion
            #region Question02

            /*
             a)  What is the purpose of the sealed keyword when applied to a class?

            ans => A sealed class prevents other classes from inheriting from it

            b)  What is the difference between a sealed class and a sealed method?

            ans=> A `sealed` class prevents inheritance, effectively protecting the class itself. 
            However, a `sealed` method must be used in conjunction with the `override` keyword; 
            this means the method must be inherited and overridden before it can be marked as `sealed`,
            thereby protecting that specific method.

            c)  Can a sealed method be overridden? Why?

            ans => No, because the sealed keyword prevents further overriding of the method in derived classes

             */
            #endregion
        }
    }
}
