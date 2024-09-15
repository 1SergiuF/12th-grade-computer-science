#include <iostream>
#include <cstring>
using namespace std;

int main()
{
	int n;
	char S[201];

	cin >> n;
	cin.get();
	cin.getline(S, 201);

	if (n > strlen(S))
		cout << "IMPOSIBIL";
	else
	{
		char* p = strtok(S, " ");
		int wrap = 0;

		while (p)
		{
			wrap = wrap + strlen(p);
			if (n - wrap == 0)
			{
				cout << p;
				cout << '\n';
				wrap = 0;
			}
			else if (n - wrap < 0)
			{
				wrap = wrap - strlen(p);
				for (int i = 1; i <= n - wrap; ++i)
					cout << '*';
				cout << '\n';
				cout << p << ' ';
				wrap = strlen(p) + 1;
			}
			else
			{
				cout << p << ' ';
				wrap++;
			}

			p = strtok(nullptr, " ");
		}
	}

	return 0;
}