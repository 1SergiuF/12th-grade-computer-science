#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int x; // valorile citite
	int l = 1; // lungimea secv. de valori egale

	fin >> x;
	int k = x; // retinem valoarea lui x
	bool ok = false; // verificam daca exista astfel de numere

	while (fin >> x)
	{
		if (x != k) // finalul secventei curente
		{
			if (l == 2)
			{
				cout << k << ' ';
				ok = true;
			}

			// vom incepe o noua secventa
			k = x;
			l = 1;
		}
		else
			++l;
	}

	if (l == 2)
	{
		cout << k << ' ';
		ok = true;
	}
	
	if (!ok) cout << "nu exista";

	return 0;
}