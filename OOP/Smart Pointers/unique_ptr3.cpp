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
    std::unique_ptr<Student> ptr1(new Student(18, "Marcel", 12));
    ptr1->PrintInfo();

    // Copierea nu merge
    // std::unique_ptr<Student> ptr2 = ptr1; -> NU !

    // Mutarea resurselor prin copiere merge
    std::unique_ptr<Student> ptr2 = std::move(ptr1);
    if (!ptr1)
        std::cout << "ptr1 nu mai controleaza resurse !\n";

    ptr2->PrintInfo();
}