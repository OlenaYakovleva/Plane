using System;

namespace Program {
    class Plane {
        private string name {get; set;}
        private string manufacturer {get; set;}
        private int year {get; set;}
        private string type {get; set;}
        public Plane() { } // main constructor 
        public Plane(string name, string manufacturer, int year, string type) {
            this.name = name;
            this.manufacturer = manufacturer;
            this.year = year;
            this.type = type;
            }

            public Plane (string emppty){
                name =" " ;
                manufacturer = " ";
                year = 0;
                type = " " ;

            }
            public void InputData() {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Console.Write("Enter manufacturer: ");
                manufacturer = Console.ReadLine();
                Console.Write("Enter year: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter type: ");
                type = Console.ReadLine();
                }
                public void OutputData() {
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Manufacturer: {manufacturer}");
                    Console.WriteLine($"Year: {year}");
                    Console.WriteLine($"Type: {type}");
                    }


                    // overloaded constructors
                    public string GetInfo() {
                        return $"Name: {name}, Manufacturer: {manufacturer}, Year: {year}, Type:{type}";
                        }
                        public string GetInfo(string user) {
                            if (user == "name")
                            return name;
                            else if (user == "manufacturer")
                            return manufacturer;
                            else if (user == "year")
                            return year.ToString();
                            else if (user == "type")
                            return type;
                            else
                            return "Invalid choice";
                            }
    }
}

class Program {
    static void Main(){
        Plane plane = new Plane ("Easyjet", "Paris", 2005, "passagier");
        Console.WriteLine(plane.GetInfo());
        Console.WriteLine(plane.GetInfo("year"));
         plane.InputData();
        plane.OutputData();
        Console.ReadLine();

    }
}