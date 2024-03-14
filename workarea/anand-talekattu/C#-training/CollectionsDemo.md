# Arrays
## declare an Array
General Syntax: <data type>[] VariableName = new <data type>[size of the array];<br>
Example: int[] A = new int[5];<br>
Here we have created an array with the name A and with a size of 5. So, we can store 5 values with the same name A. It will allocate memory for 5 integers. These all 5 are types of int. All these 5 integers are side by side or contiguous.

## Declare and Initialize an Array in the Same Statement
int[] A = { 1, 2, 3, 4, 5 };<br>

 when we declare an array like int[] n = new int[3];, we need to assign values to it separately. Because int[] n = new int[3]; will allocate space for 3 integers in the heap memory but there are no values in that space. To initialize it, assign a value to each of the elements of the array using its index position as shown below.<br>
 n[0]=4;<br>
 n[1]=3;<br>
 n[2]=2;<br>

 - Since the arrays in C# are derived from the System.Array class which implements the IEnumerable, so we can use the for-each loop to iterate on arrays in C#.
 -  Using a new keyword, it is mandatory to specify the size and if you are initializing the array using the argument values, then based on the number of arguments, it will decide the size.
 - We cannot assign values to array elements directly outside of a method or a constructor.