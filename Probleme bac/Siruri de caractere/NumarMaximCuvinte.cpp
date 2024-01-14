#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("cuvmax.in");
ofstream fout("cuvmax.out");

const int N = 256;

int main()
{
	int n;
	int cuv_max = 0;
	char prop_max[N];
	char aux[N];
	char a[N];
	
	fin >> n;
	fin.get();
	
	for (int i = 0; i < n; ++i)
	{
		fin.getline(a, N);
		strcpy(aux, a);
		char* p = strtok(aux, " ");
		
		int cnt = 0;
		while (p)
		{
			++cnt;
			p = strtok(nullptr, " ");
		}
		
		if (cnt > cuv_max)
		{
			cuv_max = cnt;
			strcpy(prop_max, a);
		}
	}
	
	fout << prop_max;
	
	return 0;
}
