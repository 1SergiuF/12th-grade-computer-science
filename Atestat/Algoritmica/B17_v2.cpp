#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("atestat.in");
ofstream fout("atestat.out");

int x;
char a[256];
char voc[] = "aeiou";

int main()
{
	fin >> x;
	fin.get();
	fin.getline(a, 256);
	
	int nr_voc = 0;
	int poz1 = 0, poz2 = 0;
	
	for (int i = 0; a[i]; ++i)
	{
		if (a[i] == ' ')
		{
			poz2 = i;
			if (nr_voc >= x)
			{
				int cnt = 1;
				for (int j = poz1; j < poz2; ++j)
					if (strchr(voc, a[j]) && cnt <= x)
					{
						strcpy(a + j, a + j + 1);
						i--;
						j--;
						++cnt;
					}
			}
			
			nr_voc = 0;
			poz1 = i + 1;
		}
		
		else if (a[i + 1] == '\0')
		{
			poz2 = i;
			if (nr_voc >= x)
			{
				int cnt = 1;
				for (int j = poz1; j <= poz2; ++j)
					if (strchr(voc, a[j]) && cnt <= x)
					{
						strcpy(a + j, a + j + 1);
						i--;
						j--;
						++cnt;
					}
			}
			
			nr_voc = 0;
			poz1 = poz2;
		}
		
		else
		{
			if (strchr(voc, a[i]))
				++nr_voc;
		}
	}
	
	fout << a;
	
	return 0;
}
