#include <iostream>
#include <cstring>
using namespace std;

int main()
{
	char a[51];
	char t[51];
	cin.getline(a, 51);
	
	for (int i = 0; a[i]; ++i)
	{
		if (!isalpha(a[i]))
		{
			strcpy(t, a + i + 1);
			strcpy(a + i, t);
			i--;
		}
	}
	
	cout << a;
	
	return 0;
}
