// Using a Temporary Variable
int a = 500, b = 10;
int temp = a;  
a = b;        
b = temp;     
Console.WriteLine("Using a Temporary Variable a = {0} and b = {1}", a, b);

// Using Arithmetic Operations
int x = 500, y = 10;
x = x + y; 
x = x - y; 
y = x - y; 
Console.WriteLine("Using Arithmetic Operations x = {0} , y = {1}", x, y);

// Using XOR Bitwise Operation

int m = 500, n = 10;
m = m ^ n;
n = m ^ n; 
m = m ^ n; 
Console.WriteLine("Using XOR Bitwise Operation m = {0} , n =  {1}", m, n);

// Using C# 7.0 and Later Tuple Deconstruction
(int c, int d) = (500, 10);
(c, d) = (d, c); 
Console.WriteLine("Using C# 7.0 and Later Tuple Deconstruction c = {0} , d = {1}", c, d); 
