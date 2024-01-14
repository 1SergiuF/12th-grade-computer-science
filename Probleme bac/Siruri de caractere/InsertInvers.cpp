#include <iostream>
#include <cstring>
#include <algorithm>
using namespace std;

const int N = 256;

void InversCuv(char aux[]);
int main()
{
	char a[N];
	char c[N][30];
	
	cin.getline(a, N);
	
	char* p = strtok(a, " ");
	int n = 0;
	
	while (p)
	{
		strcpy(c[n++], p);
		p = strtok(nullptr, " ");
	}
	
	for (int i = 0; i < n; ++i)
	{
		cout << c[i] << ' ';
		InversCuv(c[i]);
		cout << c[i] << ' ';
	}
		
	return 0;
}

void InversCuv(char aux[])
{
	for (int i = 0, j = strlen(aux) - 1; i < j; i++, j--)
		swap(aux[i], aux[j]);
}
