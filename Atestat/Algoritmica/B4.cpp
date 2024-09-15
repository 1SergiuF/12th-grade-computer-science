#include <iostream>
#include <fstream>
#include <algorithm>
using namespace std;

ifstream fin("numere.in");
ofstream fout("numere.out");

void Inversez(float v[], int p, int q)
{
	for (int i = p, j = q; i <= j; ++i, --j)
		swap(v[i], v[j]);
}

void Stergp(float v[], int& n, int p)
{
	for (int i = p; i < n; ++i)
		v[i] = v[i + 1];
	
	n--;
}

int main()
{
	int n;
	float v[101];
	
	fin >> n;
	
	for (int i = 1; i <= n; ++i)
		fin >> v[i];
		
	if (n % 2 == 1)
		Stergp(v, n, (1 + n) / 2);
		
	Inversez(v, 1, n / 2);
	Inversez(v, (n / 2) + 1, n);
	
	for (int i = 1; i <= n; ++i)
		fout << v[i] << ' ';
		
	return 0;
}
