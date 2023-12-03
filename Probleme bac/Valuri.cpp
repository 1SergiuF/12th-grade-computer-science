#include <iostream>
using namespace std;

const int N = 110;
int v[N];

void valuri(int n, int v[])
{
	int nr = n;
	for (int i = 0; i < 2 * n; ++i)
	{
		if (i % 2 == 0)
		{
			v[i] = i + 1;
		}
		else
		{
			v[i] = 2 * nr;
			--nr;
		}
	}
}

int main()
{
	int n;

	cin >> n;

	valuri(n, v);

	for (int i = 0; i < 2 * n; ++i)
		cout << v[i] << ' ';

	// 4
	// 1 8 3 6 5 4 7 2
}