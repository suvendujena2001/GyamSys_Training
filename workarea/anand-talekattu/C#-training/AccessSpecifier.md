## Type and Type Members in C#
In general classes, structs, enums, interfaces, and delegates are called types, and variables, properties, constructors, methods, etc. that normally reside within a type are called type members. The type members can have all 6 access specifiers whereas types can have only 2 (internal, public) Access Modifiers. By default, if we have not specified any type, then for type is going to be internal access specifier and for type members, it is going to be a private Access Specifier.

## Private Access Specifier or Modifier in C#:
When we declare a type member (variable, property, method, constructor, etc) as private, then we can access that member with the class only. From outside the class, we cannot access them.

So, the scope of the private member in C#.NET is as follows:

With the Class: YES<br>
Derived Class in Same Assembly: NO<br>
Non-Derived Class in Same Assembly: NO<br>
Derived Class in Other Assemblies: NO<br>
Non-Derived Class in Other Assemblies: NO<br>

## Public Access Specifiers or Access Modifiers in C#:
When we declare a type member (variable, property, method, constructor, etc) as public, then we can access that member from anywhere. That means there is no restriction for public members. 

So, the scope of the public member in C#.NET is as follows:

With the Class: YES<br>
Derived Class in Same Assembly: YES<br>
Non-Derived Class in Same Assembly: YES<br>
Derived Class in Other Assemblies: YES<br>
Non-Derived Class in Other Assemblies: YES<br>

## Protected Access Specifier or Access Modifier in C#:
Protected Members in C# are available within the containing type as well as to the types that are derived from the containing type. That means protected members are available within the parent class (i.e. the containing type) as well as to the child/derived classes (classes derived from the containing type). 

So, the scope of the protected members in C#.NET is as follows:

With the Class: YES<br>
Derived Class in Same Assembly: YES<br>
Non-Derived Class in Same Assembly: NO<br>
Derived Class in Other Assemblies: YES<br>
Non-Derived Class in Other Assemblies: NO<br>