#include <fstream>
using namespace std;

ifstream fin("bac.in");
ofstream fout("bac.out");

int max1 = -1, max2 = -1;
bool f[1000001];

int main()
{
    int n;
    while (fin >> n)
    {
        if (n > 9 && n < 100)
        {
            f[n] = true;
            if (max1 < n)
                max1 = n;
            
            if (max2 < n && n < max1)
                max2 = n;
        }
    }

    int cnt = 0;
    for (int i = 98; (i % 10 != i % 100) && i >= 10; --i)
        if (!f[i])
        {
            ++cnt;
            fout << i << ' ';

            if (cnt == 2)
                break;
        }

    return 0;
}