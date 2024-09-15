#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("atestat.in");
ofstream fout("atestat.out");

char a[51];

int main()
{
	fin.getline(a, 51);

	for (int i = 0; a[i]; ++i)
	{
		if (strchr("aeiou", a[i]))
		{
			char t[110] = "";
			char c1 = a[i] + 1;
			char c2 = c1 + 1;

			t[0] = c1;
			t[1] = c2;
			strcat(t, a + i + 1);

			strcpy(a + i + 1, t);

			i += 2;
		}
	}

	fout << a;

	return 0;
}