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

    std::unique_ptr<Student> ptr2(new Student(18, "Emi", 12));

    // Atribuirea nu merge
    // ptr1 = ptr2; -> NU !

    // Mutarea resurselor prin atribuire merge
    ptr1 = std::move(ptr2);
    ptr1->PrintInfo();
}