/*
 * 	  Deoarece fisierul bac.txt contine numere din
 * intervalul [2, 1000000], pe a doua linie se va citi
 * cate o valoare (x) de n ori, in locul retinerii valorilor
 * intr-un tablou unidimensional.
 * 	  Declaram o variabila in care retinem valorile maxime la
 * fiecare pozitie in sir (v_max), actualizand-o corespunzator
 * la fiecare citire a unei noi valori x. Deoarece citirea
 * valorilor se face in fisier, iar afisarea pe ecran, afisam
 * valoarea maxima odata cu citirea unei noi valori, dupa ce
 * am actualizat-o sau nu.
 * _________________________________________________________
 * 
 * 	  Algoritmul este eficient atat din punct de vedere al
 * timpului de executare, cat si a spatiului de memorie utilizat.
 * 
 * 1)	D.p.d.v al timpului de executare, complexitatea este O(n),
 * 	  adica liniara, unde n este numarul valorilor din fisier,
 *    deoarece datele de intrare se parcurg o singura data.
 * 
 * 2)   D.p.d.v al spatiului de memorie utilizat, complexitatea este
 *    O(1), adica constanta, deoarece numarul de variabile pe care
 *    le utilizeaza programul este mereu acelasi (3), adica constant.
 *    Altfel spus, numarul acestora nu depinde de dimensiunea (n) a
 *    datelor de intrare.
 * 
 * */

#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.txt");

int main()
{
	int n;
	fin >> n;
	int x;	// cele n valori citite care constituie sirul
	
	int v_max;	// valoarea maxima din sir la fiecare pozitie
	v_max = -1;
	
	while (n--)
	{
		fin >> x;
		if (v_max < x)
		{
			v_max = x;	// aflam maximul
			cout << x << ' ';
		}
		else cout << v_max << ' ';
	}
	
	return 0;
}
