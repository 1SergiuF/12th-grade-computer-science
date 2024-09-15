#include <fstream>
#include <iostream>
#include <cstring>
using namespace std;

ofstream fout("sufixe.out");

int main()
{
	char s[21];
	cin.getline(s, 21);

	int cnt = 0;
	for (int i = 0; s[i]; i++)
	{
		char t[21];
		strcpy(t, s + i);
		fout << t << ' ';
		++cnt;
	}

	fout << '\n' << cnt;

	return 0;
}