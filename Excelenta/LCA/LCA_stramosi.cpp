/* Complexitate:
 * O(n * log(n)) - Preprocesare
 * O(log(n)) / query
 *
 *
 */
#include <fstream>
#include <cmath>
using namespace std;

ifstream fin("lca.in");
ofstream fout("lca.out");

const int NMAX = 100005;

int str[20][NMAX];  // str[i][j] = stramosul al 2^i - lea al nodului j
int niv[NMAX];
int lg[NMAX];

int Stramos(int nod, int n);  // returneaza al n-lea stramos al lui nod
int LCA(int x, int y);

int main()
{
    int n, m;
    fin >> n >> m;
	int tata;
	for (int i = 2; i <= n; ++i)
	{
		fin >> tata;
		str[0][i] = tata;
		niv[i] = niv[tata] + 1;
		lg[i] = lg[i / 2] + 1;
	}
//    int imax = lg(n);
	for (int i = 1; (1 << i) <= n; ++i)
		for (int j = 1; j <= n; ++j)
			str[i][j] = str[i - 1][str[i - 1][j]];

	int x, y;
    for (int i = 1; i <= m; ++i)
    {
        fin >> x >> y;
		fout << LCA(x, y) << '\n';
    }
    return 0;
}

int LCA(int x, int y)
{
	// x trebuie sa aiba adancimea cea mai mare
	if (niv[x] < niv[y])
		swap(x, y);

    int dif = niv[x] - niv[y];
    // aducem la acelasi nivel x si y
    x = Stramos(x, dif);

    if (x == y) return x;

    for (int i = lg[niv[x]]; i >= 0; --i)
        if (str[i][x] && str[i][x] != str[i][y])
        {
            x = str[i][x];
            y = str[i][y];
        }

    return str[0][x];
}

/// returneaza al n-lea stramos al lui n
int Stramos(int nod, int n)
{
    int i = 0;
    while (n)
    {
        if (n & 1)
            nod = str[i][nod];
        i++;
        n >>= 1;
    }
    return nod;
}

