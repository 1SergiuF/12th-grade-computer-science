/*
    dynamic_cast
    De obicei se face un Downcast
    Se foloseste pentru tipuri polimorfice
    operatorul face verificari run-time
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

void Convert(Animal* pa)
{
    // daca stiu precis ca soseste o pisica (se poate folosi static_cast)

    Cat* pc = dynamic_cast<Cat*>(pa);
    if (pc != nullptr)
        pc->Meow();
    else
        std::cout << "Nu exista pisica !";
}

int main()
{
    Animal* pa;
    Cat* pc = new Cat("Fifi");
    Convert(pc);
    Convert(new Dog("Pufi"));
}