#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.in");

int f[11]; // frecventa ultimelor cifre
int val[11]; // valorile din sir care corespund frecventelor maxime

int main()
{
	int x; // valoarea citita

	fin >> x;

	f[x % 10]++;
	val[x % 10] = x;

	int n = 1; // pozitia elementului in sir
	int fmax = 1; // frecventa maxima

	while (fin >> x)
	{
		n++;
		f[x % 10]++;
		if (f[x % 10] >= fmax)
		{
			fmax = f[x % 10];
			val[x % 10] = n;
		}
	}

	for (int i = 0; i < 10; ++i)
		if (f[i] == fmax)
			cout << val[i] << ' ';

	return 0;
}