#include <fstream>
using namespace std;

ifstream fin("nrlipsa.in");
ofstream fout("nrlipsa.out");

const int N = 1000;
bool frecv[N];

int main()
{
    int x;
    int cnt = 0;
    while (fin >> x)
    {
        if (x > 99 && x < 1000)
            frecv[x] = true;
    }

    for (int i = N - 1; i > 99; --i)
        if (!frecv[i])
        {
            ++cnt;
            fout << i << ' ';
            if (cnt == 2)
                break;
        }

    if (!cnt) fout << "NU";
    return 0;
}