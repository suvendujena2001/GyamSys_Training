# Arrays
## declare an Array
General Syntax: `<data type>[] VariableName = new <data type>[size of the array];`<br>
Example: `int[] A = new int[5];`<br>
Here we have created an array with the name A and with a size of 5. So, we can store 5 values with the same name A. It will allocate memory for 5 integers. These all 5 are types of int. All these 5 integers are side by side or contiguous.

## Declare and Initialize an Array in the Same Statement
`int[] A = { 1, 2, 3, 4, 5 };`<br>

 when we declare an array like int[] n = new int[3];, we need to assign values to it separately. Because `int[] n = new int[3];` will allocate space for 3 integers in the heap memory but there are no values in that space. To initialize it, assign a value to each of the elements of the array using its index position as shown below.<br>
 n[0]=4;<br>
 n[1]=3;<br>
 n[2]=2;<br>

 - Since the arrays in C# are derived from the System.Array class which implements the IEnumerable, so we can use the for-each loop to iterate on arrays in C#.
 -  Using a new keyword, it is mandatory to specify the size and if you are initializing the array using the argument values, then based on the number of arguments, it will decide the size.
 - We cannot assign values to array elements directly outside of a method or a constructor.

 ## 2D Array
 The arrays which store the elements in the form of rows and columns are called Two-Dimensional Array in C#. The two-dimensional array which is also called a multidimensional array is of two types in C#. They are as follows

Rectangular Array: The array whose rows and columns are equal is called a rectangular array
Jagged Array: The array whose rows and columns are not equal is called a jagged array

## Rectangular 2D Arrays in C#:
Element in the 2D array is stored in the matrix form. The first index shows the row of the matrix and the second index shows the column of the matrix.<br>
Example:
```cs
 int[,] matrix = new int[3,4];
 int[,] arr;
 arr=new int[3,4];
```
Memory Locations are allocated continuously side by side. So basically, it will create a single dimension array of size 12, where the first four locations are used as the first rows, the second four locations are used as the second row and the rest four locations are used as the third row.

## Initializing a 2Dimensional Array in C#:
declaration and initialization of a 2D Array<br>
`int[,] A = {{2, 5, 9},{6, 9, 15}};`<br>
This is the declaration + initialization of a 2Dimensinal array in C#. Here 2,5,9 is the 1st row and 6,9,15 is the 2nd row. The other way of initializing it is,<br>
```cs
int[,] A = new int[2,3]
{
       {2, 5, 9},{6, 9, 15}
};

```

## Jagged Array in C#:
Here in the jagged array, the column size will differ from row to row. That means if the first row contains 5 columns, then the second row may contain 4 columns while the third row may contain 10 columns. 

Syntax:  `<type> [][] <name> = new <type> [rows][];`
Example:
`int [][] arr = new int[3][];`
//Or
`int [][] arr = {list of values};`

To declare a jagged array in C#, at the time of its declaration, we only need to specify the number of rows that you want in the array. For example
`int [][] arr = new int[4][];`

In the above array declaration, we are specifying that we want four rows in the array. Once you specify the number of rows that you want in the array, then you need to initialize each row with the number of columns by using a single-dimensional array as shown below.
`arr[0] = new int[5]; // we want five columns in the first row
arr[1] = new int[6]; // we want six columns in the first row
arr[2] = new int[4]; // we want four columns in the first row
arr[3] = new int[5]; // we want five columns in the first row`