        Console.Write("Введите дату (в формате ДД.ММ.ГГГГ): ");
        string dateInput = Console.ReadLine();
        DateTime date;
        if (DateTime.TryParse(dateInput, out date))
        {
            Console.WriteLine($"Вы ввели: {date.ToShortDateString()}");
        }
        else
        {
            Console.WriteLine("Некорректный формат даты.");
            return;
        }
        Console.Write("Введите срок годности в днях: ");
        int shelfLifeDays;
        if (int.TryParse(Console.ReadLine(), out shelfLifeDays))
        {
            DateTime expirationDate = date.AddDays(shelfLifeDays);
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Срок годности истекает: {expirationDate.ToShortDateString()}");

            if (currentDate < expirationDate)
            {
                TimeSpan remainingTime = expirationDate - currentDate;
                Console.WriteLine($"Оставшиеся дни до истечения срока годности: {remainingTime.Days} дней.");
            }
            else
            {
                Console.WriteLine("Срок годности продукта истек.");
            }
        }
        else
        {
            Console.WriteLine("Некорректное значение срока годности.");
        }
    
