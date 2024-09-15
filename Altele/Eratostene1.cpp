#include <fstream>
#include <bitset>
using namespace std;

ifstream fin("eratostene1.in");
ofstream fout("eratostene1.out");

const int N = 500001;
bitset<N> C;
int n;
int x;
int nr_prime;

void Erathostene();

int main()
{
	fin >> n;
	Erathostene();

	for (int i = 1; i <= n; ++i)
	{
		fin >> x;
		if (!C[x / 2] && x % 2 == 1)
			++nr_prime;
	}

	fout << nr_prime;

	return 0;
}

void Erathostene()
{
	C[0] = C[1] = true;
	C[2] = false;
	for (int i = 3; i * i <= N; i += 2)
		for (int j = 3 * i; j * j <= N; j += 2 * i)
			C[j / 2] = true;
}