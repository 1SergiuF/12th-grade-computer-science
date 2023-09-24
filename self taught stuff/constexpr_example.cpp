/*
    The constexpr specifier declares that it is possible to evaluate the value of the 
    function or variable at compile time. Such variables and functions can then be used 
    where only compile time constant expressions are allowed (provided that appropriate 
    function arguments are given).
*/

#include <iostream>

constexpr int multiply(int x, int y);
int main()
{
    int arr[multiply(2, 3)]; // not possible with a non-constexpr function
    arr[0] = 1;
    std::cout << arr[0];

    return 0;
}

constexpr int multiply(int x, int y)
{
    return x * y;
}