/* Parcurgere pe Latime (largime)
 * Breadth First Search
 */ 

#include <fstream>
#include <set>
#include <vector>
#include <queue>
using namespace std;

ifstream fin("graf3.in");
ofstream fout("graf3.out");

using VB  = vector<bool>;
using SI  = set<int>;
using VSI = vector<SI>;

int n;
VSI G;
VB v;

void CitesteGraf();
void Bfs(int x);

int main()
{
	CitesteGraf();
	Bfs(1);
}

void Bfs(int x)
{
	queue<int> Q; // coada vida
	Q.push(x);
	v[x] = true;
	fout << x << ' ';
	
	while (!Q.empty()) // cat timp coada nu este vida
	{
		x = Q.front(); // aflam primul nod din coada
		Q.pop();     // apoi il stergem
		
		for (auto y : G[x])
			if (!v[y])
			{
				v[y] = true;
				Q.push(y);
				fout << y << ' ';
			}
	}
}

void CitesteGraf()
{
	fin >> n;
	G = VSI(n + 1);
	v = VB(n + 1);
	int x, y;
	
	while (fin >> x >> y)
	{
		G[x].insert(y);
		G[y].insert(x);
	}
}
