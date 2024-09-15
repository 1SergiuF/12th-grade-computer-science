#include <iostream>
#include <cstring>
using namespace std;

const int N = 101;
char c[N];
char matc[N][N];

int main()
{
	cin.getline(c, N);

	char *p = strtok(c, " ");
	int n = 0;

	while (p)
	{
		if (p[strlen(p) - 1] == '.')
		{
			char first = p[0];

			switch(first)
			{
				case 'F':
					strcpy(matc[n], "fam.");
					break;

				case 'G':
					strcpy(matc[n], "gen.");
					break;

				case 'S':
					strcpy(matc[n], "spe.");
					break;
			}
		}
		else
			strcpy(matc[n], p);

		n++;

		p = strtok(nullptr, " ");
	}

	for (int i = 0; i < n; ++i)
		cout << matc[i] << ' ';

	return 0;
}