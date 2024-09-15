#include <iostream>
using namespace std;

bool Prim(int x)
{
	if (x < 2) return false;
	if (x == 2) return true;
	if (x % 2 == 0) return false;

	for (int i = 3; i * i <= x; i += 2)
		if (x % i == 0)
			return false;

	return true;
}

void prodprim(int n, int& p)
{
	p = 1;
	for (int i = 2; i <= n; ++i)
		if (Prim(i) && n % i == 0)
			p = p * i;
}

int main()
{
	int n;
	int p;
	cin >> n;

	prodprim(n, p);

	cout << p;

	return 0;
}