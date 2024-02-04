#include <iostream>
using namespace std;

int a[21][21];
int n;
int k;

int main()
{
	cin >> n >> k;
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
			cin >> a[i][j];
			
	int aux = 0;
	for (int i = 1; i < k; ++i)
	{
		aux = a[k][i];
		a[k][i] = a[i][k];
		a[i][k] = aux;
	}
	
	cout << '\n';
	for (int i = 1; i <= n; ++i)
	{
		for (int j = 1; j <= n; ++j)
			cout << a[i][j] << ' ';
		cout <<'\n';
	}
	
	return 0;
}
