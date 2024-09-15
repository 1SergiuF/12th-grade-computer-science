#include <iostream>
using namespace std;

const int N = 1e6 + 1;
bool C[N];
int n;

void Erathostene();

int main()
{
	cin >> n;

	Erathostene();

	for (int i = 2; i <= n; ++i)
		if (!C[i])
			cout << i << ' ';

	return 0;
}

void Erathostene()
{
	C[0] = C[1] = true;
	for (int i = 2; i * i <= n; ++i)
		for (int j = i; i * j <= n; ++j)
			C[i * j] = true;
}