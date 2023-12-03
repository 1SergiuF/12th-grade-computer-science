#include <iostream>
#include <cmath>
using namespace std;

int MatDiag(int a[100][100], int n)
{
	for (int i = 2; i < n; ++i)
		for (int j = 1; j < n; ++j)
			if (abs((i - 1) - (j - 1)) == abs(i - j) && a[i - 1][j - 1] != a[i][j])
				return 0;

	return 1;
}

int main()
{
	int a[100][100];
	int n;

	cin >> n;
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
			cin >> a[i][j];

	cout << MatDiag(a, n);

	return 0;
}