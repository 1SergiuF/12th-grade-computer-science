#include <iostream>
#include <cstring>
#include <string>
using namespace std;

int main()
{
	string str;
	string str_modificat;

	cin >> str;
	for (size_t i = 0; i < str.size(); ++i)
	{
		if (str[i] != ' ')
			str_modificat += str[i] - 13;
	}
	cout << str_modificat;

	return 0;
}