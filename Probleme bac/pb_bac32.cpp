#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
    int primul = 0; // primul termen din sir
    bool citit = false; // verificam daca am citit primul element
    int nr = 0; // nr. numerelor din sir strict mai mici decat primul element

    int x; // valorile citite
    while (fin >> x)
    {
        if (citit == false) // am gasit primul element
        {
            citit = true;
            primul = x;
        }

        if (citit == true && x < primul)
            nr++;   // daca am gasit un numar strict mai mic decat primul, incrementam contorul
    }

    cout << nr + 1; // pozitia minima pe care o poate ocupa primul termen in sirul
                    // ordonat crescator este numarul de valori strict mai mici
                    // decat el + 1

    return 0;
}