#include <iostream>
#include <algorithm>
#include <iomanip>
using namespace std;

struct Obiect {
	double gr, val;

	friend istream& operator >> (istream& is, Obiect& ob)
	{
		return is >> ob.gr >> ob.val;
	}

	bool operator < (Obiect const& ob) const noexcept
	{
		return (val * ob.gr > gr * ob.val);
	}
};

const int N = 1001;
int n;
int G;
Obiect ob[N];

void CitesteOb();
void Greedy();
void SortOb();

int main()
{
	CitesteOb();
	Greedy();

	return 0;
}

void CitesteOb()
{
	cin >> n >> G;

	for (int i = 1; i <= n; ++i)
		cin >> ob[i];
}

void Greedy()
{
	SortOb();
	int val_max = 0;
	int gc = 0;

	for (int i = 1; i <= n; ++i)
	{
		if (gc + ob[i].gr <= G)
		{
			val_max += ob[i].val;
			gc += ob[i].gr;
		}

		else
		{
			double val = ob[i].val * (G - gc) / ob[i].gr;
			val_max += val;
		}
	}

	cout << fixed << setprecision(2) << val_max;
}

void SortOb()
{
	Obiect aux;

	for (int i = 1; i < n; ++i)
		for (int j = i + 1; j <= n; ++j)
			if (ob[i].val * ob[j].gr < ob[j].val * ob[i].gr)
			{
				aux = ob[i];
				ob[i] = ob[j];
				ob[j] = aux;
			}
}