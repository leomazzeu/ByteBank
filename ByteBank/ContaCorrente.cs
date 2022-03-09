﻿// using ByteBank;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public int agencia;
        public int numero;
        private double _saldo = 100;

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value <= 0)
                {
                    return; // Lançar Erro
                }

                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {

            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}