/*
    static_cast
    Comnversia are loc compile-time
    poate converti un tip la alt tip de date
    dar tipurile sa fie compatibile.
    Ex:  int* -> char*

*/

#include <iostream>

class Animal {
public:
    virtual void eat()
    {
        std::cout << __PRETTY_FUNCTION__ << '\n';
    }

    virtual ~Animal() = default;    // evitam object slicing
};

class Dog : public Animal {
public:
    Dog(std::string const& name) : name {name}
    {}

    void eat() override
    {
        std::cout << __PRETTY_FUNCTION__ << '\n';
    }

    void Bark()
    {
        std::cout << this->name << " is barking...";
    }

private:
    std::string name;
};

int main()
{
    Animal *pa;
    Dog *pd = nullptr;

    /*
        Upcasting (conversie implicita)
        Conversia unui pointer la un tip aflat mai jos in ierarhie
        spre un tip aflat mai sus in ierarhie
    */

    pa = pd;  // Upcasting
    pa->eat();

    // pa->Bark(); -> eroare

    // Dog *pd1 = (Dog*) pa; // OK, dar stil C

    Dog* pd1 = static_cast<Dog*>(pa);
    pd1->Bark();
}