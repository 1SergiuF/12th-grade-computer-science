#include <fstream>
using namespace std;

ifstream fin("bac.txt");
ofstream fout("bac.out");

int main()
{
    int n;
    int fpref[100] {0}, fsuf[100] {0}, cnt = 0;

    while (fin >> n)
    {
        if (n >= 100)
        {
            int suf = n % 100;
            int pref = n;

            while (pref >= 100)
                pref /= 10;

            ++fpref[pref];
            ++fsuf[suf];
        }
    }

    for (int i = 10; i <= 99; ++i)
        if (fsuf[i] != 0 && fsuf[i] == fpref[i])
            ++cnt;

    fout << cnt;

    return 0;
}