using System;

namespace C_1SecondTryHomeWork

{
    class BankAccount
    {
        private string _accountNumber;
        private string _ownerName;
        private decimal _balance;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Номер счёта не может быть пустым.");

                _accountNumber = value;
            }
        }

        public string OwnerName
        {
            get { return _ownerName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя владельца не может быть пустым.");

                _ownerName = value;
            }
        }

        public decimal Balance
        {
            get { return _balance; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Баланс не может быть отрицательным.");

                _balance = value;
            }
        }

        public BankAccount()
        {
            _accountNumber = "UNKNOWN";
            _ownerName = "UNKNOWN";
            _balance = 0;
        }

        // Конструктор
        public BankAccount(string accountNumber, string ownerName, decimal balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }

        // Пополнение счёта
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма пополнения должна быть больше нуля.");

            Balance += amount;
        }

        // Снятие денег
        public bool Withdraw(decimal amount, out string errorMessage)
        {
            if (amount <= 0)
            {
                errorMessage = "Сумма снятия должна быть больше нуля.";
                return false;
            }

            if (amount > Balance)
            {
                errorMessage = "Недостаточно средств на счёте.";
                return false;
            }

            Balance -= amount;
            errorMessage = null;
            return true;
        }

        // Информация о счёте
        public string GetInfo()
        {
            return $"Счёт: {AccountNumber}\n" +
                   $"Владелец: {OwnerName}\n" +
                   $"Баланс: {Balance} руб.";
        }
    }
}
