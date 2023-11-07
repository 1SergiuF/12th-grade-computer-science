#include <iostream>
using namespace std;

int a[101][101];
int n, m;
int vmax = -1, imax, jmax;
bool v[101][101];

void CitesteDate()
{
    cin >> n >> m;

    for (int i = 1; i <= n; ++i)
        for (int j = 1; j <= m; ++j)
            cin >> a[i][j];
}

bool Ok(int i, int j)
{
    if (i < 1 || i > n || j < 1 || j > m)
        return false;

    if (v[i][j]) return false;

    return true;
}

void Fill(int i, int j)
{
    if (!Ok(i, j)) return;
    v[i][j] = true;

    int sum = a[i][j] + a[i - 1][j] + a[i][j + 1] + a[i + 1][j] + a[i][j - 1];

    if (vmax < sum)
    {
        vmax = sum;
        imax = i;
        jmax = j;
    }

    Fill(i - 1, j);
    Fill(i, j + 1);
    Fill(i + 1, j);
    Fill(i, j - 1);
}

int main()
{
    CitesteDate();

    for (int i = 1; i <= n; ++i)
        for (int j = 1; j <= m; ++j)
            Fill(i, j);

    cout << imax << ' ' << jmax;
    return 0;
}