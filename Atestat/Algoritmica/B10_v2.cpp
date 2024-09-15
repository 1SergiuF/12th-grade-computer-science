#include <iostream>
#include <fstream>
#include <algorithm>
using namespace std;

ifstream fin("numere.in");
ofstream fout("numere.out");

void PozitiiPare(int n, int v[], int& prim, int& ultim)
{
	prim = 0, ultim = 0;
	
	for (int i = 1; i <= n; ++i)
		if (v[i] % 2 == 0)
		{
			prim = i;
			break;
		}
		
	for (int i = n; i >= 1; --i)
		if (v[i] % 2 == 0)
		{
			ultim = i;
			break;
		}
}

void Sortpq(int n, int v[], int p, int q)
{
	for (int i = p; i < q; ++i)
		for (int j = i + 1; j <= q; ++j)
			if (v[i] > v[j])
				swap(v[i], v[j]);
}

int main()
{
	int n;
	int v[101];
	
	fin >> n;
	
	for (int i = 1; i <= n; ++i)
		fin >> v[i];
		
	int prim, ultim;
	PozitiiPare(n, v, prim, ultim);
	
	Sortpq(n, v, prim, ultim);
	
	for (int i = 1; i <= n; ++i)
		fout << v[i] << ' ';
		
	return 0;
}
