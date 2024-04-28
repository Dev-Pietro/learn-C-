using System;

namespace GetHashCodeEquals_20.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj) //criando um equals personalizado para Client utilizando o Email como referência
        {
            if (!(obj is Client))
            {
                return false;
            }

            Client other = obj as Client;
            return Email.Equals(other.Email);    
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode(); //criando um GetHashCode personalizado para Client utilizando Email como referência
        }
    }
}
