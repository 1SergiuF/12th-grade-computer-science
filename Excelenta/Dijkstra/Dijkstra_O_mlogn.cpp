/* Alg lui Dijkstra
 * Complexitate: O(n^2)
 * Det distanta minima de la un nod ales drept sursa
 * la celelalte noduri din graf.
 *
 */

#include <fstream>
#include <vector>
#include <queue>
#include <algorithm>
#include <tuple>
using namespace std;

ifstream fin("dijkstra.in");
ofstream fout("dijkstra.out");

const int Inf = 0x3f3f3f3f;
using VI  = vector<int>;
using PI  = pair<int, int>;
using VP  = vector<PI>;
using VVP = vector<VP>;

VVP G;
VI d;

int n, m;

void ReadGraph();
void Dijkstra(int x, VI& d);  // x = nodul sursa
void WriteDist(VI& d);

int main()
{
    ReadGraph();
    Dijkstra(1, d);
    WriteDist(d);
    return 0;
}

void Dijkstra(int x, VI& d)  // x = nodul sursa
{
    priority_queue<PI, vector<PI>, greater<PI>> Q;
    d = VI(n + 1, Inf);
    d[x] = 0;
    Q.emplace(0, x);

    int y, w, dx;
    while (!Q.empty())
    {
        tie(dx, x) = Q.top();
        Q.pop();

        if (dx > d[x])  // daca x iese din coada pentru a doua oara
            continue;

        for (auto const& p : G[x])
        {
            tie(y, w) = p;
            if (d[y] > d[x] + w)
            {
                d[y] = d[x] + w;
                Q.emplace(d[y], y);
            }
        }
    }
}

void WriteDist(VI& d)
{
    for (int i = 2; i <= n; ++i)
        fout << d[i] << ' ';
}

void ReadGraph()
{
    fin >> n >> m;
    G = VVP(n + 1);  // G[0], G[1], ...

    int x, y, w;
    while (m--)
    {
        fin >> x >> y >> w;
        G[x].emplace_back(y, w);
        G[y].emplace_back(x, w);
    }
}