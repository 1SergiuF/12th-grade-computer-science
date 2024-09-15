#include <iostream>
#include <cstring>
using namespace std;

char voc[] = "aeiou";

int NrVoc(char a[])
{
	int cnt = 0;
	for (int i = 0; a[i]; ++i)
		if (strchr(voc, a[i]))
			++cnt;

	return cnt;
}

int main()
{
	char a[101];
	cin.getline(a, 101);
	bool ok = false;

	char* p = strtok(a, " ");

	while (p)
	{
		int nr_voc = NrVoc(p);
		int nr_cons = strlen(p) - nr_voc;

		if (nr_voc < nr_cons)
		{
			cout << p << '\n';
			ok = true;
		}

		p = strtok(nullptr, " ");
	}

	if (!ok) cout << "nu exista";

	return 0;
}