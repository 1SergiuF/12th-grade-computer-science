#include <iostream>
#include <functional>

int main()
{
	int n;
	std::cin >> n;

	// using class template function<>
	std::function<int(int)> fact1 = [&fact1](int n) -> int 
	{
		if (n == 0)
			return 1;

		return n * fact1(n - 1);
	};

	std::cout << fact1(n);

	return 0;
}