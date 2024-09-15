#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("cuvant.in");
ofstream fout("numar.out");

char cons[] = "bcdfghjklmnpqrstvwxyz";
int main()
{
	char a[31];
	fin.getline(a + 1, 31);

	if (strlen(a) > 17 || !strpbrk(a, cons))
	{
		fout << "Imposibil";
		return 0;
	}

	int p = 10;
	int x = 0;

	for (int i = 1; a[i]; ++i)
	{
		if (strchr(cons, a[i]))
		{
			int cif = i > 9 ? i - 10 : i;
			x = x * p + cif;
		}
	}

	fout << x;

	return 0;
}