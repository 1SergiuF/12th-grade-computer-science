#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int x;
	int l = 2, lmax = 2;
	int r = 0, rmax = 0;

	fin >> x;
	int prev = x;
	fin >> x;
	r = x - prev;
	prev = x;

	while (fin >> x)
	{
		if (x - prev == r)
		{
			l++;
			prev = x;
		}
		else
		{
			if (l > lmax)
			{
				lmax = l;
				rmax = r;
			}
			else if (l == lmax)
				if (rmax < r)
					rmax = r;

			r = x - prev;
			l = 2;
			prev = x;
		}
	}

	if (lmax == 2) cout << "nu exista";
	else cout << rmax;

	return 0;
}