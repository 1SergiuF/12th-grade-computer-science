#include <fstream>
#include <iostream>
#include <cstring>
using namespace std;

ifstream fin("atestat.in");
ofstream fout("atestat.out");

char C[256][256];
char t[256];
int x;

int main()
{
	fin >> x;
	fin.get();
	fin.getline(t, 256);

	int cuv = 0;

	char* p = strtok(t, " ");

	while (p)
	{
		int nr = 0;
		for (int i = 0; p[i]; ++i)
			if (p[i] == 'o')
				++nr;

		if (nr >= 1 && nr <= x)
			strcpy(C[cuv++], p);

		p = strtok(nullptr, " ");
	}

	if (!cuv) fout << cuv;
	else
	{
		fout << cuv << '\n';
		for (int i = 0; i < cuv; ++i)
			fout << C[i] << '\n';
	}

	return 0;
}