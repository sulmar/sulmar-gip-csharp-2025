using DecoratorPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Application;

internal class SalaryBuilder : ISalaryBuilder
{
    private ISalaryDecorator salary = new BaseSalary();

    public void AddSeniority()
    {
        salary = new SenioritySalaryDecorator(salary);
    }

    public void AddTraining(int ratio)
    {
        salary = new TrainingSalaryDecorator(ratio: 2, salary);
    }

    public void AddMentor()
    {
        salary = new MentorSalaryDecorator(salary);
    }

    public ISalaryDecorator Build()
    {
        return salary;
    }
}
