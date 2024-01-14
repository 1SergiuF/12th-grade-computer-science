#include <iostream>
#include <algorithm>
#include <cstring>
using namespace std;

const int N = 21;

int main()
{
	int n, k;
	char c[N][N];
	
	cin >> n;
	cin.get();
	
	char ch[N];
	for (int i = 0; i < n; ++i)
	{
		cin.getline(ch, N);
		strcpy(c[i], ch);
	}
	
	cin >> k;
	
	for (int i = 0; i < n; ++i)
		if ((int)strlen(c[i]) != k)
		{
			for (int j = i + 1; j < n; ++j)
				if ((int)strlen(c[j]) == k)
					swap(c[i], c[j]);
		}
		
	for (int i = 0; i < n; ++i)
		cout << c[i] << ' ';
		
	return 0;
}
