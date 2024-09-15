#include <fstream>
using namespace std;

ifstream fin("matrice.in");
ofstream fout("matrice.out");

int suma(int x[][11], int n, int p)
{
	int s = 0;
	for (int j = 1; j <= n; ++j)
		s += x[p][j];
		
	return s;
}

int main()
{
	int n;
	int x[11][11];
	int smax = -1;
	
	fin >> n;
	for (int i = 1; i <= n; ++i)
	{
		for (int j = 1; j <= n; ++j)
			fin >> x[i][j];
			
		if (smax < suma(x, n, i))
			smax = suma(x, n, i);
	}
	
	for (int i = 1; i <= n; ++i)
		if (suma(x, n, i) == smax)
			fout << i << ' ';
			
	return 0;
}
