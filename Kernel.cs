using System;
using System.Threading;
using Sys = Cosmos.System;

namespace CosmosKernel
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("[BOOTING] kernel is booting... Version: 0.1 Beta");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================================================");
            Console.WriteLine("[OK] Welcome to C-OS. \nType u/help for help or u/?.");
            Console.WriteLine("====================================================");
            Console.ResetColor();
        }

        protected override void Run()
        {
            Console.Write("[OK] Shell 0.1 / : >");
            var input = Console.ReadLine();
            if (input == "u/help")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("==========================================================================");
                Console.WriteLine("-- u/SimpleText -- For Simple_Text;");
                Console.WriteLine("-- u/Ver -- For Version of Operating System;");
		Console.WriteLine("-- u/about -- Information of OS");
                Console.WriteLine("-- u/sysf -- System files");
                Console.WriteLine("-- Reboot: -- Press Ctrl + alt + del");
                Console.WriteLine("-- u/cls -- Clear terminal.");
                Console.WriteLine("-- u/Calc -- Simple Calculator.");
                Console.WriteLine("-- u/bgCol -- Change background color; Example: bgColor.Reset"); // Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("-- u/bgCol All colors: Blue; Cyan; Red; Green; Yellow; Black, of Reset");
                Console.WriteLine("-- u/fontCol -- Change font color; Example: fontCol.Blue"); // Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-- u/fontCol All colors: Blue; Cyan; Red; Green; Yellow; While, of Reset");
                Console.WriteLine("-- u/Clock -- A Digital clock.");
                Console.WriteLine("-- u/[Zaga]Game -- A Simple game");
                Console.WriteLine("-- u/echo -- Echo program.");
                Console.WriteLine("-- u/Color.reset -- Reset font and bg color.");
                Console.WriteLine("-- u/crash -- Crashing the system");
                Console.WriteLine("==========================================================================");
                Console.ResetColor();

            }
            if (input == "u/SimpleText")
            {
                Console.WriteLine("Simple_Text");
            }
            if (input == "u/Ver")
            {
                double V = 0.1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[ABOUT] Version of kernel: Version: " + V + " Beta");
                Console.ResetColor();
            }
            if (input == "u/sysf")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--System Files--");
                Console.WriteLine("--boot catalog");
                Console.WriteLine("--Cosmos.bin");
                Console.WriteLine("--isolinux.bin");
                Console.WriteLine("--Idlinux.c32");
                Console.WriteLine("--libcom32.c32");
                Console.WriteLine("--mboot.c32");
                Console.WriteLine("--syslinux.cfg");
                Console.WriteLine("--7 Files, 0 Folders");
                Console.ResetColor();
            }
            if (input == "u/?")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("==========================================================================");
                Console.WriteLine("-- u/SimpleText -- For Simple_Text;");
                Console.WriteLine("-- u/Ver -- For Version of Operating System;");
		Console.WriteLine("-- u/about -- Information of OS");
                Console.WriteLine("-- u/sysf -- System files");
                Console.WriteLine("-- Reboot: -- Press Ctrl + alt + del");
                Console.WriteLine("-- u/cls -- Clear terminal.");
                Console.WriteLine("-- u/Calc -- Simple Calculator.");
                Console.WriteLine("-- u/bgCol -- Change background color; Example: bgColor.Reset"); // Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("-- u/bgCol All colors: Blue; Cyan; Red; Green; Yellow; Black, of Reset");
                Console.WriteLine("-- u/fontCol -- Change font color; Example: fontCol.Blue"); // Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-- u/fontCol All colors: Blue; Cyan; Red; Green; Yellow; While, of Reset");
                Console.WriteLine("-- u/Clock -- A Digital clock.");
                Console.WriteLine("-- u/[Zaga]Game -- A Simple snake game.");
                Console.WriteLine("-- u/echo -- Echo program.");
                Console.WriteLine("-- u/Color.reset -- Reset font and bg color.");
                Console.WriteLine("-- u/crash -- Crashing the system");
                Console.WriteLine("==========================================================================");
                Console.ResetColor();
            }
            if (input == "usc/$/Syshelp")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-- SYSTEM COMMANDS --");
                Console.WriteLine("----- NO ROOT -------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("#nr /cmd$/cmd.run/SimpleText.*/$run");
                Console.ResetColor();
            }
            if (input == "u/crash")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("=====!CRASH!=====");
                Console.WriteLine("[!] u/crash command entered!");
                Console.WriteLine("u/kernel/crash");
                Console.WriteLine("[u/!]Crashing...");
                Thread.Sleep(3000);
                while (true)
                {
                    int h = 0, m = 0, s = 0;

                    for (; s <= 60; s++)
                    {
                        Console.WriteLine(string.Format("{0}:{1}:{2}", h, m, s));
                        Thread.Sleep(10);
                        if (s == 59)
                        {
                            if (m == 59)
                            {
                                if (h == 24)
                                {
                                    h = 0;
                                    m = 0;
                                    s = 0;
                                }
                                h++;
                                m = 0;
                                s = 0;
                            }
                            m++;
                            s = 0;
                        }

                    }

                    Console.ReadKey();
                }
            }
            if (input == "u/cls")
            {
                Console.Clear();
            }
	    if (input == "u/about") 
	    {	
		double V = 0.1;
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("About - Information");
		Console.ResetColor();
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("MX360 Version: " + V + " Beta");
		Console.WriteLine("Created in C# with Cosmos");
		Console.WriteLine("Type help or ?, for help.");
	    }
            if (input == "[u/]Sekretka[2077]") 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[E] Error: $ is not exist! kernel/#?/$");
                Console.ResetColor();
            }
            // Background color commands
            if (input == "u/bgCol.Blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (input == "u/bgCol.Cyan")
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            if (input == "u/bgCol.Red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (input == "u/bgCol.Green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (input == "u/bgCol.Yellow")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (input == "u/bgCol.Reset") 
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            // Font color commands.
            if (input == "u/fontCol.Blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (input == "u/fontCol.Cyan")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (input == "u/fontCol.Red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (input == "u/fontCol.Green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if (input == "u/fontCol.Yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if (input == "u/fontCol.Reset") 
            {
                Console.ResetColor();
            }
            if (input == "u/Color.reset")
	    {
		 Console.ResetColor();
	    }
            if (input == "#nr /cmd$/cmd.run/SimpleText.*/$run")
            {
                Console.WriteLine("Simple_Text");
            }
            if (input == "u/Clock") // Console clock; This program not added! will be added in near future.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[u/clock/E] no program found!");
                Console.WriteLine("[SYSMSG/error/msg] this program in development");
                Console.ResetColor();
            }
            if (input == "kernel/#?/$/hack/give_command $")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("$ Sekretka2077");
                Console.ResetColor();
            }
            if (input == "kernel/console/debug.asm")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("[SYNTAX] Syntax error:$:$/con/con/debug.asm");
                Console.WriteLine("[ASM]$code line 1: [EMPTY]");
                Console.ResetColor();
            }
            if (input == "$boot catalog")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("[E] $/error: boot catalog is not available! !AVAILABLE_FOR_SYS$!");
                Console.ResetColor();
            }
            if (input == "$")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("[E] $System$#error: catalog/$/ not found! do you want to make this catalog?");
                Console.ResetColor();
                Console.Write("[?] #: Yes or no>");
                var MakeThisCatalog = Console.ReadLine();
                if (MakeThisCatalog == "yes")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("[System] $Syserror#:> $Unknown error! This catalog already created");
                    Console.ResetColor();
                }
                if (MakeThisCatalog == "no")
                {
                    Console.WriteLine("u/mtc/$: Operation canceled!");
                } 
            }
            if (input == "u/echo")
            {
                Console.Write("[OK] echo / : > ");
                var echo = Console.ReadLine();
                Console.Write("[u/echo] text typed: ");
                Console.WriteLine(echo);
            }
            if (input == "kernel$sys!/root/adm.g!")
            {
                Console.WriteLine("$sysmsg!Admin/root!$ giving...");
                Thread.Sleep(3000);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("$sysmsg:#admerror:function '/root/$', is not #available!");
                Console.WriteLine("#details: $/kernel/su/#root$sysmsg.get.admerror.details");
                Console.ResetColor();
            }
            if (input == "$/kernel/#root$sysmsg.get.admerror.details") 
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("#sysmsg$Details: #admin_error_after_attempt_to_get_/u/roots:");
                Console.WriteLine("--You tried to get root but you didn't have access to /u/root");
                Console.ResetColor();
            }
            if (input == "u/[Zaga]Game") // this game in development. will be added in the near future
            {
                {
                    Random rnd = new Random();
                    int t = rnd.Next(0, 100);
                    // Console.WriteLine(t);
                    Console.WriteLine("The PC guessed a number from 0 to 100. Guess this number!");
                    int w;
                    int sprob = 0;
                    start: Console.WriteLine("Enter this number: ");
                    w = Int32.Parse(Console.ReadLine());
                    if (w != t)
                    {
                    if (w < t)
                    {
                        Console.WriteLine("You didn't guess the number must be higher");
                    }
                    else
                    {
                       Console.WriteLine("You didn't guess right. The number should be less!");
                    }
                       Console.WriteLine("Try again"); sprob++; goto start;
                    }
                    else
                    {
                        Console.WriteLine("You guessed. Well done! Congratulations!");
                        Console.WriteLine("Number of attempts: " + sprob);
                    }
                    Console.ReadKey();
                }
            }
            if (input == "u/call/error")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("[/called]: $== $== $== $== $== $== $== $== $== $==");
                Console.WriteLine("[/called]: $== $== $== $== $== $== $== $== $== $==");
                Console.WriteLine("[/called]: [/Syscall] [/error]; #; Operation not called!");
                Console.WriteLine("[/called]: [u/]:$ [u/error:] #");
                Console.WriteLine("[/called]: [OK]:$; [e/program error] no function: [E/CALL]");
                Console.ResetColor();
            }
            if (input == "u/Calc")
            {
                // Declare variables and then initialize to zero.
                int num1 = 0; int num2 = 0;

                // Display title as the C# console calculator app.
                Console.WriteLine("Calculator\r");
                Console.WriteLine("------------------------\n");

                // Ask the user to type the first number.
                Console.WriteLine("Type a number, and then press Enter");
                num1 = Convert.ToInt32(Console.ReadLine());

                // Ask the user to type the second number.
                Console.WriteLine("Type another number, and then press Enter");
                num2 = Convert.ToInt32(Console.ReadLine());

                // Ask the user to choose an option.
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("[?]Your option? ");

                // Use a switch statement to do the math.
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "s":
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "d":
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                }
                // Wait for the user to respond before closing.
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("[OK] Press any key to close the Calculator console app...");
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
            }
        }
    }
}
