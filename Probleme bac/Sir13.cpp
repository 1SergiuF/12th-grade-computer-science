#include <fstream>
using namespace std;

ifstream fin("sir13.in");
ofstream fout("sir13.out");

int main()
{
    bool ok = true;
    int x;
    int impar = 1e9 + 1;
    int par = 0;

    while (fin >> x)
    {
        if (x % 2 == 1)
        {
            if (impar >= x)
                impar = x;
            else
                ok = false;
        }

        else if (x % 2 == 0)
        {
            if (par <= x)
                par = x;
            else
                ok = false;
        }
    }

    if (!ok) fout << "NU";
    else fout << "DA";

    return 0;
}