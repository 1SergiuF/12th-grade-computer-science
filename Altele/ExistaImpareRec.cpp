#include <iostream>
using namespace std;

int ExistaImpareRec(int n);

int main()
{
	int n;
	cin >> n;

	cout << ExistaImpareRec(n);
	
	return 0;
}

int ExistaImpareRec(int n)
{
	if (n < 10)
	{
		if (n % 2 == 1)
			return 1;
		return 0;
	}

	if (n % 2 == 1)
		return 1;

	return ExistaImpareRec(n / 10);
}