#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int x;
	int varf_loc = -1;
	int cnt = 0;
	int pmax = 0;
	
	while (fin >> x)
	{
		cnt++;
		if (varf_loc < x)
		{
			pmax = cnt;
			varf_loc = x;
			cout << varf_loc << ' ';
		}
		
		else if (varf_loc == x && cnt - pmax == 1)
		{
			pmax = cnt;
			varf_loc = x;
			cout << varf_loc << ' ';
		}
	}
	
	return 0;
}
