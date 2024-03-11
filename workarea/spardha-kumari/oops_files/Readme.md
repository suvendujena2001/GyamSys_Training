# C#
### this
In c# programming, this is a keyword that refers to the current instance of the class.
1. It can be used to refer current class instance variable. It is used if field names (instance variables) and parameter names are same, that is why both can be distinguish easily.
2. It can be used to pass current object as a parameter to another method.
3. It can be used to declare indexers.

### static
static belongs to class not the object.

static can be field, method, constructor, class, properties, operator and event.
**Indexers and destructors cannot be static.**

for static members, we dont need to create instance or object. we can access the static member by the class name . static member saves the memory because it willnot get memory each time when instance is created.
Instance field gets memory each tie whenever we create object, and in static field there is only one copy of static field created in the memory, it is shared to all the objects.
--used for common property of all object as rateOfInterest .

