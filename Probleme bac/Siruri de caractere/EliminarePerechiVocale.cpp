#include <iostream>
#include <cstring>
using namespace std;

const int N = 256;
const char voc[] = {'a', 'e', 'i', 'o', 'u'};

int main()
{
	char a[N];
	char t[N];
	cin.getline(a, N);
	
	for (int i = 0; a[i]; ++i)
	{
		if (strchr(voc, a[i]))
		{
			int j = i + 1;
			int cnt = 1;
			while (a[j] != '\0' && a[j] != ' ' && strchr(voc, a[j]))
			{
				++cnt;
				++j;
			}
			
			if (cnt >= 2)
			{
				strcpy(t, a + i + cnt);
				strcpy(a + i, t);
			}
		}
	}
	
	cout << a;
	
	return 0;
}
