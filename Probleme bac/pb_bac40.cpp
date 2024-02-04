#include <iostream>
using namespace std;

int n;
int a[21][21];
int pi, pj;

int main()
{
	cin >> n;
	
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
			cin >> a[i][j];
			
	int rez = 1;
	bool ok = true;
	for (int i = 2; i <= n; ++i)
	{
		for (int ki = 1; ki <= i; ++ki)
			if (a[ki][i] != a[1][1])
			{
				ok = false;
				break;
			}
		for (int kj = 1; kj <= i; ++kj)
			if (a[i][kj] != a[1][1])
			{
				ok = false;
				break;
			}
		
		if (!ok) break;
				
		rez = i;
	}
	
	cout << rez;
	
	return 0;
}
