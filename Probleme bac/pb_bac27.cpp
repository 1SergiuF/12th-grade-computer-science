#include <iostream>
using namespace std;

void divizor(int a, int b, int k, int& nr)
{
	for (int i = a; i <= b; ++i)
		if (i % k == 0 && i % 10 == k)
			nr++;
}

int main()
{
	int a, b, k, nr = 0;
	
	cin >> a >> b >> k;
	
	divizor(a, b, k, nr);
	
	cout << nr;
	
	return 0;
}
