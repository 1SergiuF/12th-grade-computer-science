#include <vector>
#include <iostream>
#include <cmath>
#include <utility>
using namespace std;

typedef vector<int> VI;
typedef vector<VI> VVI;
typedef vector<pair<int, int>> VP;
typedef vector<VP> VVP;
typedef vector<bool> VB;

const int LOG = 25;
int n, q;
int N;
VVP G;
VI E;
VI niv;
VI pozE;
VVI rmq;
VP queries;
VP tati;
VB vb;
int S;

void CitesteDate();
inline void DFS(int x, int nv);
inline void RMQ();
inline int LCA(int x, int y);
inline int LCA_Sum(int x, int y);
inline void DfsSub(int nod, VI& vsub);

int main()
{
    CitesteDate();
    DFS(1, 1);
    RMQ();

    VI du;
    VI dv;

    for (auto const& q : queries)
    {
        du.clear();
        dv.clear();
        S = 0;

        int u = q.first;
        int v = q.second;

        DfsSub(u, du);
        DfsSub(v, dv);

        for (int const& nod_u : du)
            for (int const& nod_v : dv)
                S += LCA_Sum(nod_u, nod_v) + LCA_Sum(nod_v, nod_u);

        cout << S << '\n';
    }

    return 0;
}

inline int LCA_Sum(int x, int y)
{   
    if (x == LCA(x, y)) return 0;

    return LCA_Sum(tati[x].first, LCA(x, y)) + tati[x].second;
}

inline void DfsSub(int nod, VI& vsub)
{
    vb[nod] = true;
    vsub.push_back(nod);

    for (auto vp : G[nod])
        if (!vb[vp.first])
            DfsSub(vp.first, vsub);

    vb[nod] = false;
}

inline int LCA(int x, int y)
{
	int px = pozE[x];
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

inline void RMQ()
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

inline void DFS(int x, int nv)
{
    E[++N] = x;
    niv[N] = nv;
    pozE[x] = N;

    for (auto y : G[x])
    {
        DFS(y.first, nv + 1);
        E[++N] = x;
        niv[N] = nv;
    }
}

void CitesteDate()
{
    cin >> n >> q;
    E = niv = VI(2 * n);
    pozE = VI(n + 1);
    rmq = VVI(LOG, VI(2 * n));
    tati = VP(n + 1);
    G = VVP(n + 1);
    vb = VB(n + 1);

    for (int nod = 2, tata, cost; nod <= n; ++nod)
    {
        cin >> tata >> cost;
        tati[nod] = std::make_pair(tata, cost);
        G[tata].emplace_back(nod, cost);
    }

    for (int i = 1, x, y; i <= q; ++i)
    {
        cin >> x >> y;
        queries.emplace_back(x, y);
    }
}