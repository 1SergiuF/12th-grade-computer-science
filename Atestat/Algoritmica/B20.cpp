#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("atestat.in");
ofstream fout("atestat.out");

char a[256];

int main()
{
	fin.getline(a, 256);

	for (int i = 0; a[i]; ++i)
	{
		if (strchr("aeiou", a[i]))
			strcpy(a + i + 1, a + i + 3);
	}

	fout << a;

	return 0;
}