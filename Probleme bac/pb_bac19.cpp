/*
 * 	Deoarece fisierul "bac.in" nu contine un numar exact de valori, vom citi
 * una cate una (x) intr-o structura repetitiva while pana cand nu mai exista
 * valori in fisier. Incrementam lungimea secventei de la citire (l) si
 * verificam daca am citit o valoare negativa. Daca am citit o valoare
 * negativa , verificam daca este prima valoare negativa citita sau nu.
 * In caz afirmativ, incrementam numarul de valori negative (cnt) si
 * atribuim pozitiei valorii respective (p) lungimea curenta. Altfel, daca am
 * ajuns pe o urmatoare negativa, verificam daca am gasit o secventa de lungime
 * maxima si o salvam intr-o variabila (lmax). Deoarece va incepe o noua secventa,
 * lungimea secventei (l) va primi diferenta dintre lungmea curenta si pozitia
 * ultimei valori negative. Cand am terminat citirea valorilor, mai verificam
 * o data daca exista o lungime maxima deoarece exista posibilitatea ca lungimea sa
 * fi fost incrementata in continuare dupa citirea ultimei valori negative.
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
 *    le utilizeaza programul este mereu acelasi (5), adica constant.
 *    Altfel spus, numarul acestora nu depinde de dimensiunea (n) a
 *    datelor de intrare.
 * 
 * */

#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.in");

int main()
{
	int p = 0; // pozitia numerelor negative
	int cnt = 0; // numarul de valori negative
	int x; // valoarea citita
	
	int l = 0; // lungimea unei secvente
	int lmax = 0; // lungimea maxima
	
	while (fin >> x)
	{
		l++;
		if (x < 0 && cnt > 0)
		{
			if (l - 1 > lmax)
				lmax = l - 1; // scadem 1 deoarece am incrementat
							  // si o a doua valoare negativa in secventa curenta
				
			l = l - p; // lungimea noua este diferenta dintre lungimea curenta
					   // si pozitia ultimei valori negative gasite
					   
			p = l;	// pozitia valorii negative primeste lungimea curenta
			cnt++;
		}
		else
			if (x < 0 && cnt == 0)
			{
				cnt++;
				p = l;
			}
	}
	
	if (l > lmax) // mai verificam o data daca exista un maxim deoarece
				  // exista posibilitatea ca lungimea sa fi fost incrementata in continuare
				  // dupa citrea ultimei valori negative
		lmax = l;
		
	cout << lmax;
	
	return 0;
}
