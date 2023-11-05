#include <fstream>
using namespace std;

ifstream fin("ciffrecv.in");
ofstream fout("ciffrecv.out");

int frecv[11];

int main()
{
    int x;
    while (fin >> x)
        ++frecv[x];

    for (int i = 7; i >= 1; i -= 2)
        if (frecv[i])
        {
            fout << i << ' ' << frecv[i];
            break;
        }

    return 0;
}