# DesignPatterns
# What are design patterns ?
Design patterns are industry defined patterns which are used for recurring modules where it saves time and effort if used in the proper way.
Using design patterns promotes the reusability and robustness of the code.
For example a singleton design pattern uses a single instance to be initiated every time.It would be helpful for the team to use this pattern for particular use case scenario.

# What is Gang of Four ?
In 1994, four authors Erich Gamma, Richard Helm, Ralph Johnson and John Vlissides published a book titled Design Patterns - Elements of Reusable Object-Oriented Software which initiated the concept of Design Pattern in Software development.

# Singleton Design Pattern
A singleton design pattern is used where we need the class to have a single instance and to be used at the first initialization only. In Singleton pattern only one object is created for the class and that object is shared across all the clients

# Singleton Vs Static Class Design Pattern 
SA Singleton can implement interfaces, inherit from other classes and allow inheritance. While a static class cannot inherit their instance members. So Singleton is more flexible than static classes and can maintain state.

# Factory Pattern 
Factory pattern, we create object without exposing the creation logic to the client and refer to newly created object using a common interface.

# Abstract Factory 
In Abstract Factory pattern an interface is responsible for creating a factory of related objects without explicitly specifying their classes. Each generated factory can give the objects as per the Factory pattern.

# Builder Pattern
Builder pattern builds a complex object using simple objects and using a step by step approach. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.

# Decorator Pattern
Decorator pattern allows a user to add new functionality to an existing object without altering its structure. This type of design pattern comes under structural pattern as this pattern acts as a wrapper to existing class.

# Factory Pattern 
Facade pattern hides the complexities of the system and provides an interface to the client using which the client can access the system. This type of design pattern comes under structural pattern as this pattern adds an interface to existing system to hide its complexities.


