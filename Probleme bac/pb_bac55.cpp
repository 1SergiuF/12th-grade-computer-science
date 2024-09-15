#include <iostream>
using namespace std;

void generatoare(int n)
{
	bool ok = false;

	for (int a = 2; a <= n; a += 2)
	{
		int b = n / a;
		if (a * b + a / b == n)
		{
			ok = true;
			cout << a << '-' << b << ' ';
		}
	}

	if (!ok) cout << "nu exista";
}

int main()
{
	int n;
	cin >> n;

	generatoare(n);

	return 0;
}