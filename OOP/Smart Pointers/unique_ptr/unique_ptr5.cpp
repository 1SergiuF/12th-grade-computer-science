#include <iostream>
#include <string>
#include <memory>

class Student {
public:
    Student() {}

    Student(int age, std::string const& name, int grade) :
        age {age}, name {name}, grade {grade}
    {
        std::cout << __PRETTY_FUNCTION__ << '\n';
    }

    ~Student()
    {
        std::cout << __PRETTY_FUNCTION__ << '\n';
    }

    void PrintInfo() const noexcept
    {
        std::cout << "Age:   " << age << '\n'
                  << "Name:  " << name << '\n'
                  << "Grade: " << grade << '\n';
    }

private:
    int age;
    std::string name;
    int grade;
};

int main()
{
    std::unique_ptr<Student> ptr(new Student(18, "Marcel", 12));

    // Pointerul nu mai controleaza obiectul alocat
    Student* s = ptr.release();

    s->PrintInfo();

    // Suntem obligati sa gestionam manual distrugerea obiectului
    delete s;
}