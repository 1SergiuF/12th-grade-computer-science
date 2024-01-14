#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("numere.txt");

int x; // numerele din fisier
int f[10]; // sir caracteristic

int main()
{
	while (fin >> x)
	{
		while (x)
		{
			f[x % 10]++; // incrementam nr. de ap. al cifrei respective
			x = x / 10;
		}
	}
	
	for (int i = 9; i >= 0; --i)
		if (f[i]) // daca cifra i apare in fisier cel putin o data
		{
			while (f[i]--)
				cout << i; // afisam cifra de cate ori apare in fisier
		}
		
	return 0;
}
