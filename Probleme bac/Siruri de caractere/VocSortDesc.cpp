#include <iostream>
#include <cstring>
#include <algorithm>
using namespace std;

const int N = 256;
int nrvoc[N];

int main()
{
	char a[N];
	char c[N][N];
	
	cin.getline(a, N);
	
	char* p = strtok(a, " ");
	
	int cnt = 0;
	while (p)
	{
		strcpy(c[cnt], p);
		for (int i = 0; p[i]; ++i)
			if (p[i] == 'a' || p[i] == 'e' ||
				p[i] == 'i' || p[i] == 'o' ||
				p[i] == 'u' || p[i] == 'A' ||
				p[i] == 'E' || p[i] == 'O' ||
				p[i] == 'U' || p[i] == 'I')
					nrvoc[cnt]++;
				
		cnt++;
		p = strtok(nullptr, " ");
	}
	
	for (int i = 0; i < cnt - 1; ++i)
	{
		for (int j = i + 1; j < cnt; ++j)
		{
			if (nrvoc[i] < nrvoc[j])
			{
				swap(c[i], c[j]);
				swap(nrvoc[i], nrvoc[j]);
			}
			else
				if (nrvoc[i] == nrvoc[j] &&
					strlen(c[i]) < strlen(c[j]))
					{
						swap(c[i], c[j]);
						swap(nrvoc[i], nrvoc[j]);
					}
						
			else
				if (strlen(c[i]) == strlen(c[j]))
				{
					for (int k = 0; c[i][k] && c[j][k]; ++k)
					{
						if ((isupper(c[i][k]) && isupper(c[j][k])) ||
							(islower(c[i][k]) && islower(c[j][k])))
						{
							if (c[i][k] > c[j][k])
							{
								swap(c[i], c[j]);
								swap(nrvoc[i], nrvoc[j]);
								break;
							}
						}
						
						else
							if ((isupper(c[i][k]) && islower(c[j][k])) ||
								(islower(c[i][k]) && isupper(c[j][k])))
							{
								char ci = tolower(c[i][k]);
								char cj = tolower(c[j][k]);
								
								if (ci > cj)
								{
									swap(c[i], c[j]);
									swap(nrvoc[i], nrvoc[j]);
									break;
								}
							}
					}
				}
		}
		
		cout << c[i] << '\n';
	}
	
	cout << c[cnt - 1];
	
	return 0;
}
