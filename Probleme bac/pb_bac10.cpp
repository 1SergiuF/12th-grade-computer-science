#include <iostream>
using namespace std;

int a[23][23];
int n, m;
bool ok = false;

int main()
{
	cin >> m >> n;
	
	for (int i = 1; i <= m; ++i)
		for (int j = 1; j <= n; ++j)
			cin >> a[i][j];
			
	for (int i = 1; i <= m; ++i)
		for (int j = 1; j <= m; ++j)
			if (a[i][1] == a[j][n] && a[i][1])
			{
				ok = true;
				cout << a[i][1] << ' ';
				break;
			}
			
	if (!ok) cout << "nu exista";
	
	return 0;
}
