#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("atestat.in");

int numarare(int x[][11], int n, int p)
{
	int cnt = 0;
	for (int i = 1; i <= n; ++i)
		if (x[i][p] == 1)
			++cnt;
			
	return cnt;
}

bool toateNule(int x[][11], int n, int p)
{
	for (int j = 1; j <= n; ++j)
		if (x[p][j])
			return false;
			
	return true;
}

int main()
{
	int n;
	int x[11][11];
	int modif[11];
	
	fin >> n;
	
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
			fin >> x[i][j];
	
	for (int j = 1; j <= n; ++j)
		modif[j] = numarare(x, n, j);
		
	for (int i = 1; i <= n; ++i)
		if (toateNule(x, n, i))
			for (int j = 1; j <= n; ++j)
				x[i][j] = modif[j];
			
	for (int i = 1; i <= n; ++i)
	{
		for (int j = 1; j <= n; ++j)
			cout << x[i][j] << ' ';
		cout << '\n';
	}
	
	return 0;
}
