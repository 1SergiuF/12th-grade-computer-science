#include <iostream>

void Print()
{
    return;
}

// Types = Template Parameter Pack
template<class T, class...Types>
void Print(T first, Types...args)  // Template Argumnt pack
{
    // sizeof ...(Types) returneaza numarul de tipuri din pachet

    std::cout << sizeof...(Types) << ' ';
    Print(args...);  // Pack Expantion (expandarea)
}

int main()
{
    Print(12, "String", 'c', 13.4);
}