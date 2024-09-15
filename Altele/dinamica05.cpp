#include <iostream>
using namespace std;

const int N = 1001;
const int MOD = 123457;
int n, p;

int dpa[N];
int a[N], A[N];
int dpc[N][N];

int main()
{
	cin >> n >> p;

	dpa[1] = 52;
	for (int i = 2; i <= n; ++i)
		dpa[i] = (dpa[i - 1] * 50) % MOD;

	cout << dpa[n] << ' ';

	a[1] = A[1] = 26;
	for (int i = 2; i <= n; ++i)
	{
		a[i] = 26 * (a[i - 1] + A[i - 1]) % MOD;
		A[i] = 26 * A[i - 1] % MOD;
	}
		

	cout << (a[n] + A[n]) % MOD << ' ';

	dpc[1][1] = 5;
	dpc[1][0] = 21;

	for (int i = 2; i <= n; ++i)
		dpc[i][0] = (dpc[i - 1][0] * 21) % MOD;

	for (int i = 2; i <= n; ++i)
		for (int j = 1; j <= p; ++j)
			dpc[i][j] = (21 * dpc[i - 1][j] + 5 * dpc[i - 1][j - 1]) % MOD;

	int S = 0;
	for (int j = 0; j <= p; ++j)
		S = (S + dpc[n][j]) % MOD;

	cout << S;

	return 0;
}