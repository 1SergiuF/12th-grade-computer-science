#include <fstream>
#include <iostream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int cnt = 0; // numarul de numere impare
	int x; // valorile citite
	
	int f_last = 0; // penultimul numar impar
	int s_last = 0; // ultimul numar impar
	
	while (fin >> x)
	{
		if (x % 2 == 1) // daca numarul este impar
		{
			cnt = cnt + 1;
			f_last = s_last; // valoarea penultimului numar impar
							 // primeste valoarea curenta a ultimului
							 // numar impar gasit
							 
			s_last = x; // valoarea ultimului numar impar primeste
						// valoarea numarului impar citit
		}
	}
	
	if (cnt < 2) cout << "nu exista";
	else cout << f_last << ' ' << s_last;
	
	return 0;
}
