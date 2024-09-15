#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("atestat.in");
ofstream fout("atestat.out");

char a[256];
int x;

int main()
{
	fin >> x;
	fin.get();
	int pos_start = 0, pos_end = 0;

	fin.getline(a, 256);

	for (int i = 0; a[i]; ++i)
	{
		if (a[i] == ' ' || a[i + 1] == '\0')
		{
			int nr_voc = 0;
			pos_end = (a[i] == ' ') ? i - 1 : i;

			for (int j = pos_start; j <= pos_end; ++j)
				if (strchr("aeiou", a[j]))
					++nr_voc;

			if (nr_voc >= x)
			{
				nr_voc = x;
				for (int j = pos_start; j <= pos_end; ++j)
					if (strchr("aeiou", a[j]) && nr_voc > 0)
					{
						strcpy(a + j, a + j + 1);
						--nr_voc;
						--j;
						--i;
					}
			}

			pos_start = i;
		}
	}

	fout << a;

	return 0;
}