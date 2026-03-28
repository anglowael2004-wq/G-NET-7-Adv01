using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Numerics;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //What is a generic class? Why use generics?
            //A generic class is a class that can work with any data type. It allows you to create a class that can be used with different types without having to write separate code for each type. Generics provide type safety, code reusability, and improved performance by allowing you to define a class or method with a placeholder for the type it will operate on.

            #endregion
            #region Question 2
            //Write a generic class Container<T> with Add and Get methods.
            //class Container<T>
            //{
            // private T item;
            // public void Add(T item)
            // {item=value}
            //public T Get()
            //{ return item;}
            //}
            #endregion
            #region Question 3
            //What are multiple type parameters? Write Pair<TKey, TValue>
            //class Pair<TKey, TValue>{
            // public TKey Key { get; set; }
            // public TValue Value { get; set; }
            //}
            #endregion
            #region Question 4
            //What is a generic method? Write Swap<T> method.
            //void Swap<T>(ref T a, ref T b)
            //{
            // t T temp = a
            //a = b;
            //b = temp;
            //}

            #endregion
            #region Question 5
            //Write a generic method FindMax<T> that finds maximum value
            //
            // class Program <T> where T : IComparable<T>
            //{
            // findMax<T>(T[] array)
            // { t T max = array[0];
            // foeach (T item in array)
            // { if (item.CompareTo(max) > 0)
            // { max = item; )
            // }
            //
            //}
            #endregion
            #region Question 6
            //What is a generic interface? Write IRepository<T>
            //interface IRepository<T>
            //{
            // void Add(T item);
            // T Get(int id);
            // string GetAll();
            //}
            #endregion
            #region Question 7
            //What is the 'struct' constraint? Write an example.
            //The 'struct' constraint in C# is used to specify that a type parameter must be a value type. This means that the type must be a struct, an enum, or a primitive type (like int, float, etc.). The 'struct' constraint ensures that the type parameter cannot be a reference type (like classes or interfaces).
            //class Example<T> where T : struct
            //{
            // 
            //}

            #endregion
            #region Question 8
            //What is the 'class' constraint? Write an example
            //The 'class' constraint
            //class reference type. This means that the type must be a class, an interface, or a delegate. The 'class' constraint
            // class Example<T> where T : class{}
            #endregion
            #region Question 9
            //What is the 'new()' constraint? Write an example.
            //The 'new()' constraint in C# is used to specify that a type parameter must have a public parameterless constructor. This means that the type must be able to be instantiated without any arguments. The 'new()' constraint is often used in combination with other constraints to ensure that the type can be created and used within the generic class or method.
            // class Example<T> where T : new()
            #endregion
            #region Question 10
            //What is the interface constraint? Write an example.
            //The interface constraint in C# is used to specify that a type parameter must implement a specific interface. This means that the type must provide an implementation for the members defined in the interface. The interface constraint is useful when you want to ensure that the type parameter has certain capabilities or behaviors defined by the interface.
            // class Example<T> where T : IComparable<T>
            #endregion
            #region Question 11
            //What is the base class constraint? Write an example.
            //The base class constraint in C# is used to specify that a type parameter must inherit from a specific base class. This means that the type must be a subclass of the specified base class. The base class constraint is useful when you want to ensure that the type parameter has certain properties, methods, or behaviors defined in the base class.
            //class test{}
            //class Example<T> where T : test{}

            #endregion
            #region Question 12
            //How do you apply multiple constraints? Write an example.
            //You can apply multiple constraints to a type parameter by separating them with commas. For example, if you want to specify that a type parameter must be a reference type and must implement a specific interface, you can use the following syntax:
            //class Example<T> where T : class, IComparable<T>
            #endregion
            #region Question 13
            //What does the 'default' keyword do in generics ?
            //The 'default' keyword in C# is used to specify the default value of a type parameter in generics. When you use 'default(T)', it returns the default value for the type T. For reference types, the default value is null, and for value types, it is the zero-initialized value (e.g., 0 for int, false for bool, etc.). The 'default' keyword is useful when you want to initialize a variable of a generic type without knowing the specific type at compile time.

            #endregion
            #region Question 14
            //Write a SafeList<T> that returns default when the index is invalid.
            //class SafeList<T>
            //{
            // private List<T> list = new List<T>();
            //private T defaultValue;
            // public SafeList(T defaultValue)
            // { this.defaultValue = defaultValue; }
            // public void Add(T item)
            // { list.Add(item); }
            //}
            #endregion
            #region Question 15
            //What is covariance? Explain the 'out' keyword.
            //Covariance in C# refers to the ability to use a more derived type than originally specified. The 'out' keyword is used in generic type parameters to indicate that the type parameter is covariant. This means that you can use a more derived type when assigning or returning values of that type parameter. For example, if you have an interface IProducer<out T>, you can assign an instance of IProducer<Derived> to a variable of type IProducer<Base>, where Derived is a subclass of Base.
            //interface IProducer<out T>
            #endregion
            #region Question 16
            //What is contravariance? Explain the 'in' keyword.
            //Contravariance in C# refers to the ability to use a less derived type than originally specified. The 'in' keyword is used in generic type parameters to indicate that the type parameter is contravariant. This means that you can use a less derived type when assigning or accepting values of that type parameter. For example, if you have an interface IConsumer<in T>, you can assign an instance of IConsumer<Base> to a variable of type IConsumer<Derived>, where Derived is a subclass of Base.
            //interface IConsumer<in T>
            #endregion
            #region Question 17
            //What is the difference between covariance and contravariance?
            //Covariance allows you to use a more derived type than originally specified, while contravariance allows you to use a less derived type than originally specified. Covariance is indicated by the 'out' keyword, while contravariance is indicated by the 'in' keyword. In covariance, you can assign an instance of a more derived type to a variable of a less derived type, while in contravariance, you can assign an instance of a less derived type to a variable of a more derived type.
            //
            #endregion
            #region Question 18
            //How do static members work in generic types ?
            //Static members in generic types are shared across all instances of the generic type, regardless of the type parameter. This means that if you have a static member in a generic class, it will be the same for all instances of that class, regardless
            // of the type parameter used. For example, if you have a static field in a generic class, it will be shared among all instances of that class, and changes to that field will affect all instances. Static members in generic types are not specific to any particular type parameter and are accessed using the generic type name rather than an instance of the class.
            // class Example<T>
            //{
            // public static int StaticField;
            //}
            #endregion
            #region Question 19
            //How can you inherit from a generic class
            //class Base<T>{}
            //class Derived <T>: Base<int>
            #endregion
            #region Question 20
            //Complete Exercise -Create a generic Cache<TKey, TValue> with Add, Get, Remove, Contains, and expiration support.
            //class Cache<TKey, TValue>
            //{
            // private Dictionary<TKey, (TValue)> data= new Dictionary<TKey, TValue>();
            // public void Add(TKey key, TValue value){
            // data[key] = value;
            // }
            // public TValue Get(TKey key){
            // return data[key];
            // return default(TValue);
            // }
            //public void Remove(TKey key){
            // data.Remove(key);}
            //public bool Contains(TKey key){
            // return data.ContainsKey(key);
            //}


            //}
            #endregion
            Console.WriteLine();
        }
    }
}
