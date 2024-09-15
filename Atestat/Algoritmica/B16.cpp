#include <iostream>
#include <cstring>
#include <fstream>
using namespace std;

ifstream fin("atestat.in");
ofstream fout("atestat.out");

int main()
{
	char t[101];
	fin.getline(t, 101);
	char c;
	fin >> c;
	int cnt = 0;

	for (int i = 0; t[i]; ++i)
		if (t[i] == c)
		{
			char aux[101];
			aux[0] = c;
			strcpy(aux + 1, t + i + 1);
			strcpy(t + i + 1, aux);
			++cnt;
			i++;
		}

	fout << cnt << '\n';
	fout << t;

	return 0;
}