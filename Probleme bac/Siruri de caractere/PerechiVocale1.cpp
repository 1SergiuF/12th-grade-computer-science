#include <iostream>
#include <fstream>
#include <cstring>
#include <algorithm>
using namespace std;

ifstream fin("perechivocale1.in");
ofstream fout("perechivocale1.out");

struct Pereche {
	char per[3];
	int nrap;

	bool operator < (Pereche const& p) const noexcept
	{
		return nrap < p.nrap || (nrap == p.nrap && strcmp(per, p.per) < 0);
	}

} perechi[100];

char voc[] = "aeiou";
char temp[3];
char c1, c2;
int cnt;

int main()
{
	c1 = fin.get();
	while (!fin.eof())
	{
		c2 = fin.get();

		if (strchr(voc, c1) && strchr(voc, c2))
		{
			temp[0] = c1;
			temp[1] = c2;
			temp[2] = '\0';

			bool gasit = false;
			int poz = 0;

			for (int i = 0; i < cnt; ++i)
				if (strcmp(perechi[i].per, temp) == 0)
				{
					gasit = true;
					poz = i;
					break;
				}

			if (gasit)
				perechi[poz].nrap++;
			else
			{
				strcpy(perechi[cnt].per, temp);
				perechi[cnt].nrap++;
				cnt++;
			}

		}

		c1 = c2;
	}

	sort(perechi, perechi + cnt);

	if (cnt == 0)
		fout << "NU";
	else
	{
		int maxap = perechi[cnt - 1].nrap;

		for (int i = 0; i < cnt; ++i)
			if (perechi[i].nrap == maxap)
				fout << perechi[i].per << ' ';
	}

	return 0;
}