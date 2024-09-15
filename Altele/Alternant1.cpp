#include <iostream>
using namespace std;

typedef unsigned long long ULL;

bool Alternant(ULL n);

int main()
{
	ULL n;
	cin >> n;

	Alternant(n) ? cout << "da" : cout << "nu";

	return 0;
}

bool Alternant(ULL n)
{
	if (n < 10)
		return true;

	int uc1 = n % 10;
	int uc2 = (n / 10) % 10;

	if ((uc1 + uc2) % 2 == 0)
		return false;

	return Alternant(n / 10);
}