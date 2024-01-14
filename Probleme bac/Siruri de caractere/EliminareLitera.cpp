#include <iostream>
#include <cstring>
using namespace std;

const int N = 101;

int main()
{
	char a[N];
	char t[N];
	cin.getline(a, N);
	
	char c[N][30];
	bool ok = false;
	int n = 0;
	
	char* p = strtok(a, " ");
	
	while (p)
	{
		if (strlen(p) % 2 == 1 && strlen(p) >= 3)
		{
			ok = true;
			int mij = strlen(p) / 2;
			strcpy(t, p + mij + 1);
			strcpy(p + mij, t);
		}
		
		strcpy(c[n++], p);
		
		p = strtok(nullptr, " ");
	}
	
	if (!ok) cout << "nu exista";
	else
		for (int i = 0; i < n; ++i)
			cout << c[i] << ' ';
		
	return 0;
}
