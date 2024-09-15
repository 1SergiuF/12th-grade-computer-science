#include <iostream>
#include <cstring>
using namespace std;

char c[101][11];
char a[101][101];
char sab[101];

bool ok = true;
bool gasit = false;

int n;

int main()
{
	char cuv[11];

	cin >> n;
	cin.get();
	for (int i = 0; i < n; ++i)
	{
		cin.getline(cuv, 11);
		strcpy(c[i], cuv);
	}

	cin.getline(sab, 101);

	char* p = strtok(sab, " ");
	int cnt = 0;

	while (p)
	{
		if (p[0] == '*')
		{
			for (int i = 0; i < n; ++i)
				if (strlen(c[i]) == strlen(p))
				{
					strcpy(a[cnt], c[i]);
					gasit = true;
				}

			if (!gasit)
			{
				ok = false;
				break;
			}
		}
		else
			strcpy(a[cnt], p);

		cnt++;
		gasit = false;

		p = strtok(nullptr, " ");
	}

	if (!ok) cout << "imposibil";
	else
	{
		for (int i = 0; i <= cnt; ++i)
			cout << a[i] << ' ';
	}

	return 0;
}