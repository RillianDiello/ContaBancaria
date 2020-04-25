using System;
using ContaBancaria.Entity.Exceptions;
namespace ContaBancaria.Entity
{
    public class Account
    {        
        public int number { get; set; }
        public string holder { get; set; }
        public double balance { get; set; }

        public double withdrawLimit { get; set; }

        public Account(){
            
        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
            this.withdrawLimit = withdrawLimit;

        }

        public void deposito(double amount){
            balance += amount;
        }

        public void withdraw(double amount){

            if(amount > withdrawLimit){
                throw new DomainException("Saque maior que o limite.");
            }if(amount > balance){
                throw new DomainException("Não existe valor para balanço.");
            }

            balance -= amount;
        }

        public override string ToString()
        {
            return "Numero da conta: "
            + number
            + ", Holder: "
            + holder
            + ", Valor de Deposito: "
            + balance
            + ", Limite: "
            + withdrawLimit
            + " Fim";
        }

    }
}