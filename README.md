# Rent Cars - Sistema de Aluguel de Veículos

Este projeto implementa um sistema para controle de aluguel de veículos, desenvolvido em **C#**. O objetivo é gerenciar o processo de aluguel, incluindo a criação de diferentes tipos de veículos e clientes, e as regras de negócio para calcular os preços e gerenciar os status de aluguel.

## Estrutura do Projeto

O projeto está dividido nas seguintes partes:

### Models
- **Vehicle.cs**: Classe abstrata base para veículos.
  - **Car.cs**: Classe derivada para carros.
  - **Truck.cs**: Classe derivada para caminhões.
  - **Motorcycle.cs**: Classe derivada para motocicletas.
- **Person.cs**: Classe abstrata base para clientes.
  - **PhysicalPerson.cs**: Classe derivada para pessoas físicas.
  - **LegalPerson.cs**: Classe derivada para pessoas jurídicas.
- **Rent.cs**: Classe responsável por gerenciar o processo de aluguel.

## Requisitos do Projeto

### 1. Struct para Cores
- Arquivo: `src/RentCars/Types/Structs/Color.cs`
- Atributos:
  - `Name` (string)
  - `Hex` (string)

### 2. Enum FuelType
- Arquivo: `src/RentCars/Types/Enums/FuelType.cs`
- Tipos:
  - `Alcohol` = 10
  - `Gasoline` = 20
  - `Flex` = 30
  - `Diesel` = 40
  - `Electric` = 50
  - `Hybrid` = 60

### 3. Classe Vehicle
- Arquivo: `src/RentCars/Models/Vehicle.cs`
- Propriedades:
  - `Brand` (string) - Padrão: ""
  - `Model` (string) - Padrão: ""
  - `Price` (decimal)
  - `Fuel` (FuelType)
  - `EngineCapacity` (int)
  - `MainColor` (Color)
  - `Year` (int)
  - `PricePerDay` (double)
  - `IsRented` (bool) - Padrão: false

### 4. Enum BrakeType
- Arquivo: `src/RentCars/Types/Enums/BrakeType.cs`
- Tipos:
  - `Chamber` = 1
  - `Disc` = 2
  - `Drum` = 3

### 5. Enum TractionType
- Arquivo: `src/RentCars/Types/Enums/TractionType.cs`
- Tipos:
  - `FrontWheelDrive` = 0
  - `RearWheelDrive` = 1
  - `AllWheelDrive` = 2

### 6. Classe Car herda de Vehicle
- Arquivo: `src/RentCars/Models/Car.cs`
- Propriedades adicionais:
  - `Seats` (int)
  - `Doors` (int)
  - `Traction` (TractionType)
  - `FrontBrake` (BrakeType)
  - `RearBrake` (BrakeType)

### 7. Classe Motorcycle herda de Vehicle
- Arquivo: `src/RentCars/Models/Motorcycle.cs`
- Propriedades adicionais:
  - `SeatHeight` (double)
  - `FrontBrake` (BrakeType)
  - `RearBrake` (BrakeType)

### 8. Classe PickupTruck herda de Car
- Arquivo: `src/RentCars/Models/PickupTruck.cs`
- Propriedade adicional:
  - `LoadCapacity` (double)

### 9. Enum RentStatus
- Arquivo: `src/RentCars/Types/Enums/RentStatus.cs`
- Status:
  - `Confirmed` = 0
  - `Finished` = 1
  - `Canceled` = 1

### 10. Construtor da Classe Rent
- Arquivo: `src/RentCars/Models/Rent.cs`
- Regras:
  - Recebe uma instância de `Vehicle`, uma de `Person` e um número inteiro com os dias de aluguel.
  - Para **pessoas físicas**, o preço é calculado como o preço por dia do veículo multiplicado pelo número de dias.
  - Para **pessoas jurídicas**, o preço é calculado com um desconto de 10%.
  - O status inicial é `RentStatus.Confirmed`.
  - O atributo `IsRented` do veículo é alterado para `true`.
  - O atributo `Debit` da pessoa é atualizado com o valor do aluguel.

## Bônus: Cancelar e Finalizar Aluguel
- Arquivo: `src/RentCars/Models/Rent.cs`
- Métodos:
  - `Rent.Cancel()`: Cancela um aluguel alterando o status para `RentStatus.Canceled`.
  - `Rent.Finish()`: Finaliza um aluguel alterando o status para `RentStatus.Finished`.
