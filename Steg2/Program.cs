// string[] värde = {"1", "2", "3", "4", "5"};
// string[] namn = {"ali", "sadik", "majkel", "emin", "hugo"};
// string[] leksaker = {"playdoh", "lego", "nerf", "barbie", "hotwheels" };

// for (int i = 0; i < leksaker.Length; i++){
//     Console.WriteLine(namn[i] + " ger " + leksaker[i] + " betyget " + värde[i]);
// }
// Console.ReadLine();

List<string> cities = new List<string>();

while(true){
    Console.WriteLine("skriv städer (eller skriv 'exit' om du vill avbryta)");
    string city = Console.ReadLine();

    if(city == "exit"){
        break;
    }

    cities.Add(city);
}

for(int i = 0; i < cities.Count; i++){
    Console.WriteLine(cities[i]);
   
}
Console.ReadLine();