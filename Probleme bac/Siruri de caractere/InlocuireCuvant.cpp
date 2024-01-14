#include <fstream>
#include <cstring>
using namespace std;

ifstream fin("inlocuirecuvant.in");
ofstream fout("inlocuirecuvant.out");

const int N = 101;
const int NR_L = 11;
char aux[NR_L];

int main()
{
	char s[N];
	char a[NR_L], b[NR_L];
	
	fin >> a;
	fin >> b;
	fin.get();
	
	fin.getline(s, N);
	char t[N];
	strcpy(t, s);
	
	char* p = strtok(s, " ");
	int i = 0;
	while(p)
	{
		i += strlen(p) + 1;
		if (strcmp(p, a) == 0)
		{
			strcpy(aux, b);
			strcat(aux, " ");
			strcat(aux, t + i);
			strcpy(t + i - strlen(p) - 1, aux);
			i += strlen(b) - strlen(a);
		}
		
		p = strtok(nullptr, " ");
	}
	
	fout << t;
	return 0;
}
