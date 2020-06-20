using System;

namespace ООП_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokupatel Pokupatel1 = new Pokupatel();
            Pokupatel1.pokupatelSurname = "Кокшаров";
            Pokupatel1.pokupatelName = "Кирилл";
            Pokupatel1.pokupatelPatronim = "Николаевич";
            Pokupatel1.pokupatelAdress = "г. Ставрополь, ул. Ленина, д.245, кв. 32";
            Pokupatel1.cardGet("5438092455431249");
            Pokupatel1.bankGet("6529065404824289");
            Pokupatel1.outText();
        }
        class Pokupatel
        {
            public void outText()
            {
                Console.WriteLine($"Фамилия: {pokupatelSurname} \nИмя: {pokupatelName} \nОтчество: {pokupatelPatronim} \nАдрес: {pokupatelAdress} \n" +
                    $"Номер карты: {pokupatelCardNumber}\nБанковский счёт: {pokupatelBankNumber}");
            }
            public void cardGet(string number)
            {
                pokupatelCardNumber = number;
            }
            public void bankGet(string number)
            {
                pokupatelBankNumber = number;
            }
            public string pokupatelSurname;
            public string pokupatelName;
            public string pokupatelPatronim;
            public string pokupatelAdress;
            private string pokupatelCardNumber;
            private string pokupatelBankNumber;
        }
    }
}
