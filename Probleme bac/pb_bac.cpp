#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int x;
	int l = 1;
	int lmax = 0;
	int u = 0;

	fin >> x;
	int pre = x;

	while (fin >> x)
	{
		if (x - pre == 1)
			++l;
		else
		{
			if (l > lmax)
			{
				lmax = l;
				u = pre;
			}

			l = 1;
		}

		pre = x;
	}

	if (lmax == 0) cout << "nu exista";
	else
	{
		int p = u - lmax + 1;

		for (int i = p; i <= u; ++i)
			cout << i << ' ';
	}

	return 0;
}