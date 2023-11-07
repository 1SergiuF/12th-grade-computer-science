#include <iostream>
using namespace std;

int n, m;
int a[103][103];

int main()
{
	int v_max = -1;
	bool ok = false;
	cin >> m >> n;
	
	for (int i = 1; i <= m; ++i)
		for (int j = 1; j <= n; ++j)
			cin >> a[i][j];
			
	for (int i = 1; i <= m; ++i)
	{
		for (int j = 1; j <= n; ++j)
			if (a[i][j] < 21 && a[i][j] > v_max)
			{
				ok = true;
				v_max = a[i][j];
			}
			
		if (ok == true) cout << v_max << '\n';
		else cout << "nu exista\n";
		
		ok = false;
		v_max = -1;
	}
	
	return 0;
}
