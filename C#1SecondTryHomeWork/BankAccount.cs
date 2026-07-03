using System;
using System.Text.RegularExpressions;

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
                if (!Regex.IsMatch(value, @"^\d{10,15}$"))
                    throw new ArgumentException("Номер счёта должен содержать от 10 до 15 цифр.");

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
            _accountNumber = "0000000000";
            _ownerName = "UNKNOWN";
            _balance = 0;
        }

        public BankAccount(string accountNumber, string ownerName, decimal balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма пополнения должна быть больше нуля.");

            Balance += amount;
        }

        public bool Withdraw(decimal amount, out string errorMessage)
        {
            if (amount <= 0)
            {
                errorMessage = "Сумма снятия должна быть больше нуля.";
                return false;
            }

            if (amount > Balance)
            {
                errorMessage = "Недостаточно средств.";
                return false;
            }

            Balance -= amount;
            errorMessage = null;
            return true;
        }

        // Возвращаем только данные — без форматирования
        public (string accountNumber, string ownerName, decimal balance) GetInfo()
        {
            return (_accountNumber, _ownerName, _balance);
        }
    }
}
