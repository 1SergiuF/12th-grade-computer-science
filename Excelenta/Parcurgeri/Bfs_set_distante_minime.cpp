#include <fstream>
#include <vector>
#include <queue>
#include <set>
using namespace std;

ifstream fin("graf4.in");
ofstream fout("graf4.out");

typedef vector<int> VI;
typedef vector<bool> VB;
typedef set<int> SI;
typedef vector<SI> VSI;

int n;
VSI G;
VB v;
VI d;

void CitesteGraf();
void Bfs(int x);

int main()
{
	CitesteGraf();
	Bfs(2);
	fout << d[6];
	
	return 0;
}

void Bfs(int x)
{
	queue<int> Q;
	Q.push(x);
	v[x] = true;
	d[x] = 0;
	
	while (!Q.empty())
	{
		x = Q.front();
		Q.pop();
		
		for (int const& y : G[x])
			if (!v[y])
			{
				v[y] = true;
				d[y] = d[x] + 1;
				Q.push(y);
			}
	}
}

void CitesteGraf()
{
	fin >> n;
	
	G = VSI(n + 1);
	v = VB(n + 1);
	d = VI(n + 1);
	
	int x, y;
	while (fin >> x >> y)
	{
		G[x].insert(y);
		G[y].insert(x);
	}
}
