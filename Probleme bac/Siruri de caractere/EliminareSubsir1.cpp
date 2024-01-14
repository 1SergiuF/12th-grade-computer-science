#include <iostream>
#include <cstring>
using namespace std;

const int N = 256;

int main()
{
	char a[N], t[N], aux[N][N];
	int cnt = 0;
	
	cin.getline(a, N);
	cin.getline(t, N);
	char* occ = nullptr;
	
	for (int i = strlen(a) - 1; i >= 0; --i)
	{
		if (a[i] == ' ')
		{
			strcpy(aux[cnt], a + i + 1);
			occ = strstr(aux[cnt], t);
			
			if (occ)
			{
				strcpy(aux[cnt] + strlen(aux[cnt]) - strlen(occ), aux[cnt] + strlen(aux[cnt]) - strlen(occ) + strlen(t));
				a[i] = '\0';
				break;
			}
			
			a[i] = '\0';
			cnt++;
		}
		
		else
			if (i == 0)
			{
				strcpy(aux[cnt], a + i);
				occ = strstr(aux[cnt], t);
				if (occ)
					strcpy(aux[cnt] + strlen(aux[cnt]) - strlen(occ), aux[cnt] + strlen(aux[cnt]) - strlen(occ) + strlen(t));
				a[i] ='\0';	
				cnt++;			
			}
	}
	
	cout << a;
	cout << ' ';
	for (int i = cnt; i >= 0; --i)
		cout << aux[i] << ' ';
		
	return 0;
}
