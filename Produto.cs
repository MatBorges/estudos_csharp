using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos_csharp
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(){
            
        }

        public Produto(string nome, double preco, int quantidade){
            
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        
        }

        public string Nome {
            get{ return _nome; }
            set{ _nome = value; }
        }

    }
}