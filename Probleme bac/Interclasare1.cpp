#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("interclasare1.in");
ofstream fout("interclasare1.out");

int n, m;
int a[100001];
int b[100001];
int c[200001];

int main()
{
    fin >> n;
    for (int i = 1; i <= n; ++i)
        fin >> a[i];

    fin >> m;
    for (int i = 1; i <= m; ++i)
        fin >> b[i];

    int i = 1, j = 1;
    int k = 0;

    while (i <= n && j <= m)
    {
        if (a[i] < b[j])
            c[++k] = a[i], i++;
        else
            if (a[i] > b[j])
                c[++k] = b[j], j++;

        else if (a[i] == b[j])
            c[++k] = b[j], i++, j++;
    }

    while (i <= n)
        c[++k] = a[i], i++;

    while (j <= m)
        c[++k] = b[j], j++;


    for (int i = 1; i <= k; ++i)
    {   
        fout << c[i] << ' ';

        if (i % 10 == 0)
            fout << '\n';
    }

    return 0;
}