namespace Kros.Mutation;

public class BonusComputationService
{
    private readonly ILogger _logger;

    public BonusComputationService(ILogger logger)
    {
        _logger = logger;
    }

    public decimal CalculateBonus(Employee? employee)
    {
        if (employee == null || string.IsNullOrEmpty(employee.Name) || employee.Salaray == 0)
        {
            _logger.Log("Invalid Employee");
            return 0;
        }

        if (employee.ExtraShifts > 0)
        {
            return employee.Salaray / 20 * employee.Children + employee.ExtraShifts * 50;
        }
        else if (employee.Children > 0)
        {
            return employee.Salaray / 10 * employee.Children;
        }

        return 100;
    }
}