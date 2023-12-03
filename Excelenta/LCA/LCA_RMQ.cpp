/* OK
 * LCA cu RMQ
 * Complexitate: O(n * log2(n)) - preprocesare
 *               O(1) / query
 */
#include <fstream>
#include <vector>
#include <cmath>
using namespace std;

using VI  = vector<int>;
using VVI = vector<VI>;
ifstream fin("lca.in");
ofstream fout("lca.out");

const int LOG = 25;
int n, m;
int N;     // N = 2 * n - 1 - lungimea turului Euler
VI E;      // nodurile parcurse in turul Euler
VI niv;    // niv[i] = nivelul in arbore al nodului E[i]
VI pozE;   // pozE[x] = poz primei aparitii a lui x in turul Euler
VVI rmq;   // rmq[i][j] = pozitia in sirul E a nodului cu nivel minim incepand cu pozitia j si de lungime 2^i
VVI G;

void CitesteArbore();
inline void DFS(int x, int h);
inline void RMQ();
inline int LCA(int x, int y);

int main()
{
    CitesteArbore();

    DFS(1, 1);
    RMQ();

	int x, y;
    while (m--)
	{
        fin >> x >> y;
		fout << LCA(x, y) << '\n';
    }
}

inline int LCA(int x, int y) // O(1)
{
	int px = pozE[x];    // px = pozitia lui x in sirul niv[] (in turul Euler)
	int py = pozE[y];
	if (px > py)
		swap(px, py);

	int k = log2(py - px + 1);
	int p1 = rmq[k][px];
	int p2 = rmq[k][py - (1 << k) + 1];

	if (niv[p1] < niv[p2])
		return E[p1];

	return E[p2];
}

inline void DFS(int x, int nv)
{
    E[++N] = x;
    niv[N] = nv;
    pozE[x] = N;

    for (int y : G[x])
    {
        DFS(y, nv + 1);
        E[++N] = x;
        niv[N] = nv;
    }
}

inline void RMQ() // O(N * log2(N))
{
	for (int i = 1; i <= N; ++i)
		rmq[0][i] = i;

	int p1, p2;
    for (int i = 1; (1 << i) <= N; ++i)
        for (int j = 1; j + (1 << i) <= N; ++j)
        {
			p1 = rmq[i - 1][j];
			p2 = rmq[i - 1][j + (1 << (i - 1))];

            if (niv[p1] < niv[p2])
                rmq[i][j] = p1;
            else
                rmq[i][j] = p2;
		}
}

void CitesteArbore()
{
	fin >> n >> m;
	E = VI(2 * n);
	niv = VI(2 * n);
	pozE = VI(n + 1);
	rmq = VVI(LOG, VI(2 * n));
	G = VVI(n + 1);
    for (int nod = 2, tata; nod <= n; ++nod)
    {
        fin >> tata;
        G[tata].push_back(nod);
    }
}