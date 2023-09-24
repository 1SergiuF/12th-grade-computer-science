/*
    Obiectul de tip exceptie se arunca prin valoare
    si se prinde prin referinta
    "Throw by value, catch by reference"
*/

#include <iostream>
#include <vector>
#include <exception>

class Obj {
public:
    Obj(int n = int()) : n {n}
    {
        std::cout << "Construiesc obiectul " << n << '\n';
    }

    ~Obj()
    {
        std::cout << "Distrug obiectul " << n << '\n';
    }

private:
    int n;
};

void F2()
{
    Obj o2(2);
    Obj o3(3);

    std::vector<int> v(10);

    try
    {
        std::cout << v.at(20);  // din at() se arunca o exceptie de tip out_of_range
    }
    catch(std::exception& ex)
    {
        throw;  // rethrowing exception
    }

    std::cout << "Ultima instructiune din F2()\n";
}

void F1()
{
    Obj o1(1);

    try
    {
        F2();
    }
    catch(std::exception& ex)
    {
        throw;  // rethrowing
    }
    
    std::cout << "Ultima instructiune din F1()\n";
}

/* 
    stack unwinding = obiectele construite intr-o functie care
    arunca exceptii se distrug automat
*/

int main()
{
    try
    {
        F1();
    }
    catch(std::out_of_range& ex)
    {
        //std::cout << ex.what();
        std::cout << "Exceptia este prinsa si tratata in main()\n";
    }
}