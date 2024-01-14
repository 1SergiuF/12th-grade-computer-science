#include <iostream>
#include <cstring>
using namespace std;

bool exista;
char ch[101];

int main()
{
	cin.getline(ch, 101);
	
	char* p = strtok(ch, " ");
	
	while (p)
	{
		bool gasit = true;
		bool ok = false;
		char u;
		for (int i = 0; p[i]; ++i)
		{
			if (ok == false)
			{
				if (p[i] == 'a' || p[i] == 'e' ||
					p[i] == 'i' || p[i] == 'o' ||
					p[i] == 'u')
				{
					u = p[i];
					ok = true;
				}
			}
			
			else
				if ((p[i] == 'a' || p[i] == 'e' ||
					p[i] == 'i' || p[i] == 'o' ||
					p[i] == 'u') && p[i] != u)
				{
					gasit = false;
					break;
				}
		}
		
		if (gasit == true && ok == true)
		{
			exista = true;
			cout << p << '\n';
		}
		
		p = strtok(nullptr, " ");
	}
	
	if (!exista) cout << "nu exista";
	
	return 0;
}
