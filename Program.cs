namespace ProjektSEG_FitnessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi Fitness-Fan!\nWie ist Dein Name?\n(Ü)berspringen"); //Eingabe des Username oder Überspringen der Namenseingabe (Zuweisung eines zufälligen Namens))
            string name = Console.ReadLine();//.ToLower();
            Console.Clear();
            /*if (name == "ü")
            {
                Console.WriteLine("Guten Tag, Max Mustermann!");
                Console.ReadKey();
                Console.Clear();
            }
            else 
            {
                Console.WriteLine($"Guten Tag {name}!");
                Console.ReadKey();
                Console.Clear();
            }*/
            /*switch (name) //Speichern des Username oder Zuweisung eines "default-Namens"
            {
                case "Ü":
                case "ü":
                    //random Statist Nr. 27, Max Mustermann
                    Console.WriteLine("Guten Tag, Max Mustermann!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine($"Guten Tag {name}!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }*/
            if (name == "ü" || name == "Ü") //User überspringt Namenseingabe => Zuwesiung eines Zufallsnamens => Grußformel
            {
                Random randName = new Random();
                int numName = randName.Next(0, 6);
                switch (numName)
                {
                    case 0:
                        Console.WriteLine("Guten Tag, Statist Nr. 27!");
                        break;
                    case 1:
                        Console.WriteLine("Welcome back, Mr Schwarzenegger!");
                        break;
                    case 2:
                        Console.WriteLine("Buenos días, Max Mustermann!");
                        break;
                    case 3:
                        Console.WriteLine("Sobh bekheir, Emir!");
                        break;
                    case 4:
                        Console.WriteLine("G'day, mate!");
                        break;
                    case 5:
                        Console.WriteLine("Los geht's, Fitness-Fan!");
                        break;
                }
            }
            else //User gibt Namen ein => Grußformel
            {
                Console.WriteLine($"Hallo {name}!");
            }
            Console.WriteLine("\n\tHauptmenü\n\n1. Trainingspläne\n2. Pausen-Timer\n3. Glossar\n4. Workout Of The Day\n5. Exercise Of The Day"); //Auswahl Menü 1
            char mainmenu1 = Console.ReadLine()[0];
            Console.Clear();
            switch (mainmenu1) //Schleifen für alle Switch (default: ungültige Eingabe), bei ungültiger Eingabe wird Abfrage wiederholt!!!!!!! 
            {
                case '1':
                    Console.WriteLine("\tTrainingspläne\n\n1. Individuellen Trainingsplan erstellen\n2. Vorgefertigte Trainingspläne"); //Auswahl Menü 1.1 (Untermenü)
                    char submenu1 = Console.ReadLine()[0];
                    Console.Clear();
                    switch (submenu1)
                    {
                        case '1':
                            Console.WriteLine("\tIndividuellen Trainingsplan erstellen\n\nBenötigst Du noch etwas Inspiration? (J)/(N)"); //Auswahl Untermenü 1.1 (Sub-Untermenü)
                            char menu11 = Console.ReadLine().ToUpper()[0];
                            Console.Clear();
                            switch (menu11)
                            {
                                case 'J':
                                    Console.WriteLine("\tGlossar\n\n1. Übungserklärungen\n2. Trainingsprinzipien"); //Auswahl Trainingsplanerstellung mit/ohne Glossar
                                    char submenu11 = Console.ReadLine()[0];
                                    Console.Clear();
                                    switch (submenu11)
                                    {


                                        case '1':
                                            Console.WriteLine("\tÜbungserklärungen\n\n1. Brust\n2. Schultern\n3. Trapezmuskeln\n4. Trizeps\n5. Bizeps\n6.Unterarme\n7. Rücken\n8. Bauch\n9. Quadrizeps\n10. Beinbizeps\n11. Tibialis\n12. Waden"); //Auswahl der Muskelgruppe (Übungserklärungen)
                                            char musclegroup = Console.ReadLine()[0];
                                            Console.Clear();
                                            switch (musclegroup)
                                            {
                                                case '1':
                                                    bool nOK;
                                                    do
                                                    {
                                                        Console.WriteLine("\tBrust\n\n1. Bench Press\n2. Incline Bench Press\n3. Decline Bench Press\n4. Dumbbell Flyes\n5. Incline DB Flyes\n6. Decline DB Flyes");
                                                        string exercise = Console.ReadLine();
                                                        nOK = false;
                                                        switch (exercise)
                                                        {
                                                            case "1":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "2":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "3":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "4":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "5":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "6":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            default:
                                                                Random inputNOK = new Random();
                                                                int numInput = inputNOK.Next(0, 6);
                                                                nOK = true;
                                                                switch (numInput)
                                                                {
                                                                    case 0:
                                                                        Console.WriteLine("'Vertan'. sprach der Hahn! Bitte wiederhole Deine Eingabe.\n");
                                                                        break;
                                                                    case 1:
                                                                        Console.WriteLine("Uuups, da ist aber etwas mächtig schiefgelaufen! Bitte gehe zurück zum Start.\n");
                                                                        break;
                                                                    case 2:
                                                                        Console.WriteLine("Ungültige Eingabe! Gehen Sie zum Start, ziehen Sie keine 200 EURO ein.\n");
                                                                        break;
                                                                    case 3:
                                                                        Console.WriteLine("Versuch's nochmal!\n");
                                                                        break;
                                                                    case 4:
                                                                        Console.WriteLine("Du willst Dich doch nur vor dem Training drücken! Ich habe Zeit...\n");
                                                                        break;
                                                                    case 5:
                                                                        Console.WriteLine("Je früher Du hier fertig bist, desto eher kannst Du mit dem Training anfangen. Nächster Versuch.\n");
                                                                        break;
                                                                }
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                        }

                                                    }
                                                    while (nOK);
                                                    break;
                                                case '2':
                                                
                                                    do
                                                    {
                                                        Console.WriteLine("\tScultern\n\n1. Shoulder Press\n2. Scott Press\n3. Standing Upright Rows\n4. DB Lateral Raise\n5. DB Front Raise\n6. Bent-Over DB Lateral Raise ");
                                                        string exercise = Console.ReadLine();
                                                        nOK = false;
                                                        switch (exercise)
                                                        {
                                                            case "1":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "2":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "3":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "4":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "5":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "6":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            default:
                                                                Random inputNOK = new Random();
                                                                int numInput = inputNOK.Next(0, 6);
                                                                nOK = true;
                                                                switch (numInput)
                                                                {
                                                                    case 0:
                                                                        Console.WriteLine("'Vertan'. sprach der Hahn! Bitte wiederhole Deine Eingabe.\n");
                                                                        break;
                                                                    case 1:
                                                                        Console.WriteLine("Uuups, da ist aber etwas mächtig schiefgelaufen! Bitte gehe zurück zum Start.\n");
                                                                        break;
                                                                    case 2:
                                                                        Console.WriteLine("Ungültige Eingabe! Gehen Sie zum Start, ziehen Sie keine 200 EURO ein.\n");
                                                                        break;
                                                                    case 3:
                                                                        Console.WriteLine("Versuch's nochmal!\n");
                                                                        break;
                                                                    case 4:
                                                                        Console.WriteLine("Du willst Dich doch nur vor dem Training drücken! Ich habe Zeit...\n");
                                                                        break;
                                                                    case 5:
                                                                        Console.WriteLine("Je früher Du hier fertig bist, desto eher kannst Du mit dem Training anfangen. Nächster Versuch.\n");
                                                                        break;
                                                                }
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                        }

                                                    }
                                                    while (nOK);
                                                    break;
                                                case '3':
                                                    do
                                                    {
                                                        Console.WriteLine("\tTrapez" +
                                                            "muskeln\n\n1.Shrugs\n2. Standing Close-Grip\n3. Lee-Haney-Shrugs\n4. Cable Shrugs");
                                                        string exercise = Console.ReadLine();
                                                        nOK = false;
                                                        switch (exercise)
                                                        {
                                                            case "1":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "2":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "3":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "4":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            default:
                                                                Random inputNOK = new Random();
                                                                int numInput = inputNOK.Next(0, 6);
                                                                nOK = true;
                                                                switch (numInput)
                                                                {
                                                                    case 0:
                                                                        Console.WriteLine("'Vertan'. sprach der Hahn! Bitte wiederhole Deine Eingabe.\n");
                                                                        break;
                                                                    case 1:
                                                                        Console.WriteLine("Uuups, da ist aber etwas mächtig schiefgelaufen! Bitte gehe zurück zum Start.\n");
                                                                        break;
                                                                    case 2:
                                                                        Console.WriteLine("Ungültige Eingabe! Gehen Sie zum Start, ziehen Sie keine 200 EURO ein.\n");
                                                                        break;
                                                                    case 3:
                                                                        Console.WriteLine("Versuch's nochmal!\n");
                                                                        break;
                                                                    case 4:
                                                                        Console.WriteLine("Du willst Dich doch nur vor dem Training drücken! Ich habe Zeit...\n");
                                                                        break;
                                                                    case 5:
                                                                        Console.WriteLine("Je früher Du hier fertig bist, desto eher kannst Du mit dem Training anfangen. Nächster Versuch.\n");
                                                                        break;
                                                                }
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                        }

                                                    }
                                                    while (nOK);
                                                    break;
                                                case '4':

                                                    do
                                                    {
                                                        Console.WriteLine("\tTrizeps\n\n1. French Press\n2. Triceps Overhead Press\n3. Dips\n4. Close-Grip Bench Press\n5. Diamond Push Ups\n6. Triceps Kickbacks");
                                                        string exercise = Console.ReadLine();
                                                        nOK = false;
                                                        switch (exercise)
                                                        {
                                                            case "1":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "2":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "3":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "4":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "5":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "6":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            default:
                                                                Random inputNOK = new Random();
                                                                int numInput = inputNOK.Next(0, 6);
                                                                nOK = true;
                                                                switch (numInput)
                                                                {
                                                                    case 0:
                                                                        Console.WriteLine("'Vertan'. sprach der Hahn! Bitte wiederhole Deine Eingabe.\n");
                                                                        break;
                                                                    case 1:
                                                                        Console.WriteLine("Uuups, da ist aber etwas mächtig schiefgelaufen! Bitte gehe zurück zum Start.\n");
                                                                        break;
                                                                    case 2:
                                                                        Console.WriteLine("Ungültige Eingabe! Gehen Sie zum Start, ziehen Sie keine 200 EURO ein.\n");
                                                                        break;
                                                                    case 3:
                                                                        Console.WriteLine("Versuch's nochmal!\n");
                                                                        break;
                                                                    case 4:
                                                                        Console.WriteLine("Du willst Dich doch nur vor dem Training drücken! Ich habe Zeit...\n");
                                                                        break;
                                                                    case 5:
                                                                        Console.WriteLine("Je früher Du hier fertig bist, desto eher kannst Du mit dem Training anfangen. Nächster Versuch.\n");
                                                                        break;
                                                                }
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                        }

                                                    }
                                                    while (nOK);
                                                    break;
                                                case '5':

                                                    do
                                                    {
                                                        Console.WriteLine("\tBizeps\n\n1. Biceps Curls\n2. Concentration Curls\n3. Spider Curls\n4. Preacher Curls\n5. Chin Ups\n6. Cable Curls");
                                                        string exercise = Console.ReadLine();
                                                        nOK = false;
                                                        switch (exercise)
                                                        {
                                                            case "1":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "2":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "3":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "4":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "5":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "6":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            default:
                                                                Random inputNOK = new Random();
                                                                int numInput = inputNOK.Next(0, 6);
                                                                nOK = true;
                                                                switch (numInput)
                                                                {
                                                                    case 0:
                                                                        Console.WriteLine("'Vertan'. sprach der Hahn! Bitte wiederhole Deine Eingabe.\n");
                                                                        break;
                                                                    case 1:
                                                                        Console.WriteLine("Uuups, da ist aber etwas mächtig schiefgelaufen! Bitte gehe zurück zum Start.\n");
                                                                        break;
                                                                    case 2:
                                                                        Console.WriteLine("Ungültige Eingabe! Gehen Sie zum Start, ziehen Sie keine 200 EURO ein.\n");
                                                                        break;
                                                                    case 3:
                                                                        Console.WriteLine("Versuch's nochmal!\n");
                                                                        break;
                                                                    case 4:
                                                                        Console.WriteLine("Du willst Dich doch nur vor dem Training drücken! Ich habe Zeit...\n");
                                                                        break;
                                                                    case 5:
                                                                        Console.WriteLine("Je früher Du hier fertig bist, desto eher kannst Du mit dem Training anfangen. Nächster Versuch.\n");
                                                                        break;
                                                                }
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                        }

                                                    }
                                                    while (nOK);
                                                    break;
                                                case '6':

                                                    do
                                                    {
                                                        Console.WriteLine("\tUnterarme\n\n1. Hammer Curls\n2. Reverse Biceps Curls\n3. Reverse Wrist Curls\n4. Wrist Curls");
                                                        string exercise = Console.ReadLine();
                                                        nOK = false;
                                                        switch (exercise)
                                                        {
                                                            case "1":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "2":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "3":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "4":
                                                                Console.WriteLine("Übungserklärung");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            default:
                                                                Random inputNOK = new Random();
                                                                int numInput = inputNOK.Next(0, 6);
                                                                nOK = true;
                                                                switch (numInput)
                                                                {
                                                                    case 0:
                                                                        Console.WriteLine("'Vertan'. sprach der Hahn! Bitte wiederhole Deine Eingabe.\n");
                                                                        break;
                                                                    case 1:
                                                                        Console.WriteLine("Uuups, da ist aber etwas mächtig schiefgelaufen! Bitte gehe zurück zum Start.\n");
                                                                        break;
                                                                    case 2:
                                                                        Console.WriteLine("Ungültige Eingabe! Gehen Sie zum Start, ziehen Sie keine 200 EURO ein.\n");
                                                                        break;
                                                                    case 3:
                                                                        Console.WriteLine("Versuch's nochmal!\n");
                                                                        break;
                                                                    case 4:
                                                                        Console.WriteLine("Du willst Dich doch nur vor dem Training drücken! Ich habe Zeit...\n");
                                                                        break;
                                                                    case 5:
                                                                        Console.WriteLine("Je früher Du hier fertig bist, desto eher kannst Du mit dem Training anfangen. Nächster Versuch.\n");
                                                                        break;
                                                                }
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                        }

                                                    }
                                                    while (nOK);
                                                    break;
                                                case '7':

                                                    do
                                                    {
                                                        Console.WriteLine("\tRücken\n\n1. Deadlift\n2. Pull Ups\n3. Hammer-Grip Pull Ups\n4. Romanian Deadlift\n5. Chin Ups\n6. Deficit Deadlift\n7. T-Bar Rows\n8. Stiff-Leg Deadlift\n9. Bent-Over Rows\n10. Hyperextensions\n11. Lat Pulldowns\n12. Reverse Hyperextensions");
                                                        string exercise = Console.ReadLine();
                                                        nOK = false;
                                                        switch (exercise)
                                                        {
                                                            case "1":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "2":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "3":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "4":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "5":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "6":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                                case "7":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "8":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "9":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "10":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "11":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            case "12":
                                                                Console.WriteLine("Übungserklärung"); //UBÜNGSERKLÄRUNGEN EINFÜGEN!!!!!
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                            default:
                                                                Random inputNOK = new Random();
                                                                int numInput = inputNOK.Next(0, 6);
                                                                nOK = true;
                                                                switch (numInput)
                                                                {
                                                                    case 0:
                                                                        Console.WriteLine("'Vertan'. sprach der Hahn! Bitte wiederhole Deine Eingabe.\n");
                                                                        break;
                                                                    case 1:
                                                                        Console.WriteLine("Uuups, da ist aber etwas mächtig schiefgelaufen! Bitte gehe zurück zum Start.\n");
                                                                        break;
                                                                    case 2:
                                                                        Console.WriteLine("Ungültige Eingabe! Gehen Sie zum Start, ziehen Sie keine 200 EURO ein.\n");
                                                                        break;
                                                                    case 3:
                                                                        Console.WriteLine("Versuch's nochmal!\n");
                                                                        break;
                                                                    case 4:
                                                                        Console.WriteLine("Du willst Dich doch nur vor dem Training drücken! Ich habe Zeit...\n");
                                                                        break;
                                                                    case 5:
                                                                        Console.WriteLine("Je früher Du hier fertig bist, desto eher kannst Du mit dem Training anfangen. Nächster Versuch.\n");
                                                                        break;
                                                                }
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                                break;
                                                        }

                                                    }
                                                    while (nOK);
                                                    break;


                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }

        }


    }














    /*Chest/Pecs:
     *"Dumbbell Flyes", "Incline DB Flyes", "Decline DB FLyes", "Barbell/Dumbbell Bench Press", "BB/DB Incline Bench Press", "BB/DB Decline Bench Press", "Cable Crossovers", "Cable Flyes", "Push Ups"
     *Shoulders/Delts:
     *"BB/DB Shoulder Press", "Scott Press", "DB Lateral Raises", "DB Front Raises", "Bent-Over DB Lateral Raises", "Standing BB/DB Upright Rows", "Lee-Haney-Rows", "Cable Lateral Raises", ""Handstand Push Ups"
     *Neck/Caps:
     *"BB/DB Shrugs", "Lee-Haney-Shrugs", "Standing BB/DB Close-Grip Upright Rows", "Cable Shrugs" 
     *Triceps:
     *"BB/DB French Press", "BB/DB Overhead Triceps Press", "Dips", "Close-Grip Bench Press", "Diamond Push Ups", "Triceps Kickbacks", "Cable Triceps Extensions", "Overhead Cable Triceps Extensions"
     *Biceps:
     *"BB/DB Curls", "Concentration Curls", "Spider Curls", "Palms-Up Pull Ups", "Cable Curls", "Drag Curls", "Biceps Blaster Curls", "Preacher Curls"
     *Forearms: 
     *"Hammer Curls", "Reverse Curls", "Reverse Wrist Curls", "Wrist Curls"
     *Upper Back/Lats:
     *"Pull Ups", "Hammer-Grip Pull Ups", "Reverse-Grip Pull Ups", "T-Bar Rows", Bent-Over BB/DB Rows", "Lat Pulldowns", "Reverse-Grip Lat pulldowns", "BB/DB Pull Overs"
     *Lower Back:
     *"Deadlift", "Romanian Deadlift", Deficit Deadlift", "Hyperextensions", "Cable Pull-Through", "Stiff-Leg Deadlift", "Reverse Hyperextensions"
     *Abdominals/Abs:
     *"Sit Ups", "Eagle Sit Ups", "Hanging Leg Raise", "Lying Leg Raise", "Crunches", "Lateral Sit Ups", "Lateral Crunches", "Cable Crunches", "Planks"
     *Quadriceps/Quads:
     *"Squats", "Hack Squats", "Front Squats", "Lunges", "Side Lunges", "Leg Press", "Leg Extensions", "Sisyphus Squats", "Step Ups"
     *Hamstrings/Hams:
     *"Seated/Lying Leg Curls", "Romanian Deadlift", "Stiff-Leg Deadlift", "Cable Pull-Through", "Seated/Lying Cable Leg Curls", "Reverse Hyperextensions", "Hyperextensions"
     *Tibialis: 
     *"Standing/Seated Heel Press", "Standing/Seated Toe Raises"
     *Calves:
     *"Standing/Seated Calf Raises", "Toe Press", "Stairway-To-Hell Calf Raises"
     *
     *Trainingsprinzipien: German Volume Training, Heavy Duty, Tabata Intervall Training, Negative-Repetition Training, Weider Prinzip der Muskelverwirrung
    */
}


