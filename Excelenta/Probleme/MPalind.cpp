#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("mpalind.in");
ofstream fout("mpalind.out");

const int MOD = 666013;
const int N = 1001;

int n, m;
bool pal[N][N];
int dp[N][N]; // nr. de moduri in care sirul c[i...j] se poate imparti in secvente palindrom
char c[N];

void DinamicaPalindrom();
bool Palindrom(int i, int j);

int main()
{
    fin.getline(c + 1, N);
    n = strlen(c + 1);

    fin >> m;
    int x, y;

    for (int i = 1; i <= n; ++i)
        for (int j = i; j <= n; ++j)
            pal[i][j] = Palindrom(i, j);
    
    DinamicaPalindrom();
    while (m--)
    {
        fin >> x >> y;
        fout << dp[x][y] << '\n';
    }

    return 0;
}

void DinamicaPalindrom()
{
    for (int i = 1; i <= n; ++i)
        dp[i][i] = 1;

    for (int l = 2; l <= n; ++l)
    {
        for (int i = 1; i <= n - l + 1; ++i)
        {
            int j = i + l - 1;
            dp[i][j] += pal[i][j];

            for (int p = i; p <= j; ++p)
                if (pal[i][p])
                    dp[i][j] = (dp[i][j] % MOD + dp[p + 1][j] % MOD) % MOD;
        }
    }
}

bool Palindrom(int i, int j)
{
    while (i < j)
    {
        if (c[i] != c[j])
            return false;
        i++;
        j--;
    }

    return true;
}