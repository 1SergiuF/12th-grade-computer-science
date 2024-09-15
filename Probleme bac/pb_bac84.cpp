#include <iostream>
#include <cstring>
using namespace std;

int main()
{
	char c[101];
	cin.getline(c, 101);
	int poz = 0;
	bool ok = false;

	for (int i = 0; c[i]; ++i)
	{
		if (c[i + 1] == ' ' || c[i + 1] == '\0')
		{
			if (poz == 0)
				poz = i;
			else
			{
				if (c[i] == c[poz])
				{
					strcpy(c + poz + 1, "succes");
					ok = true;
					i += 9;
				}

				poz = i;
			}
		}
	}

	if (!ok) cout << "nu exista";
	else cout << c;

	return 0;
}