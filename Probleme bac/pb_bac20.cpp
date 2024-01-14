#include <iostream>
using namespace std;

void afisare(int x, int y, int k)
{
	int d = y - x + 1;
	
	for (int i = x; i <= y; i += k)
	{
		if (d >= k)
		{
			for (int j = i; j < i + k; ++j)
				cout << j << ' ';
			cout << "* ";
			d = d - k;
		}
		
		else
		{
			while (d--)
				cout << i++ << ' ';
				
			cout << '*';
		}
	}
}

int main()
{
	int x, y, k;
	
	cin >> x >> y >> k;
	afisare(x, y, k);
	
	return 0;
}
