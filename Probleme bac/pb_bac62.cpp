#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int expo2(int n)
{
	if (n == 1) return 0;
	return 1 + expo2(n / 2);
}

int exp[32];

int main()
{
	int exp_max = 0, exp_max_poz = 0;
	int x;
	while (fin >> x)
	{
		exp[expo2(x)]++;
	}

	for (int i = 0; i < 33; ++i)
	{
		if (exp_max <= exp[i])
		{
			exp_max = exp[i];
			exp_max_poz = i;
		}
	}

	cout << exp_max_poz;

	return 0;
}