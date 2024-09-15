#include <iostream>
using namespace std;

int a[5][6];

int main()
{
	for (int i = 0; i < 4; ++i)
		for (int j = 0; j < 5; ++j)
			a[i][j] = (i + 1) * 5 - j;


	for (int i = 0; i < 4; ++i)
	{
		for (int j = 0; j < 5; ++j)
			cout << a[i][j] << ' ';

		cout << '\n';
	}

	return 0;
}