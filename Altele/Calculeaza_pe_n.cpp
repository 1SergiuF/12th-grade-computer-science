#include <iostream>
#include <algorithm>
using namespace std;

const int N = 1e6 + 1;
int n;
int dp[N];

int main()
{
	cin >> n;
	dp[2] = dp[3] = 1;

	for (int i = 4; i <= n; ++i)
	{
		if (i % 2 == 0 && i % 3 == 0)
			dp[i] = min({dp[i / 2], dp[i - 1], dp[i / 3]}) + 1;
		else
			if (i % 2 == 0)
				dp[i] = min(dp[i / 2], dp[i - 1]) + 1;
		else
			if (i % 3 == 0)
				dp[i] = min(dp[i / 3], dp[i - 1]) + 1;
		else
			dp[i] = dp[i - 1] + 1;
	}

	cout << dp[n];

	return 0;
}