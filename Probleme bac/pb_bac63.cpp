#include <iostream>
using namespace std;

int n;
int a[51][51];
int unucol[51];

int main()
{
	cin >> n;
	for (int i = 0; i < n; ++i)
		for (int j = 0; j < n; ++j)
		{
			cin >> a[i][j];
			if (a[i][j] == true)
				unucol[j]++;
		}

	for (int i = 0; i < n; ++i)
	{
		int cnt = 0;
		for (int j = 0; j < n; ++j)
			if (a[i][j] == false)
				++cnt;

		if (cnt == n)
		{
			while (--cnt >= 0)
				a[i][cnt] = unucol[cnt];
		}
	}

	for (int i = 0; i < n; ++i)
	{
		for (int j = 0; j < n; ++j)
			cout << a[i][j] << ' ';
		cout << '\n';
	}

	return 0;
}