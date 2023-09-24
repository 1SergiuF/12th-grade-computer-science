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

class Cat : public Animal {
public:
    Cat(std::string const& name) : name {name}
    {}

    void Meow()
    {
        std::cout << name << " is meowing...\n";
    }

private:
    std::string name;
};

int main()
{
    Animal *pa;
    Dog *pd = new Dog("Rex");

    /*
        Upcasting (convertsie implicita)
        Conversia unui pointer la un tip aflat mai jos in ierarhie
        spre un tip aflat mai sus in ierarhie
    */

   pa = pd;  // Upcasting
   pa->eat();

   Dog* pd1 = dynamic_cast<Dog*>(pa);
   if (pd1 != nullptr)
        pd1->Bark();
    else
        std::cout << "Nu exista caine!\n";
}