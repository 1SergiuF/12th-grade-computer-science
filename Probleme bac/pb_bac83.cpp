#include <iostream>
using namespace std;

void produs(int n, int& p)
{
	p = -1;
	int f[10] {0};
	
	while (n)
	{
		if (n % 2 == 0)
			f[n % 10]++;

		n = n / 10;
	}

	int p2 = 1;
	for (int i = 0; i < 10; ++i)
		if (f[i] != 0)
			p2 = p2 * i;

	if (p2 != 1)
		p = p2;
}

int main()
{
	int n;
	cin >> n;
	int p;

	produs(n, p);

	cout << p;

	return 0;
}