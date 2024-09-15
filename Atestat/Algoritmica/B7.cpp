#include <fstream>
using namespace std;

ifstream fin("numere.in");
ofstream fout("numere.out");

void InserezP(int& n, int v[], int p, int val)
{
	int aux = v[p];
	v[p] = val;
	n++;

	int prev = 0;

	for (int i = p + 1; i <= n; ++i)
	{
		prev = v[i];
		v[i] = aux;
		aux = prev;
	}
}

int SumaCifre(int x)
{
	if (x < 10) return x;
	return (x % 10) + SumaCifre(x / 10);
}

int main()
{
	int n;
	int v[101];

	fin >> n;
	for (int i = 1; i <= n; ++i)
		fin >> v[i];

	for (int i = 1; i <= n; i += 2)
	{
		int sc = SumaCifre(v[i]);
		InserezP(n, v, i + 1, sc);
	}
	
	for (int i = 1; i <= n; ++i)
		fout << v[i] << ' ';

	return 0;
}