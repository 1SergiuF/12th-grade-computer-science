#include <iostream>
using namespace std;

int main()
{
	int a[7][7];
	for (int i = 0; i < 4; ++i)
		for (int j = 0; j < 5; ++j)
		{
			a[i][j] = 20 - 4 + j - 5 * i;
		}

	for (int i = 0; i < 4; ++i)
	{
		for (int j = 0; j < 5; ++j)
			cout << a[i][j] << ' ';
		cout << '\n';
	}

	return 0;
}