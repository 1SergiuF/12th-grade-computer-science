#include <iostream>
#include <fstream>
using namespace std;

ofstream fout("bac.out");

bool Gasit(int n, int p1, int p2)
{
	int u2 = n % 100;
	int a = (u2 % 10) * ((u2 / 10) % 10);

	n /= 100;
	int b = 0;
	int cif = n % 10;

	while (n >= 100)
	{
		if (n % 10 == cif) ++b;
		n /= 10;
	}

	int c = (n % 10) * ((n / 10) % 10);

	return a == p2 && b == 3 && c == p1;
}

int main()
{
	int p1, p2;
	cin >> p1 >> p2;

	for (int i = 9999999; i >= 1000000; --i)
		if (Gasit(i, p1, p2))
			fout << i << '\n';

	return 0;
}