#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("atestat.in");

bool complementare(int a[][201], int n, int k1, int k2)
{
	for (int i = 1; i <= n; ++i)
		if (a[i][k1] == a[i][k2])
			return false;
			
	return true;
}

int main()
{
	int n, m;
	int a[201][201];
	
	fin >> n >> m;
	for (int i = 1; i <= n; ++i)
		for(int j = 1; j <= m; ++j)
			fin >> a[i][j];
			
	int cnt = 0;
	for (int j = 2; j <= m; ++j)
		if (complementare(a, n, 1, j))
			++cnt;
			
	cout << cnt;
	
	return 0;
}
