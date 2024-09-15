#include <iostream>
#include <set>
using namespace std;

int n, k;
int a[21][21];
set<int> rows;

int main()
{
	cin >> n >> k;
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
			cin >> a[i][j];
			
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
			for (int q = 1; q <= n; ++q)
				if (a[k][q] == a[i][j] && i != k)
				{
					rows.insert(i);
					break;
				}
				
	for (auto const& r : rows)
		cout << r << ' ';
		
	return 0;
}
