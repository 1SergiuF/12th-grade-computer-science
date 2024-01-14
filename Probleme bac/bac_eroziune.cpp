#include <iostream>
#include <algorithm>
using namespace std;

const int N = 102;
int L, C;
int a[N][N];
int S;

int main()
{
	cin >> L >> C;
	for (int i = 1; i <= L; ++i)
	{
		a[i][0] = 11;
		a[i][C + 1] = 11;
		for (int j = 1; j <= C; ++j)
		{
			a[0][j] = 11;
			a[L + 1][j] = 11;
			cin >> a[i][j];
		}
	}

	int vecin_min = 11;

	for (int i = 1; i <= L; ++i)
	{
		for (int j = 1; j <= C; ++j)
		{
			vecin_min = min({a[i - 1][j], a[i + 1][j], a[i][j - 1], a[i][j + 1]});

			if (a[i][j] < vecin_min)
				S += vecin_min - a[i][j];
		}
	}

	cout << S;

	return 0;
}