#include <fstream>
using namespace std;

ifstream fin("progresie3.in");
ofstream fout("progresie3.out");

const int N = 1001;
int a[N];
int c[N];
int x;
int r;
int cnt = 1;
bool ok = true;

int main()
{   
    while (fin >> x)
        c[x] = 1;

    for (int i = 1; i < N; ++i)
        if (c[i])
            a[cnt++] = i;

    r = a[2] - a[1];
    for (int i = 3; i < cnt; ++i)
        if (a[i] - a[i - 1] != r)
        {
            ok = false;
            break;
        }

    if (ok) fout << r;
    else fout << "NU";

    return 0;
}