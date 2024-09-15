#include <iostream>
using namespace std;

bool PrimeIntreEle(int a, int b)
{
	int vmin = 1;
	if (a < b) vmin = a;
	else if (a > b) vmin = b;

	for (int i = 2; i <= vmin; ++i)
		if (a % i == 0 && b % i == 0)
			return false;

	return true;
}

void nPrime(int n, int& k, int p[])
{
	k = 0;
	for (int i = 1; i < n; ++i)
		if (PrimeIntreEle(i, n) == true)
			p[++k] = i;
}

int n, k;
int p[1000];

int main()
{
	cin >> n;
	nPrime(n, k, p);

	cout << k << '\n';
	for (int i = 1; i <= k; ++i)
		cout << p[i] << ' ';

	return 0;
}