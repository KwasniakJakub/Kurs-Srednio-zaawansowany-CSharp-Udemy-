using System;

namespace Właściwości_Properties_
{
    public class Person
    {
        //Należy kliknąć ppm na projekt , wybrać "otwórz w terminalu", następnie przejsć do folderu bin/debug/.net 5.0
        //i wpisać komende ildasm "nazwaPliku.dll" i otworzy nam się narzedzie (Dezasembler)
        //Wszystkie właściwości powinny być zadeklarowane na górze

        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime Birthdate { get; private set; } //Dzięki ustawieniu private set nie będzie można później zmienić wartości

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
      
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
