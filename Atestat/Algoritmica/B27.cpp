#include <fstream>
#include <algorithm>
using namespace std;

ifstream fin("atestat.in");
ofstream fout("atestat.out");

void interschimbC(int a[][201], int n, int k1, int k2)
{
	for (int i = 1; i <= n; ++i)
		swap(a[i][k1], a[i][k2]);
}

int main()
{
	int n, m;
	int a[201][201];
	
	int jmin = 0, jmax = 0;
	int vmax = -1, vmin = 1e9 + 1;
	
	fin >> n >> m;
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= m; ++j)
		{
			fin >> a[i][j];
			
			if (vmax < a[i][j])
			{
				vmax = a[i][j];
				jmax = j;
			}
			
			if (vmin > a[i][j])
			{
				vmin = a[i][j];
				jmin = j;
			}
		}
	
	interschimbC(a, n, jmin, jmax);
	
	for (int i = 1; i <= n; ++i)
	{
		for (int j = 1; j <= m; ++j)
			fout << a[i][j] << ' ';
		fout << '\n';
	}
	
	return 0;	
}
