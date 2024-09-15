#include <iostream>
using namespace std;

bool VerifRegulat(int n)
{
	if (n % 2 == 0 && n % 5 == 0) return true;
	else if (n % 3 == 0 && n % 5 == 0) return true;
	else if (n % 2 == 0 && n % 3 == 0) return true;
	else if (n % 2 == 0 && n % 5 == 0 && n % 3 == 0) return true;

	return false;
}

int regulat(int n)
{
	while (n)
	{
		if (VerifRegulat(n))
			return n;

		n--;
	}
}

int main()
{
	int n;
	cin >> n;

	cout << regulat(n);

	return 0;
}