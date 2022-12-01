using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Module3HW2
{
    public class Starter
    {
        public static void Run()
        {
            var supportedCultures = new List<Culture>();
            supportedCultures.Add(new Culture("English", "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray().ToList()));
            supportedCultures.Add(new Culture("Ukrainian", "йцукенгшщзхїфівапролджєячсмитьбюЙЦУКЕНГШЩЗХЇФІВАПРОЛДЖЄЯЧСМИТЬБЮ".ToCharArray().ToList()));
            SupportedCultures cultures = new SupportedCultures(supportedCultures);

            MyCollection contacts = new MyCollection(cultures, supportedCultures[1]);

            // MyCollection contacts = new MyCollection();
            contacts.Add(new PhoneRecord("1Oleg", "+380945628901"));
            contacts.Add(new PhoneRecord("Мама", "+380635689204"));
            contacts.Add(new PhoneRecord("Оксана", "+380763389032"));
            contacts.Add(new PhoneRecord("Volodymyr", "+380960067332"));
            contacts.Add(new PhoneRecord("999", "+380967867890"));
            contacts.Add(new PhoneRecord("Galyna", "+380932279199"));
            contacts.Add(new PhoneRecord("Анна", "+380763389032"));
            var petroContact = new PhoneRecord("Petro", "+380960067332");
            contacts.Add(petroContact);
            Console.Write("--- My contacts ---\n");
            Console.Write(contacts.ToString());

            contacts.Remove(petroContact);
            contacts.Remove(contacts.GetAll()[0].Contacts[1]);

            Console.Write("\n\n--- My contacts after removing ---\n");
            Console.Write(contacts.ToString());
        }
    }
}
