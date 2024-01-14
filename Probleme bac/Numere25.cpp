#include <fstream>
using namespace std;

ifstream fin("numere25.in");
ofstream fout("numere25.out");

int main()
{
    int x;
    int cnt = 0;
    bool ok = false;

    int n;
    fin >> n;

    while (fin >> x)
    {
        if (x - cnt >= 2)
        {
            ok = true;
            for (int i = cnt + 1; i < x; ++i)
                fout << i << ' ';
        }

        cnt = x;
    }

    if (ok)
    {
        for (int i = cnt + 1; i <= n; ++i)
            fout << i << ' ';
    }
    else
        fout << "Nu exista";

    return 0;
}