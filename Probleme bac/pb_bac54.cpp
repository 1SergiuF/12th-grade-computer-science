#include <iostream>
#include <fstream>
#include <algorithm>
using namespace std;

ifstream fin("bac.in");

int main()
{
    int x; // val citita
    bool gasit = false; // verif. daca am gasit primul element negativ
    int lsf = 1; // lungimea secv. care se sfarseste cu un nr. neg
    int linc = 1; // lungimea secv. care incepe cu un nr. neg

    while (fin >> x)
    {
        if (gasit == true)
            ++linc;
        else
        {
            if (x < 0)
                gasit = true;

            if (gasit == false)
                ++lsf;
        }
    }

    cout << max(lsf, linc);

    return 0;
}