/*
1.1What are the six combinations of access modifier keywords and what do they do?
public, protected, internal, private, protected internal, private protected.

 
1.2 What is the difference between the static, const, and readonly keywords when applied to
a type member?
the const is the member is const value.
static is the member is store on heap, and you can be change in whole local area.
readonly means the struct can not modify.
  
1.3 What does a constructor do?
When you create an instance. the constructor will copy the object for the instance

1.4 Why is the partial keyword useful?
it use to split the functionality of methods, interfaces, or structure into multiple files.

1.5 What is a tuple?
it is a data type, and is like list or array..
 
 1.6 What does the C# record keyword do? 
it is a referenct type and use fordata model can not be change
 
 1.7 What does overloading and overriding mean?
overloading means there are several the constructor.
overriting means there are several version methods in different class.
 
 1.8 what is the difference between a field and a property? 
field always private and accessed via get and set properities.

1.9 How do you make a method parameter optional?
give a default value 

1.10 What is an interface and how is it different from abstract class?
interface has methods, properties, but inferface will contain only the declaration.
interface only has a declaration part.
abstract has declaration and definition part.
interface doesn't have  constructor.
abstract has constructor.
a class can use multiple interface.
a class can only use one abstract class.
abstract can contain static members.
interface does not contain static members.

1.11 What accessibility level are members of an interface?
The default is public, but you can declare for any level.

1.12 True/False. Polymorphism allows derived classes to provide different implementations
of the same method.
Answer: True. The polymorphisa allows the derived class to overriding the method.

1.13 The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
Answer: True. It means the derived class modified the method for their own class.

1.14 True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
Answer: True. The new keyword is use to create a new method in a derived class.

1.15 True/False. Abstract methods can be used in a normal (non-abstract) class. 
Answer. False. The Abstact methods only can be use Abstract class or interface.

1.16. True/False. Normal (non-abstract) methods can be used in an abstract class.
True. The abstract class can contain both abstract method and concreate method.

1.17 True/False. Derived classes can override methods that were virtual in the base class.
True. The derived class can override methods that were virtual in the base class, but it is option for virtual method.

1.18. True/False. Derived classes can override methods that were abstract in the base class.
True. The derived class can override methods that were abstract in the bbass class, but it is mandatory. 
It means the derived must override the abstract methods.

1.19 True/False. In a derived class, you can override a method that was neither virtual non abstract in the
base class.
False. The dervied class only can override a method that was either virtual or abstract in base class.

1.20.True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.
False. A class that implements an interface have to provide an implementation for all of the members of the interface.

1.21 True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.
True.

1.22 True/False. A class can have more than one base class.
False. in C# we can only have sign inheritance.

1.23 True/False. A class can implement more than one interface.
True.

 */
