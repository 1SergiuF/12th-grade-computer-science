#include <iostream>
using namespace std;

int main()
{
	long long n;
	int b;
	cin >> n >> b;

	n = n | (1LL << b);

	cout << n;

	return 0;
}