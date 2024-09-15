#include <iostream>
#include <cstring>
#include <algorithm>
using namespace std;

const int N = 10001;

struct cuvant {
	int nr_ap;
	char s[N];

	bool operator < (cuvant const& c) const noexcept
	{
		return strcmp(c.s, s) > 0;
	}

} cuv[N / 2 + 1];

char a[N];

int main()
{
	cin.getline(a, N + 1);

	char *p = strtok(a, " ;,?!.");
	int cnt = 0;

	while (p)
	{
		bool gasit = false;
		int poz = 0;
		for (int i = 0; i < cnt; ++i)
			if (strcmp(cuv[i].s, p) == 0)
			{
				gasit = true;
				poz = i;
				break;
			}

		if (gasit)
			cuv[poz].nr_ap++;
		else
		{
			strcpy(cuv[cnt].s, p);
			cuv[cnt].nr_ap++;
			cnt++;
		}

		p = strtok(nullptr, " ;,?!.");
	}

	sort(cuv, cuv + cnt);

	for (int i = 0; i < cnt; ++i)
		cout << cuv[i].s << ' ' << cuv[i].nr_ap << '\n';

	return 0;
}