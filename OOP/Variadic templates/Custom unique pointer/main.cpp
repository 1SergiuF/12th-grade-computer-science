#include <iostream>
#include <string>
#include "my_unique_ptr.h"

class Developer {
public:
    Developer() {}

    Developer(std::string const& name, std::string const& position, int salary) :
        name {name},
        position {position},
        salary {salary}
    {}

    friend std::ostream& operator << (std::ostream& os, Developer const& d)
    {   
        return os << d.name << ' ' << d.position << ' ' << d.salary;
    }

private:
    std::string name;
    std::string position;
    int salary;
};

int main()
{
    my_unique_p<Developer> d1(new Developer("Sergiu", "Backend developer", 20000));
    std::cout << *d1 << '\n';

    auto d2 = make_my_unique<Developer>("Gabi", "Frontend developer", 15000);

    // d1 = d2 -> NO !
    d1 = std::move(d2);
    std::cout << *d1 << '\n';

    if (!d2)  // operatorul bool
        std::cout << "Smart pointerul d2 nu mai gestioneaza un obiect!\n";
}