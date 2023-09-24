// NUMAI C++20
#include <iostream>

void Print()
{
    return;
}

// Types = Template Parameter Pack
template<class T>
void Print(T first, auto...args)  // Template Argumnt pack
{
    // sizeof ...(Types) returneaza numarul de tipuri din pachet

    std::cout << sizeof...(Types) << ' ';
    Print(args...);  // Pack Expantion (expandarea)
}

int main()
{
    Print(12, "String", 'c', 13.4);
}