#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int x; // valoarea citita
	int prima; // primul termen al sirului
	
	fin >> x; // citim primul termen
	prima = x;
	
	int poz_max = 0; // pozitia maxima a primului element din sir
	
	while (fin >> x) // continuam citirea
	{
		if (x >= prima)
			poz_max++;
	}
	
	cout << poz_max + 1; // afisam poz_max + 1 deoarece nu am numarat primul termen al sirului
	
	return 0;
}
