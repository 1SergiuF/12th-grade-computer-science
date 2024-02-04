#include <iostream>
using namespace std;

int Oglindit(int x)
{
	int ogl = 0;
	while (x)
	{
		ogl = ogl * 10 + x % 10;
		x = x / 10;
	}
	
	return ogl;
}

void imog(int x, int y, int& rez)
{
	int impx = 0, impy = 0;
	while (x)
	{
		if ((x % 10) % 2 == 1)
			impx = impx * 10 + x % 10;
		x = x / 10;
	}
	
	while (y)
	{
		if ((y % 10) % 2 == 1)
			impy = impy * 10 + y % 10;
		y = y / 10;
	}
	
	if (Oglindit(impx) == impy && (impx != 0 || impy != 0))
		rez = 1;
	else
		rez = 0;
}

int main()
{
	int x, y;
	cin >> x >> y;
	
	int rez;
	imog(x, y, rez);
	
	cout << rez;
	
	return 0;
}
