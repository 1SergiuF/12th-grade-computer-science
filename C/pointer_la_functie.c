#include <stdio.h>

// PF este tipul pointer spre functii cu semnatura (int, int)
// si tipul de return int

typedef int (*PF)(int, int);

int Suma(int a, int b)
{
    return a + b;
}

int Produs(int a, int b)
{
    return a * b;
}

void Print(PF func, int a, int b)
{
    printf("%d\n", func(a, b));
}

int main()
{
    Print(Suma, 10, 20);
    Print(Produs, 10, 20);
}