/*
 * 	Vom citi cate o cifra din fisierul de intrare "bac.txt"
 * si verificam daca aceasta cifra, retinuta intr-o variabila
 * (x) este para sau nu. In caz afirmativ, afisam cifra pe ecran.
 * 
 * 	Algoritmul este eficient atat d.p.d.v al timpului de executare,
 * cat si a spatiului de memorie utilizat.
 * 
 * 	1) D.p.d.v al timpului de executare, complexitatea este O(n),
 * adica liniara, unde n este numarul valorilor din fisier, deoarece
 * datele de intrare se parcurg o singura data.
 * 
 * 	2) D.p.d.v al spatiului de memorie utilizat, complexitatea este
 * O(1), adica constanta, deoarece numarul de variabile pe care le
 * utilizeaza programul este mereu acelasi (1), adica constant. Altfel
 * spus, numarul acestora nu depinde de dimensiunea (n) a datelor de
 * intrare.
 * 
 * */

#include <fstream>
#include <iostream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int x; // cifrele citite
	
	while (fin >> x) // citim cifrele
	{
		if (x % 2 == 0) // daca cifra este para
			cout << x << ' ';
	}
	
	return 0;
}
