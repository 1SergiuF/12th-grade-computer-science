#include <iostream>
using namespace std;

int main()
{
	int n;
	cin >> n;

	n &= ~(1 << 0);
	n &= ~(1 << 1);

	cout << n;

	return 0;
}