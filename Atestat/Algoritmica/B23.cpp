#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("matrice.in");

int nrpare_p(int n, int a[][101])
{
	int nr = 0;
	for (int i = 1; i <= n; ++i)
		if (a[i][i] % 2 == 0)
			++nr;
			
	return nr;
}

int nrpare_s(int n, int a[][101])
{
	int nr = 0;
	for (int i = 1; i <= n; ++i)
		if (a[i][n - i + 1] % 2 == 0)
			++nr;
			
	return nr;
}

int main()
{
	int n;
	int a[101][101];
	
	fin >> n;
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
			fin >> a[i][j];
	
	int nr_imp = (a[(n + 1) / 2][(n + 1) / 2] % 2 == 1) ? -1 : 0;
	
	nr_imp += n - nrpare_p(n, a) + n - nrpare_s(n, a);
	
	cout << nr_imp;
	
	return 0;
}
