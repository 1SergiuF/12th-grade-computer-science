#include <iostream>
using namespace std;

int main()
{
	int n;
	int a[51][51];
	
	cin >> n;
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
			cin >> a[i][j];
			
	int s = 0;
	int cnt = 2;
	int m;
	if (n % 2 == 1) m = n / 2 + 1;
	else m = n / 2;
	
	for (int j = n - 1; j >= n / 2; --j)
	{
		if (cnt == m) break;
		for (int i = cnt + 1; i <= n - cnt; ++i)
			s = s + a[i][j];
			
		++cnt;
	}
	
	cout << s;
	
	return 0;
}
