#include <iostream>
using namespace std;

int main()
{
	int a[11][11];
	int x;
	
	cin >> x;
	int y = x;
	int nr_cif = 0;
	
	while (y != 0)
	{
		nr_cif++;
		y = y / 10;
	}
	
	for (int j = nr_cif; j >= 1; j--)
	{
		for (int i = 1; i <= nr_cif; ++i)
			a[i][j] = x % 10;
			
		x /= 10;
	}
	
	for (int i = 1; i <= nr_cif; ++i)
	{
		for (int j = 1; j <= nr_cif; ++j)
			cout << a[i][j] << ' ';
		cout << '\n';
	}
	
	return 0;
}
