#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("descp2.in");
ofstream fout("descp2.out");

int n;
int s;
int x[251];

void ScrieSol(int k);
void GenereazaMod(int k, int s);

int main()
{
	fin >> n;
	x[0] = 2;
	GenereazaMod(1, 0);

	return 0;
}

void GenereazaMod(int k, int s)
{
	if (s == n)
	{
		ScrieSol(k - 1);
		return;
	}

	for (int i = x[k - 1]; i + s <= n; i *= 2)
	{
		s += i;
		x[k] = i;
		GenereazaMod(k + 1, s);
		s -= i;
	}
}

void ScrieSol(int k)
{
	for (int i = 1; i <= k; ++i)
		fout << x[i] << ' ';
	fout << '\n';
}