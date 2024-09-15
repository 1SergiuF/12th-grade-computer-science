#include <iostream>
using namespace std;

int baza(int n)
{
	int cmax = 0;
	while (n)
	{
		if (cmax < n % 10)
			cmax = n % 10;
		n /= 10;
	}

	return cmax + 1;
}

int main()
{
	int n;
	cin >> n;

	cout << baza(n);

	return 0;
}