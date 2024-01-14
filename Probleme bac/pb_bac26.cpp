#include <iostream>
using namespace std;

int a[10][10];

int main()
{
	for(int i = 0; i < 4; i++)
		for(int j = 0; j < 5; j++)
		{
			if ((i + j) % 3 == 0) continue;
			if (i + j < 3) a[i][j] = i + j;
			if (i + j > 3)
			{
				int div = 0;
				for (int d = i + j; d >= 1; --d)
					if (d % 3 == 0)
					{
						div = d;
						break;
					}
					
				a[i][j] = (i + j) - div;
			}
		}
		
	for (int i = 0; i < 4; ++i)
	{
		for (int j = 0; j < 5; ++j)
			cout << a[i][j] << ' ';
		cout << '\n';
	}
	
	return 0;
}
