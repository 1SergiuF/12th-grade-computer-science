#include <fstream>
using namespace std;

ifstream fin("numere.in");
ofstream fout("numere.out");

bool EPrim(int x)
{
	if (x < 2) return false;
	if (x == 2) return true;
	if (x % 2 == 0) return false;

	for (int i = 3; i * i <= x; i += 2)
		if (x % i == 0)
			return false;

	return true;
}

int main()
{
	int f[100] {0};
	int x;
	bool exista = false;

	while (fin >> x)
	{
		if (EPrim(x))
		{
			f[x]++;
			exista = true;
		}
	}

	if (!exista) fout << "Nu exista";
	else
	{
		int fmax = 0;
		int nr = 0;
		for (int i = 0; i < 100; ++i)
			if (fmax < f[i])
			{
				fmax = f[i];
				nr = i;
			}

		fout << nr << ' ' << fmax;

	}

	return 0;
}