#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");
int f[100];

int main()
{
	int k;
	int x;
	int nr = 0;
	int vmax = 0;

	fin >> k;

	while (fin >> x)
	{
		nr++;
		if (vmax <= x)
			vmax = x;
		f[x]++;
	}

	if (k > nr) cout << -1;
	else
	{
		int i = vmax;
		while (k >= 0)
		{
			k = k - f[i];
			i--;
		}

		cout << i + 1;
	}

	return 0;
}