#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("interclasm.in");
ofstream fout("interclasm.out");

int x;
int n, m;
int a[100001];
int b[100001];
int c[200001];

int main()
{
    fin >> x;
    fin >> n;
    for (int i = 1; i <= n; ++i)
        fin >> a[i];

    fin >> m;
    for (int j = 1; j <= m; ++j)
        fin >> b[j];

    int i = 1, j = 1;
    int k = 0;

    while (i <= n && j <= m)
    {
        if (a[i] < b[j])
        {
            if (a[i] % x == 0)
                c[++k] = a[i];
            i++;
        }
        else
            if (a[i] > b[j])
            {
                if (b[j] % x == 0)
                    c[++k] = b[j];
                j++;
            }
        else
            i++, j++;
    }

    while (i <= n)
    {
        if (a[i] % x == 0)
            c[++k] = a[i];
        i++;
    }

    while (j <= m)
    {
        if (b[j] % x == 0)
            c[++k] = b[j];
        j++;
    }

    for (int i = 1; i <= k; ++i)
        fout << c[i] << ' ';

    return 0;
}