#include <iostream>
#include <fstream>
#include <algorithm>
using namespace std;

ifstream fin("matrice.in");

int maxim_d(int n, int a[][101])
{
	int vmaxp = -1, vmaxs = -1;
	
	for (int i = 1; i <= n; ++i)
		if (a[i][i] % 2 == 0)
			vmaxp = max(vmaxp, a[i][i]);
			
	for (int i = 1; i <= n; ++i)
		if (a[i][n - i + 1] % 2 == 0)
			vmaxs = max(vmaxs, a[i][n - i + 1]);\
			
	return (vmaxp < 0 && vmaxs < 0) ? -1 : max(vmaxp, vmaxs);
}

int main()
{
	int n;
	int a[101][101];
	
	fin >> n;
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
			fin >> a[i][j];
			
	int v = maxim_d(n, a);
	
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
			if (i != j && i + j - 1 != n && a[i][j] % 2 == 1)
				a[i][j] = v;
				
	for (int i = 1; i <= n; ++i)
	{
		for (int j = 1; j <= n; ++j)
			cout << a[i][j] << ' ';
		cout << '\n';
	}
	
	return 0;
}
