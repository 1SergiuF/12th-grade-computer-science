#include <cstring>
#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.in");
ofstream fout("bac.out");

int v_max = -1;
int main()
{
	string s;
	int x, cnt = 0;
	
	while (fin >> x)
	{
		++cnt;
		x /= 10;
		int cif_z = x % 10;
		s += to_string(cif_z);
	}
	
	int frecv[11] = {0};
	int d[cnt] = {0};
	int z[cnt];
	
	for (int i = 0; i < cnt; ++i)
		z[i + 1] = s[i] - 48;
		
	for (int i = 1; i <= cnt; ++i)
	{
		frecv[z[i]]++;
		d[i] = frecv[z[i]];
		
		if (v_max < d[i])
			v_max = d[i];
	}
	
	for (int i = 1; i <= cnt; ++i)
		if (v_max == d[i])
			fout << i << ' ';
				
	return 0;
}
