#include <iostream>
using namespace std;

int a[103][103];
int m, n;

int main()
{
	cin >> m >> n;
	for (int i = 1; i <= m; ++i)
		for (int j = 1; j <= n; ++j)
			a[i][j] = (i * j) % 10;
			
	for (int i = 1; i <= m; ++i)
	{
		for (int j = 1; j <= n; ++j)
			cout << a[i][j] << ' ';
		cout << '\n';
	}
	
	return 0;
}
