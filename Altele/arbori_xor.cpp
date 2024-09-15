#include <fstream>
#include <iostream>
#include <utility>
#include <vector>
using namespace std;

ifstream fin("arbori_xor.in");
ofstream fout("arbori_xor.out");

typedef vector<bool> VB;
typedef pair<int, int> PI;
typedef vector<PI> VP;
typedef vector<VP> VVP;
typedef vector<int> VI;

int n, Q;
VVP G;
VB v;
VI vxor;

void ReadGraph();
void Dfs(int node, int nr);

int main()
{
	ReadGraph();
	Dfs(1, 0);
	int x, y;
	while (Q--)
	{
		fin >> x >> y;
		int w = vxor[x] ^ vxor[y];
		fout << w << '\n';
	}

	return 0;
}

void Dfs(int node, int nr)
{	
	v[node] = true;
	vxor[node] = nr;
	
	for (auto const& neigh : G[node])
		if (!v[neigh.first])
			Dfs(neigh.first, nr ^ neigh.second);
}

void ReadGraph()
{
	fin >> n >> Q;

	G = VVP(n + 1);
	v = VB(n + 1);
	vxor = VI(n + 1, 0);

	for (int i = 1, x, y, w; i < n; ++i)
	{
		fin >> x >> y >> w;
		G[x].emplace_back(y, w);
		G[y].emplace_back(x, w);
	}
}