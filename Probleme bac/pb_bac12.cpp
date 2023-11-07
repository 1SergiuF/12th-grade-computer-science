#include <iostream>
using namespace std;

int joc(int n)
{
	int cnt = 0;
	for (int i = 2; i <= n; ++i)
		if (n % i == 0)
			++cnt;
			
	return cnt;
}

int main()
{
	cout << joc(12);
	
	return 0;
}
