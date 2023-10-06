// namespace Kros.Mutation.Tests;

// public class BonusComputationServiceShould
// {
//     [Theory]
//     [InlineData(3300, 1, 0, 330)]
//     [InlineData(3300, 1, 1, 215)]
//     public void CalculateBonus_WhenEmployeeIsValid(
//         decimal salary,
//         int childrenNumber,
//         int extraShiftsNumber,
//         decimal expectedBonus)
//     {
//         var mockEmployee = new Employee
//         {
//             Name = "Jhon Doe",
//             Address = "Around the world",
//             MailAddress = "jhon.doe@email.com",
//             Salaray = salary,
//             Children = childrenNumber,
//             ExtraShifts = extraShiftsNumber
//         };

//         var employeeService = new BonusComputationService(Logger.Default);

//         var result = employeeService.CalculateBonus(mockEmployee);

//         expectedBonus.Should().Be(result);
//     }

//     [Fact]
//     public void CalculateBonus_WhenEmployeeIsNull()
//     {
//         var employeeService = new BonusComputationService(Logger.Default);

//         var result = employeeService.CalculateBonus(null);

//         result.Should().Be(0);
//     }
// }