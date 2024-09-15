#include <fstream>
using namespace std;

ifstream fin("date.in");
ofstream fout("date.out");

bool CifreDistincte(int n)
{
	if (n < 10) return false;

	int fc[10] {0};
	while (n)
	{
		fc[n % 10]++;
		if (fc[n % 10] > 1)
			return false;
		n /= 10;
	}

	return true;
}

int main()
{
	int cif_dist = 0, cif_nedist = 0;
	int fdist[1001] {0}, fnedist[1001] {0};

	int x;
	while (fin >> x)
	{
		CifreDistincte(x) ? fdist[++cif_dist] = x : fnedist[++cif_nedist] = x;
	}

	if (cif_dist == 0) fout << "Nu exista\n";
	else
	{
		for (int i = 1; i <= cif_dist; ++i)
			fout << fdist[i] << ' ';

		fout << cif_dist << '\n';
	}

	if (cif_nedist == 0) fout << "Nu exista";
	else
	{
		for (int i = 1; i <= cif_nedist; ++i)
			fout << fnedist[i] << ' ';
		fout << cif_nedist;
	}

	return 0;
}