#include <iostream>
#include <vector>
using namespace std;

int main()
{
	vector<int> bits;
	int T;
	cin >> T;

	int b;
	long long n;

	while (T--)
	{
		cin >> n >> b;
		bits.push_back((n >> b) & 1);
	}

	for (int const& bit : bits)
		cout << bit;

	return 0;
}