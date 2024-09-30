System.Console.WriteLine("Welcome to the Crimson Crust window-shop application!");
    
    System.Console.WriteLine("Enter 1 to display a plain topping-less pizza slice:");
    System.Console.WriteLine("Enter 2 to display a cheese pizza slice:");
    System.Console.WriteLine("Enter 3 to display a pepperoni pizza slice:");
    System.Console.WriteLine("Enter 4 to exit the application:");

    int menuDecision = int.Parse(Console.ReadLine());

    if (menuDecision == 1) {
        PlainPizza();
    }
    else if (menuDecision == 2) {
        CheesePizza();
    }
    else if (menuDecision == 3) {
        PepPizza();
    }
    else if (menuDecision == 4) {
        Environment.Exit(0);
    }
    else {
        System.Console.WriteLine("Invalid input, please enter a valid option.");
    }

    static void PlainPizza() {
        Random rnd = new Random();
        int rows = rnd.Next(8, 13);

        for (int i = rows; i > 0; i--) {
            for (int j = 0; j < i; j++) {
                Console.Write ("*   ");
            }
            System.Console.WriteLine();
        }
    }
    static void CheesePizza() {
        Random rnd = new Random();
        int rows = rnd.Next(8, 13);

        for (int i = rows; i > 0; i--) {
            for (int j = 0; j < i; j++) {
                if (j == 0 || j == i-1 || i == rows) {
                    Console.Write("*   ");
                }
                else { 
                    Console.Write("#   ");
                }
            }
            System.Console.WriteLine();
        }
    }
    static void PepPizza()  {
        Random rnd = new Random();
        int rows = rnd.Next(8, 13);

        for (int i = rows; i > 0; i--) {
            for (int j = 0; j < i; j++) {
                if (j == 0 || j == i-1 || i == rows) {
                    Console.Write("*   ");
                }
                else { 
                    if (rnd.Next(0, 5) == 0) {
                        Console.Write("[]   ");
                    }
                    else {
                        Console.Write("#   ");
                    }
                 }
            }
        System.Console.WriteLine();
        }
    }
    


