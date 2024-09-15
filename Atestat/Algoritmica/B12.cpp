#include <iostream>
#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("cuvinte.in");
ofstream fout("cuvinte.out");

int main()
{
	char s[21];
	fin.getline(s, 21);

	int sb = (strlen(s) % 2 == 1) ? strlen(s) / 2 + 1 : strlen(s) / 2;
	fout << sb << '\n';

	for (int i = 0; i < sb; ++i)
	{
		for (int j = i; j < strlen(s) - i; ++j)
			fout << s[j];

		fout << ' ';
	}

	return 0;
}