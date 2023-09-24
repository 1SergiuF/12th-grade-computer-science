#include <iostream>

int main()
{
    int n;
    std::cin >> n;

    try
    {
        if (n < 0) throw "numarul este negativ !\n";

        std::cout << "Ultima instructiune din try\n";
    }
    catch(int ex)
    {
        std::cout << ex;
    }
    catch(const char* ex)
    {
        std::cout << ex;
    }
    catch(...)  // prinde orice exceptie
    {
        std::cout << "Aici se prinde orice obiect de tip exceptie!\n";
    }

    std::cout << "Ultima instructiune din program";
    
}