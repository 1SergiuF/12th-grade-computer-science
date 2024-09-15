#include <iostream>
#include <cstring>
using namespace std;

char a[101];
int main()
{
	cin.getline(a, 101);
	bool negativ = false;
	int poz_neg = 0;
	int len = 1;

	for (int i = 0; a[i]; ++i)
	{
		if (a[i] == '-')
		{
			negativ = true;
			poz_neg = i;
		}

		if (negativ == true && a[i] != ' ')
			++len;

		else
			if (negativ == true && a[i] == ' ')
			{
				strcpy(a + poz_neg, a + poz_neg + len);
				negativ = false;
				len = 1;
			}

	}

	cout << a;

	return 0;
}