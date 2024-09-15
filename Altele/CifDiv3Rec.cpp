#include <iostream>
using namespace std;

int CifDiv3Rec(int n);

int main()
{
	int n;
	cin >> n;

	cout << CifDiv3Rec(n);

	return 0;
}

int CifDiv3Rec(int n)
{
	if (n < 10)
		if (n % 3 == 0)
			return 1;
		else
			return 0;

	if ((n % 10) % 3 == 0)
		return 1 + CifDiv3Rec(n / 10);

	return CifDiv3Rec(n / 10);
}