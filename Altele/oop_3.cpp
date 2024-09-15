#include <bits/stdc++.h>
using namespace std;

class Stiva
{
private:
    // variabile membre
    deque<int> container;
    deque<pair<int, int>> maxime;
public:
    // depune valoarea x in stiva
    void Push(int x)
    {
    	if (container.empty())
    		maxime.push_front(make_pair(x, x));
    	else
    	{
    		int vmax = max(x, maxime.front().second);
    		maxime.push_front(make_pair(x, vmax));
    	}

        container.push_front(x);
    }
    // elimina un element din stiva daca stiva nu e vida
    void Pop()
    {
    	if (container.empty()) return;

        container.pop_front();
        maxime.pop_front();
    }
    // returneaza varful stivei
    // daca stiva este vida, returneaza -1
    int Top()
    {
        if (container.empty()) return -1;
        return container.front();
    }
    // returneaza valoarea maxima din stiva
    // daca stiva este vida, returneaza -1
    int Max()
    {
        if (container.empty()) return -1;
        return maxime.front().second;
    }
    // returneaza 1 daca stiva este vida
    // returneaza 0 daca stiva nu e vida
    int Empty()
    {
        return container.empty();
    }
};

int main()
{
    Stiva w;
    w.Push(4);
    w.Push(2);
    w.Push(5);
    w.Push(1);
    cout << w.Top() << " " << w.Max() << "\n"; // afiseaza 1 5
    w.Pop();
    w.Pop();
    cout << w.Top() << " " << w.Max() << "\n"; // afiseaza 2 4
    return 0;
}