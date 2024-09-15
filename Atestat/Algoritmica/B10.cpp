#include <fstream>
using namespace std;

ifstream fin("numere.in");
ofstream fout("numere.out");

void PozitiiPare(int n, int v[], int& prim, int& ultim)
{
	for (int i = 1; i <= n; ++i)
		if (v[i] % 2 == 0)
		{
			prim = i;
			break;
		}

	for (int j = n; j >= 1; --j)
		if (v[j] % 2 == 0)
		{
			ultim = j;
			break;
		}
}

void Sortpq(int n, int v[], int p, int q)
{
	for (int i = p; i < q; ++i)
		for (int j = i + 1; j <= q; ++j)
			if (v[i] > v[j])
			{
				int aux = v[i];
				v[i] = v[j];
				v[j] = aux;
			}
}

int main()
{
	int n;
	int v[101];

	fin >> n;
	for (int i = 1; i <= n; ++i)
		fin >> v[i];

	int prim = 0, ultim = 0;
	PozitiiPare(n, v, prim, ultim);
	Sortpq(n, v, prim, ultim);

	for (int i = 1; i <= n; ++i)
		fout << v[i] << ' ';

	return 0;
}