#include <iostream>

template<class T>
void Print(T t)
{
    std::cout << __PRETTY_FUNCTION__ << '\n';
    return;
}

// Types = Template Parameter Pack
template<class T, class...Types>
void Print(T first, Types...args)  // Template Argumnt pack
{
    std::cout << __PRETTY_FUNCTION__ << '\n';
    Print(args...);
}

int main()
{
    Print(12, "String", 'c', 13.4);
}