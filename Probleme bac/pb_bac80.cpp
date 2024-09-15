#include <iostream>
#include <cstring>
using namespace std;

int main()
{
	int n;
	cin >> n;
	cin.get();
	
	char c[21][21];
	char ult[21];
	
	for (int i = 1; i <= n; ++i)
	{
		cin.getline(c[i], 21);
		strcpy(ult, c[i]);
	}
	
	for (int i = 1; i < n; ++i)
	{
		char t[21] = "";
		for (int j = 0; j < (int)strlen(ult); ++j)
			t[j] = c[i][j];
		
		int cnt = 0;
		for (int j = 0; j < (int)strlen(ult); ++j)
			if (t[j] == ult[j])
				++cnt;
				
		if (cnt == (int)strlen(ult))
			cout << c[i] << ' ';
	}
	
	return 0;
}
