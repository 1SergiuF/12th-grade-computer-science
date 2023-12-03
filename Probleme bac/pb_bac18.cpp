#include <iostream>
using namespace std;

int n;
int a[24][24];

int main()
{
	cin >> n;
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
		{
			if (j < n - i + 1)
				a[i][j] = n - j - i + 1;
			else
				if (j > n - i + 1)
					a[i][j] = j - (n - i + 1);
		}
		
	for (int i = 1; i <= n; ++i)
	{
		for (int j = 1; j <= n; ++j)
			cout << a[i][j] << ' ';
		cout << '\n';
	}
	
	return 0;
}
