#include <iostream>
using namespace std;

int main()
{
	int a[10][10];

	for (int i = 0; i < 5; ++i)
		for (int j = 0; j < 5; ++j)
		{
			if (i == 0 || j == 0)
				a[i][j] = 0;

			else
			{
				if (j <= i)
					a[i][j] = a[i][j - 1] + 2;
				else
					a[i][j] = a[i][j - 1];
			}
		}

	for (int i = 0; i < 5; ++i)
	{
		for (int j = 0; j < 5; ++j)
			cout << a[i][j] << ' ';
		cout << '\n';
	}

	return 0;
}