#include <iostream>
#include <cstring>
using namespace std;

char c[101];
int cnt;

int main()
{
	cin.getline(c, 101);
	char* p = strtok(c, " ");

	while (p)
	{
		if (isdigit(p[0]) && !strchr(p, ','))
			cnt++;
		p = strtok(nullptr, " ");
	}

	cout << cnt;

	return 0;
}