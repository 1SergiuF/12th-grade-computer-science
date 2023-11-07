/* Parcurgere pe Latime (largime)
 * Breadth First Search
 */ 

#include <fstream>
using namespace std;

ifstream fin("graf2.in");
ofstream fout("graf2.out");

const int N = 101;

bool a[N][N];
int d[N];	// d[x] = distanta minima de la nodul sursa (1) la nodul x
bool v[N];  // v[x] = true daca nodul x a fost vizitat
int n;

void CitesteGraf();
void Bfs(int x);

int main()
{
	CitesteGraf();
	Bfs(1);
	fout << '\n';
	fout << d[6];
	
	return 0;
}

void Bfs(int x)
{
	int Q[N]; // coada
	int p = 0, u = -1;
	Q[++u] = x;
	d[x] = 0;
	v[x] = true;
	fout << x << ' ';
	
	while (p <= u)  // cat timp coada nu este vida
	{
		x = Q[p++];	//"extragem" nodul din capul cozii
		for (int y = 1; y <= n; ++y)
			if (a[x][y] && !v[y])  // daca y este vecin nevizitat al lui x
			{
				Q[++u] = y;
				v[y] = true;
				d[y] = d[x] + 1;
				fout << y << ' ';
			}
	}	
}

void CitesteGraf()
{
	fin >> n;
	int x, y;
	while (fin >> x >> y)
	{
		a[x][y] = a[y][x] = true;
	}
}
