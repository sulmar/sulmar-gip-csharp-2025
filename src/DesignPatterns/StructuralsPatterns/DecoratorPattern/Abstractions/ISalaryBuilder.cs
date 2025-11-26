namespace DecoratorPattern.Abstractions;

interface ISalaryBuilder
{
    void AddSeniority();
    void AddTraining(int ratio);
    void AddMentor();
    ISalaryDecorator Build();
}
