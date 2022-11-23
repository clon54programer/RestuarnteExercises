/*
 1 validar si es usuario es existente o si debe reistrar, generar un sitema de registro o login
 2. el program debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe
3. el progrma de repetirse hasta que se registren 10 personas
 */

string[] usernames = new string[10] {"i", "i", "p", "t", "u", "o", "k", "j", "g", ""};
int arrayCurrentIndex = 9;
bool userType;

Console.WriteLine("welcome to the best restuarnt in the world");
while(true)
{
    if (arrayCurrentIndex == 10)
    {
        Console.WriteLine("the restaurnt is full, try again next year");
        Environment.Exit(0);
    } 
    Console.WriteLine("are you a registered user? write true, or write false to registrer");
    userType = Convert.ToBoolean(Console.ReadLine());
    if(userType == true)
    {
        Console.WriteLine("hello, you registered user, please enter your user name");
        string userToSearh = Console.ReadLine();
        Console.WriteLine("the user you search is {0}", userToSearh);
        int index = Array.IndexOf(usernames, userToSearh);//esta variable lo que hace es Buscar dato en especifico en un Array y obtener la posición de ese dato.
        if(index == -1)
        {
            Console.WriteLine("user not found, try again or register");
        }
        else
        {
            Console.WriteLine("welcome {0}, it's a pleasure to give you food", usernames[index]);
        }
    }
    else if(userType == false)
    {
        Console.WriteLine("please write and remenber you user name");
        usernames[arrayCurrentIndex] = Console.ReadLine();
        Console.WriteLine("your user has been saved successfully\n"
            +"your user names is {0}", usernames[arrayCurrentIndex]);
        arrayCurrentIndex++;
    }
    Console.WriteLine("the restaurant is full, try again \n these are the guest to the dinner:");
   
}