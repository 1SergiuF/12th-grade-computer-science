#include <iostream>
using namespace std;

int ElimZTRec(int n);

int main()
{
	int n;
	cin >> n;

	cout << ElimZTRec(n);
	
	return 0;
}

int ElimZTRec(int n)
{
	if (n % 10 != 0)
		return n;

	return ElimZTRec(n / 10);
}