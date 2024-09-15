#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.in");

int x;
int f[1001];
bool ok = true;
int vmax;

int main()
{
	while (fin >> x)
	{
		f[x]++;
		if (vmax < x)
			vmax = x;
	}

	for (int i = 1; i <= vmax; ++i)
		if (f[i] && (f[i] > i || (f[i] % 2 != i % 2)))
		{
			ok = false;
			break;
		}

	if (ok) cout << "DA";
	else cout << "NU";

	return 0;
}