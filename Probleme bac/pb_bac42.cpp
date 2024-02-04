#include <iostream>
using namespace std;

void frate(int x, int& y)
{
	int p = 1;
	y = 0;
	
	if (x == 0)
	{
		y = -1;
		return;
	}
	
	while (x != 0)
	{
		if (x % 10 == 9)
		{
			y = -1;
			break;
		}
		
		y = (y + (x % 10) * p) + p;
		p = p * 10;
		x = x / 10;
	}
}

int main()
{
	int x, y;
	
	cin >> x;
	
	frate(x, y);
	
	cout << y;
	
	return 0;
}
