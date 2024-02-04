#include <iostream>
using namespace std;

int m, n;
int a[22][22];
bool ok;

int main()
{
	cin >> m >> n;
	ok = true;
	for (int i = 1; i <= m; ++i)
		for (int j = 1; j <= n; ++j)
			cin >> a[i][j];
			
	for (int i = 1; i <= m; ++i)
	{
		for (int j = 1, k = n; j < k; ++j, --k)
			if (a[i][j] != a[i][k])
			{
				ok = false;
				break;
			}
	}
	
	if (ok == false) cout << "NU";
	else cout << "DA";
	
	return 0;
}
