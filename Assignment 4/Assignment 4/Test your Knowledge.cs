/*
1.1 Describe the problem generics address.
it allows us to design classes and methods but defer the specification of type until the class or methods are declared and called.

1.2 How would you create a list of strings, using the generic List class?
List<T> Variable = new List<T>;

1.3 How many generic type parameters does the Dictionary class have?
There are two parameters. one for key, and one for value.

1.4 True/False. When a generic class has multiple type parameters, they must all match.
True.

1.5 What method is used to add items to a List object?
the methods are Add and AddRange to add items to a list object.

1.6 Name two methods that cause items to be removed from a List.
Remove, RemoveAt, RemoveAll, and RemoveRange

1.7 How do you indicate that a class has a generic type parameter?
Public/Private class ClassName<T>
{
some code
}

1.8 True/False. Generic classes can only have one generic type parameter.
False. A generic class can have multiple generic type parameter.

1.9 True/False. Generic type constraints limit what can be used for the generic type.
True. The generic type constrains tell the compiler what type parameters we can use for this method or class.

1.10 True/False. Constraints let you use the methods of the thing you are constraining to
True. Declaring those constraints means you can use the operations and method calls of the constraining type.

*/
