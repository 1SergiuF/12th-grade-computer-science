#include <iostream>
using namespace std;

void fii(int n)
{
	for (int i = 1; i <= n; ++i)
	{
		if (n % i == 0)
			if (n / i > i)
				cout << '(' << n / i << ' ' << i << ')' << ' ';
	}
}

int main()
{
	int n;
	cin >> n;

	fii(n);

	return 0;
}