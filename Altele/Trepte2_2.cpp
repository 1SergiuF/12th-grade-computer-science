#include <iostream>
using namespace std;

const int MOD = 9001;
const int Dim = 1e6 + 1;
int trepte[Dim];
int sum;

int main()
{
	int n, k;
	cin >> n >> k;
	trepte[1] = 1;
	sum = 1;

	for (int i = 2; i <= k; ++i)
	{
		trepte[i] = sum;
		sum += trepte[i];
		sum %= MOD;
	}

	for (int i = k + 1; i <= n; ++i)
	{
		trepte[i] = sum;
		sum += trepte[i] - trepte[i - k] + MOD;
		sum %= MOD;
	}

	cout << trepte[n];

	return 0;
}