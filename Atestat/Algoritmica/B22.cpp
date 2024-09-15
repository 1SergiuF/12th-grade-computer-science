#include <iostream>
#include <algorithm>
using namespace std;

void interschimbaL(int a[][201], int m, int k1, int k2)
{
	for (int j = 1; j <= m; ++j)
		swap(a[k1][j], a[k2][j]);
}

int main()
{
	int n, m;
	int a[201][201];
	
	int vmin = 1e9 + 1;
	int vmax = -1;
	int pmax = 0;
	int pmin = 0;
	
	cin >> n >> m;
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= m; ++j)
		{
			cin >> a[i][j];
			
			if (a[i][j] < vmin)
			{
				vmin = a[i][j];
				pmin = i;
			}
			
			if (a[i][j] > vmax)
			{
				vmax = a[i][j];
				pmax = i;
			}
		}
	
	if (pmin != pmax)
		interschimbaL(a, m, pmin, pmax);
		
	for (int i = 1; i <= n; ++i)
	{
		for (int j = 1; j <= m; ++j)
			cout << a[i][j] << ' ';
		cout << '\n';
	}
	
	return 0;
}
