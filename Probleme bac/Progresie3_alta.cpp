#include <fstream>
using namespace std;

ifstream fin("progresie3.in");
ofstream fout("progresie3.out");

const int N = 1001;
bool f[N];

int main()
{
	int n = 0;
	int r = 0;
	int x;
	int v_min = N;
	bool prog = true;
	
	while (fin >> x)
	{
		f[x] = true;
		if (v_min > x)
			v_min = x;
	}
		
	for (int i = v_min + 1; i <= N; ++i)
		if (f[i])
		{
			n = i;
			r = i - v_min;
			break;
		}
		
	int cnt = 0;
	for (int i = n + 1; i <= N; ++i)
	{
		++cnt;
		if (f[i])
		{
			if (cnt == r)
				cnt = 0;
			else
			{
				prog = false;
				break;
			}
		}
	}
	
	if (prog) fout << r;
	else fout << "NU";
	
	return 0;
}
