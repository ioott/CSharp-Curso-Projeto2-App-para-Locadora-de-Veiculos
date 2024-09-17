using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }

    //10 - Crie o construtor de `Rent` seguindo as regras de negócio
    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        Vehicle = vehicle;
        Person = person;
        DaysRented = daysRented;

        // Cálculo do preço
        if (person is LegalPerson)
        {
            Price = vehicle.PricePerDay * daysRented * 0.9; // Desconto de 10% para PJ
        }
        else
        {
            Price = vehicle.PricePerDay * daysRented; // Preço normal para PF
        }

        Status = RentStatus.Confirmed; // Status inicial
        Vehicle.IsRented = true; // Veículo alugado
        Person.Debit += Price; // Atualiza o débito da pessoa
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Cancel()
    {
        Status = RentStatus.Canceled;
    }

    //11 - Implemente os métodos de `cancelar` e `finalizar` um aluguel
    public void Finish()
    {
        Status = RentStatus.Finished;
    }
}