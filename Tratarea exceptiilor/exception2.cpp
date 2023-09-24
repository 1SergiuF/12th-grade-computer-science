/*
    Obiectul de tip exceptie se arunca prin valoare
    si se prinde prin referinta
    "Throw by value, catch by reference"
*/

#include <iostream>
#include <exception>

class DivByZero : public std::exception {
public:
    virtual const char* what() const noexcept override
    {
        return "Exceptie Division By Zero: numitorul este zero!\n";
    }
};

int main()
{
    int a, b;
    std::cin >> a >> b;

    try
    {
        if (b == 0) throw DivByZero();

        std::cout << a / b << '\n';
    }
    catch(DivByZero& ex)
    {
        std::cout << ex.what() << '\n';
    }

    std::cout << "Ultima instructiune din program";
}