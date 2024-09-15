#include <iostream>
using namespace std;

int main()
{
	long long n;
	int b;
	cin >> n >> b;

	n &= ~(1 << b);

	cout << n;

	return 0;
}