//Franco Gregorio
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project__1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int maxWidth = Console.LargestWindowWidth;
            int maxHeight = Console.LargestWindowHeight;
            Console.SetWindowSize(Math.Min(120, maxWidth), Math.Min(45, maxHeight));

            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            int chosenOne = 0;

            do
            {
                Console.Clear();
                SpinAnimation();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                              ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                           ");
                Console.WriteLine("                             ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                           ");
                Console.WriteLine("                             ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                           ");
                Console.WriteLine("                             ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                           ");
                Console.WriteLine("                             ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                           ");
                Console.WriteLine("                              ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
                Console.WriteLine("        ██                                                                       ..+%#:.  ..:==..         ██           ");
                Console.WriteLine("        ██                                      Genetics Menu:                    -@:..%-..:@+.:@-..      ██           ");
                Console.WriteLine("        ██                                                                     ...%=  .=#..%=  .=%..      ██           ");
                Console.WriteLine("        ██                                                                     ...@.  .:%..@.  .:@..      ██           ");
                Console.WriteLine("        ██                                                                     ...@.   :%.:@.  .-%..      ██           ");
                Console.WriteLine("        ██                                                                     ...%:  .+#:=#.  .+*..      ██           ");
                Console.WriteLine("        ██                                                                     ..#@-  ....:..  .%=..      ██           ");
                Console.WriteLine("        ██     [ 1 ] What is Genetics                                        ..:@:..           .*%..      ██           ");
                Console.WriteLine("        ██     [ 2 ] Types of Genetic Inheritance                            .:@:.             ..-@...    ██           ");
                Console.WriteLine("        ██     [ 3 ] More Information About DNA and Genes                    .**..             . .=%..    ██           ");
                Console.WriteLine("        ██     [ 4 ] Chromosomes and Their Function                          .#=.                .:@..    ██           ");
                Console.WriteLine("        ██     [ 5 ] Genetic Mutations                                   :+*+.*+...*:..    ..... .:@..    ██           ");
                Console.WriteLine("        ██     [ 6 ] Gene Editing (CRISPR and Other Technologies)        =#.@.:@...:........-@.. .+%..    ██           ");
                Console.WriteLine("        ██     [ 7 ] Human Genome Project                                .%.@@@%@=....+#%..  ....*%.  ... ██           ");
                Console.WriteLine("        ██     [ 8 ] Epigenetics                                    .....=#.#*+..:#%=:.......:=#%-....=#= ██           ");
                Console.WriteLine("        ██     [ 9 ] Evolution and Genetics                           ..=+..*+*. ..*@*=#@%**@@%.-*#:.:#:% ██           ");
                Console.WriteLine("        ██     [ 10 ] Module                                        ....%:::#*=#....-@:%%@-=@-.....*=%=%. ██           ");
                Console.WriteLine("        ██     [ 0 ] Exit                                           ...#-:::::-+=.  ..%%#%%-.    ..*@:+-. ██           ");
                Console.WriteLine("        ██                                                          ....=++==-%:..  ....@...     :@++=*.. ██           ");
                Console.WriteLine("        ██                                                          .........#+.... .+#.@...     .-@#-... ██           ");
                Console.WriteLine("        ██                                                                 .*#..    ....@..      ..*#.    ██           ");
                Console.WriteLine("        ██                                                                 .@...    .#*.%..      ...@:    ██           ");
                Console.WriteLine("        ██                                                                 .=%=...  ...:%..    ...+@:.    ██           ");
                Console.WriteLine("        ██                                                                   ..*@#-....-#.....:+@%:.      ██           ");
                Console.WriteLine("        ██                                                                     .*@=-+#@%%@#*+=#+..        ██           ");
                Console.WriteLine("        ██                                                                     ....--:....*##*...         ██           ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.Write("                        Choose an option: ");
                chosenOne = Convert.ToInt32(Console.ReadLine());

                switch (chosenOne)
                {
                    case 1: WhatIsGenetics(); break;
                    case 2: TypesOfGeneticInheritance(); break;
                    case 3: MoreInfoAboutDNAAndGenes(); break;
                    case 4: ChromosomesAndTheirFunction(); break;
                    case 5: GeneticMutations(); break;
                    case 6: GeneEditing(); break;
                    case 7: HumanGenomeProject(); break;
                    case 8: Epigenetics(); break;
                    case 9: EvolutionAndGenetics(); break;
                    case 10: MainModule(); break;
                    default:
                        break;
                }

            } while (chosenOne != 0);
        }


        static void SpinAnimation()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            string[] frames = new string[]
            {
            "        ====================================================================================================     \n" +
            "                                                  O     O          \n" +
            "                                                   \\   /          \n" +
            "                                                    O-O            \n" +
            "                                                   /   \\          \n" +
            "                                                  O     O          \n" +
            "                                                   \\   /          \n" +
            "                                                    O-O            \n" +
            "                                                   /   \\          \n" +
            "                                                  O     O          \n" +
            "                                                   \\   /          \n" +
            "                                                    O-O            \n" +
            "                                                   /   \\          \n" +
            "                                                  O     O          \n" +
            "                                                   \\   /          \n" +
            "                                                    O-O            \n" +
            "                                                   /   \\          \n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================     \n" +
            "                                                   O     O         \n" +
            "                                                    \\   /         \n" +
            "                                                     O-O           \n" +
            "                                                    /   \\         \n" +
            "                                                   O     O         \n" +
            "                                                    \\   /         \n" +
            "                                                     O-O           \n" +
            "                                                    /   \\         \n" +
            "                                                   O     O         \n" +
            "                                                    \\   /         \n" +
            "                                                     O-O           \n" +
            "                                                    /   \\         \n" +
            "                                                   O     O         \n" +
            "                                                    \\   /         \n" +
            "                                                     O-O           \n" +
            "                                                    /   \\         \n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================     \n" +
            "                                                    O     O        \n" +
            "                                                     \\   /        \n" +
            "                                                      O-O          \n" +
            "                                                     /   \\        \n" +
            "                                                    O     O        \n" +
            "                                                     \\   /        \n" +
            "                                                      O-O          \n" +
            "                                                     /   \\        \n" +
            "                                                    O     O        \n" +
            "                                                     \\   /        \n" +
            "                                                      O-O          \n" +
            "                                                     /   \\        \n" +
            "                                                    O     O        \n" +
            "                                                     \\   /        \n" +
            "                                                      O-O          \n" +
            "                                                     /   \\        \n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================     \n" +
            "                                                   O     O         \n" +
            "                                                   \\   /          \n" +
            "                                                   O-O             \n" +
            "                                                   /   \\          \n" +
            "                                                   O     O         \n" +
            "                                                   \\   /          \n" +
            "                                                   O-O             \n" +
            "                                                   /   \\          \n" +
            "                                                   O     O         \n" +
            "                                                   \\   /          \n" +
            "                                                   O-O             \n" +
            "                                                   /   \\          \n" +
            "                                                   O     O         \n" +
            "                                                   \\   /          \n" +
            "                                                   O-O             \n" +
            "                                                   /   \\          \n" +
            "        ====================================================================================================  ",

            };

            for (int i = 0; i < 5; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear(); // Cle the next frame
                    Console.WriteLine(frame);
                    Console.WriteLine("                                            Genetics Loading...");
                    Thread.Sleep(200); // Wait fo
                }
            }
            Console.Clear();
            Console.WriteLine("Genetics Menu Complete!");
        }
        static void WhatIsGenetics()
        {

            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                               ╦ ╦┬ ┬┌─┐┌┬┐  ┬┌─┐  ┌─┐┌─┐┌┐┌┌─┐┌┬┐┬┌─┐ ┌─┐                                 ");
            Console.WriteLine("                               ║║║├─┤├─┤ │   │└─┐  │ ┬├┤ │││├┤  │ ││    ┌┘                                 ");
            Console.WriteLine("                               ╚╩╝┴ ┴┴ ┴ ┴   ┴└─┘  └─┘└─┘┘└┘└─┘ ┴ ┴└─┘  o                                  ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Genetics is the branch of biology that studies genes, heredity, and genetic variation in    ||   ");
            Console.WriteLine("    ||       living organisms. Genes, made of DNA, are units of heredity passed from parents to       ||   ");
            Console.WriteLine("    ||      offspring, and they determine traits and characteristics. Genetics explains how these     ||   ");
            Console.WriteLine("    ||    traits are inherited, vary among populations, and can sometimes lead to genetic disorders.  ||   ");
            Console.WriteLine("    ||     This field also explores how genes interact with environmental factors, contributing to    ||   ");
            Console.WriteLine("    ||                                     the diversity of life                                      ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in main menu)                                   ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }
        static void TypesOfGeneticInheritance()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                AnimateGeneticInheritance();
                Console.Clear();
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                              ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                           ");
                Console.WriteLine("                             ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                           ");
                Console.WriteLine("                             ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                           ");
                Console.WriteLine("                             ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                           ");
                Console.WriteLine("                             ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                           ");
                Console.WriteLine("                              ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
                Console.WriteLine("        ██                                                     ..-+#%%%%%%%%#+-..                         ██           ");
                Console.WriteLine("        ██                Types of Genetic Inheritance      ..+@@+:..........:+@@+..                      ██           ");
                Console.WriteLine("        ██                                               ..-#%=:.-+#%%%##%%%#+-.:=%#-..                   ██           ");
                Console.WriteLine("        ██                                              ..#%-.:*@*-:-#*-....:-#@*:.-%#..                  ██           ");
                Console.WriteLine("        ██                                             .-@*.:*@=...*@-=@=.......=@*:.*@-.                 ██           ");
                Console.WriteLine("        ██                                            .-%=.-%*.....-%%%%:.==..:...*%-.=%:.                ██           ");
                Console.WriteLine("        ██     [ 1 ] Dominant Inheritance             .%+.-%=..........=+-#@%@#....+%::+%.                ██           ");
                Console.WriteLine("        ██     [ 2 ] Recessive Inheritance            +%:.#*.....#+=@#::@%**+*@#=:..*#.:%+.               ██           ");
                Console.WriteLine("        ██     [ 3 ] Co-Dominance                     %*.:@-....+@#***##*#@+%#*@=...-@-.#%..              ██           ");
                Console.WriteLine("        ██     [ 4 ] Incomplete Dominance             :%-.+%:...#@@@@@@@%=#=...+@@%-%+.=@:                ██           ");
                Console.WriteLine("        ██     [ 5 ] Sex-Linked Inheritance           .+#::*#......#+..+:.........:#*::#+.                ██           ");
                Console.WriteLine("        ██     [ 6 ] Mitochondrial Inheritance         ..*%=.:#@=..+@%+*@%:....=@#..=@*..                 ██           ");
                Console.WriteLine("        ██     [ 0 ] Go Back                             .:##-.:+%@@+=---*@=*%%+:.-#%*%#=+-....           ██           ");
                Console.WriteLine("        ██                                                ..-#%+:.:--+****+-::.:+%%@#=#%+-#%:...          ██           ");
                Console.WriteLine("        ██                                                   ..-%@%+-::::::-*%@%-...*@*::-%%@%:....       ██           ");
                Console.WriteLine("        ██                                                     ....:-=++++=-:....  .+%--%%=--=%*....      ██           ");
                Console.WriteLine("        ██                                                           ......        ..-@@=---::-+@*..      ██           ");
                Console.WriteLine("        ██                                                                            ...+%*---:--*@      ██           ");
                Console.WriteLine("        ██                                                                             ....*@+---%%:      ██           ");
                Console.WriteLine("        ██                                                                                 ...#%@%-..     ██           ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.Write("                        Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: Inheritance1(); break;
                    case 2: Inheritance2(); break;
                    case 3: Inheritance3(); break;
                    case 4: Inheritance4(); break;
                    case 5: Inheritance5(); break;
                    case 6: Inheritance6(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void AnimateGeneticInheritance()
        {
            string[] frames = new string[]
            {
"        ====================================================================================================     \n" +
    "                           Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
    "                                  |                                  |\n" +
    "                                  |                                  |\n" +
    "                                  |                                  |\n" +
    "                                  |                                  |\n" +
    "                                  [A]                                [a]\n" +
    "        ====================================================================================================  ",

    "        ====================================================================================================  \n" +
    "                           Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
    "                                   |                                  |\n" +
    "                                   |                                  |\n" +
    "                                   |                                  |\n" +
    "                                   |                                  |\n" +
    "                                  [A]                                [a]\n" +
    "                                    \\                                /\n" +
    "                                     \\                              /\n" +
    "                                      \\                            /\n" +
    "                                       \\                          /\n" +
    "                                        \\                        /\n" +
    "                                         Offspring Alleles: [A, a]\n" +
    "        ====================================================================================================  ",

    "        ====================================================================================================  \n" +
    "                           Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
    "                                   |                                  |\n" +
    "                                  [A]                                [A]\n" +
    "                                    \\                                /\n" +
    "                                     \\                              /\n" +
    "                                      \\                            /\n" +
    "                                       \\                          /\n" +
    "                                         Offspring Alleles: [A, A]\n" +
    "        ====================================================================================================  ",

    "        ====================================================================================================  \n" +
    "                           Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
    "                                   |                                  |\n" +
    "                                  [a]                                [A]\n" +
    "                                    \\                                /\n" +
    "                                     \\                              /\n" +
    "                                      \\                            /\n" +
    "                                       \\                          /\n" +
    "                                         Offspring Alleles: [a, A]\n" +
    "        ====================================================================================================  ",

    "        ====================================================================================================  \n" +
    "                           Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
    "                                   |                                  |\n" +
    "                                  [a]                                [a]\n" +
    "                                    \\                                /\n" +
    "                                     \\                              /\n" +
    "                                      \\                            /\n" +
    "                                       \\                          /\n" +
    "                                         Offspring Alleles: [a, a]\n" +
    "        ====================================================================================================  ",

            };

            for (int i = 0; i < 1; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("");
                    Console.WriteLine("                                        Genetic Inheritance Loading...");
                    Thread.Sleep(1000);
                }
            }
            Console.Clear();
            Console.WriteLine("Genetic Inheritance Complete!");

        }

        static void Inheritance1()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                           ╔╦╗┌─┐┌┬┐┬┌┐┌┌─┐┌┐┌┌┬┐  ╦┌┐┌┬ ┬┌─┐┬─┐┬┌┬┐┌─┐┌┐┌┌─┐┌─┐                           ");
            Console.WriteLine("                            ║║│ ││││││││├─┤│││ │   ║│││├─┤├┤ ├┬┘│ │ ├─┤││││  ├┤                            ");
            Console.WriteLine("                           ═╩╝└─┘┴ ┴┴┘└┘┴ ┴┘└┘ ┴   ╩┘└┘┴ ┴└─┘┴└─┴ ┴ ┴ ┴┘└┘└─┘└─┘                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||      In dominant inheritance, only one copy of a dominant allele (a version of a gene) is      ||   ");
            Console.WriteLine("    ||     needed for a trait to appear in an individual. In genetic terms, this allele dominates     ||   ");
            Console.WriteLine("    ||     over the recessive allele, meaning that even if an individual inherits only one copy of    ||   ");
            Console.WriteLine("    ||    the dominant allele from one parent, they will express the trait associated with it. This   ||   ");
            Console.WriteLine("    ||         pattern of inheritance is common in many genetic disorders and traits.                 ||   ");
            Console.WriteLine("    ||                                     the diversity of life.                                     ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void Inheritance2()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                       ╦═╗┌─┐┌─┐┌─┐┌─┐┌─┐┬┬  ┬┌─┐  ╦┌┐┌┬ ┬┌─┐┬─┐┬┌┬┐┌─┐┌┐┌┌─┐┌─┐                           ");
            Console.WriteLine("                       ╠╦╝├┤ │  ├┤ └─┐└─┐│└┐┌┘├┤   ║│││├─┤├┤ ├┬┘│ │ ├─┤││││  ├┤                            ");
            Console.WriteLine("                       ╩╚═└─┘└─┘└─┘└─┘└─┘┴ └┘ └─┘  ╩┘└┘┴ ┴└─┘┴└─┴ ┴ ┴ ┴┘└┘└─┘└─┘                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Recessive inheritance occurs when a trait is expressed only if an individual inherits two   ||   ");
            Console.WriteLine("    ||    copies of a recessive allele, one from each parent. If both parents carry one recessive     ||   ");
            Console.WriteLine("    ||    allele for a trait (making them heterozygous), they are typically asymptomatic carriers,    ||   ");
            Console.WriteLine("    ||    meaning they do not exhibit the trait themselves but can pass it on to their offspring.     ||   ");
            Console.WriteLine("    ||    For an offspring to show the recessive trait, they must inherit the recessive allele from   ||   ");
            Console.WriteLine("    ||                  each parent, resulting in a homozygous recessive genotype.                    ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void Inheritance3()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                      ╔═╗┌─┐  ┌┬┐┌─┐┌┬┐┬┌┐┌┌─┐┌┐┌┌─┐┌─┐                                    ");
            Console.WriteLine("                                      ║  │ │───│││ ││││││││├─┤││││  ├┤                                     ");
            Console.WriteLine("                                      ╚═╝└─┘  ─┴┘└─┘┴ ┴┴┘└┘┴ ┴┘└┘└─┘└─┘                                    ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Co-dominance is a form of genetic inheritance where both alleles in a gene pair are fully   ||   ");
            Console.WriteLine("    ||    expressed in the phenotype of a heterozygous individual, without one being dominant over    ||   ");
            Console.WriteLine("    ||    the other. This results in a phenotype that clearly shows both traits side-by-side, rather  ||   ");
            Console.WriteLine("    ||                                      than blending them.                                       ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");

            Console.ReadKey();
        }

        static void Inheritance4()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                            ╦┌┐┌┌─┐┌─┐┌┬┐┌─┐┬  ┌─┐┌┬┐┌─┐  ╔╦╗┌─┐┌┬┐┬┌┐┌┌─┐┌┐┌┌─┐┌─┐                        ");
            Console.WriteLine("                            ║││││  │ ││││├─┘│  ├┤  │ ├┤    ║║│ ││││││││├─┤││││  ├┤                         ");
            Console.WriteLine("                            ╩┘└┘└─┘└─┘┴ ┴┴  ┴─┘└─┘ ┴ └─┘  ═╩╝└─┘┴ ┴┴┘└┘┴ ┴┘└┘└─┘└─┘                        ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Incomplete dominance is when two different alleles combine and create a blended trait in    ||   ");
            Console.WriteLine("    ||          the offspring, rather than one trait hiding the other or both showing fully.          ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");


            Console.ReadKey();
        }

        static void Inheritance5()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                          ╔═╗┌─┐─┐ ┬   ┬  ┬┌┐┌┬┌─┌─┐┌┬┐                                    ");
            Console.WriteLine("                                          ╚═╗├┤ ┌┴┬┘───│  ││││├┴┐├┤  ││                                    ");
            Console.WriteLine("                                          ╚═╝└─┘┴ └─   ┴─┘┴┘└┘┴ ┴└─┘─┴┘                                    ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Sex-linked inheritance refers to genes located on the sex chromosomes (X and Y). Traits     ||   ");
            Console.WriteLine("    ||     associated with these genes are inherited differently in males and females due to the      ||   ");
            Console.WriteLine("    ||             difference in their sex chromosomes (XX for females and XY for males).             ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void Inheritance6()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                   ╔╦╗┬┌┬┐┌─┐┌─┐┬ ┬┌─┐┌┐┌┌┬┐┬─┐┬┌─┐┬    ╦┌┐┌┬ ┬┌─┐┬─┐┬┌┬┐┌─┐┌┐┌┌─┐┌─┐                      ");
            Console.WriteLine("                   ║║║│ │ │ ││  ├─┤│ ││││ ││├┬┘│├─┤│    ║│││├─┤├┤ ├┬┘│ │ ├─┤││││  ├┤                       ");
            Console.WriteLine("                   ╩ ╩┴ ┴ └─┘└─┘┴ ┴└─┘┘└┘─┴┘┴└─┴┴ ┴┴─┘  ╩┘└┘┴ ┴└─┘┴└─┴ ┴ ┴ ┴┘└┘└─┘└─┘                      ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Mitochondrial inheritance, also known as maternal inheritance, refers to the transmission   ||   ");
            Console.WriteLine("    ||    of genes located in the mitochondria, which are small energy-producing structures outside   ||   ");
            Console.WriteLine("    ||      the nucleus of cells. Mitochondrial DNA (mtDNA) is inherited only from the mother, as     ||   ");
            Console.WriteLine("    ||                mitochondria in sperm are typically lost during fertilization.                  ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void MoreInfoAboutDNAAndGenes()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                AnimateDNAAndGenes();
                Console.Clear();
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                              ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                           ");
                Console.WriteLine("                             ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                           ");
                Console.WriteLine("                             ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                           ");
                Console.WriteLine("                             ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                           ");
                Console.WriteLine("                             ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                           ");
                Console.WriteLine("                              ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
                Console.WriteLine("        ██                                                                                                ██           ");
                Console.WriteLine("        ██                              More InfoAbout DNA And Genes                                      ██           ");
                Console.WriteLine("        ██                                                                                                ██           ");
                Console.WriteLine("        ██                                                                             .                  ██           ");
                Console.WriteLine("        ██                                                    7J                       ..                 ██           ");
                Console.WriteLine("        ██                                                    !5.                      ^?7:               ██           ");
                Console.WriteLine("        ██                                                  .:?Y.                      .:~?!              ██           ");
                Console.WriteLine("        ██                                                  ^?5J!~^.                    .:~?7.            ██           ");
                Console.WriteLine("        ██           [ 1 ] DNA Introduction                  ?J..:!7~:                   ..:J!            ██           ");
                Console.WriteLine("        ██           [ 2 ] Genes Functions                  ^5~::.::~?^                .^^::J!            ██           ");
                Console.WriteLine("        ██           [ 3 ] DNA Replication                  ^57^^~~~^~~               .::^7J!             ██           ");
                Console.WriteLine("        ██           [ 4 ] Gene Expression                   ~JY?~~:^!^             .::^7?!:              ██           ");
                Console.WriteLine("        ██           [ 5 ] Genetic Variation                   :~7??JYJ?7!^.      ...^?7^.                ██           ");
                Console.WriteLine("        ██           [ 6 ] Inheritance Patterns                    :!~^~~7Y57    ..:~J~                   ██           ");
                Console.WriteLine("        ██           [ 7 ] Genetic Technologies                    ^!....:^?B!   :::J7                    ██           ");
                Console.WriteLine("        ██           [ 8 ] Human Genome ProjectInfo                :!^:~!!^!B~   .:.!J.                   ██           ");
                Console.WriteLine("        ██           [ 9 ] Ethical Considerations                   :~7^:::55      .^7?^                  ██           ");
                Console.WriteLine("        ██           [ 10 ] Future Genetics                           .:^^?G!^^:.  ...~?7:                ██           ");
                Console.WriteLine("        ██           [ 0 ] Exit                                          .55!777?7:   .^!?7:              ██           ");
                Console.WriteLine("        ██                                                               :G?^~~!?Y5^  .. .!J~             ██           ");
                Console.WriteLine("        ██                                                                JP!~!~^:7^    ..:7J.            ██           ");
                Console.WriteLine("        ██                                                                .!Y5Y?          :?!             ██           ");
                Console.WriteLine("        ██                                                                   .::           .              ██           ");
                Console.WriteLine("        ██                                                                                                ██           ");
                Console.WriteLine("        ██                                                                                                ██           ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.Write("                        Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: DNAIntroduction(); break;
                    case 2: GenesFunctions(); break;
                    case 3: DNAReplication(); break;
                    case 4: GeneExpression(); break;
                    case 5: GeneticVariation(); break;
                    case 6: InheritancePatterns(); break;
                    case 7: GeneticTechnologies(); break;
                    case 8: HumanGenomeProjectInfo(); break;
                    case 9: EthicalConsiderations(); break;
                    case 10: FutureGenetics(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void AnimateDNAAndGenes()
        {
            // A the DNA helix with gene sequences
            string[] frames = new string[]
            {

            "        ====================================================================================================  \n" +
            "                                                  A       T\n" +
            "                                                   \\     /\n" +
            "                                                    \\   /\n" +
            "                                                     C-G\n" +
            "                                                    /   \\\n" +
            "                                                   /     \\\n" +
            "                                                  T       A\n"+
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                                  C       G\n" +
            "                                                   \\     /\n" +
            "                                                    \\   /\n" +
            "                                                     T-A\n" +
            "                                                    /   \\\n" +
            "                                                   /     \\\n" +
            "                                                  A       T\n"+
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                                  T       A\n" +
            "                                                   \\     /\n" +
            "                                                    \\   /\n" +
            "                                                     G-C\n" +
            "                                                    /   \\\n" +
            "                                                   /     \\\n" +
            "                                                  C       G\n"+
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                                  G       C\n" +
            "                                                   \\     /\n" +
            "                                                    \\   /\n" +
            "                                                     A-T\n" +
            "                                                    /   \\\n" +
            "                                                   /     \\\n" +
            "                                                  T       A \n" +
            "        ====================================================================================================  "
            };

            // Loop create the animation effect
            for (int i = 0; i < 3; i++) // Repea a longer animation
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                            DNA and Genes Loading..");
                    Thread.Sleep(500); // Delay control animation speed
                }
            }
            Console.Clear();
            Console.WriteLine("DNA and Genes Complete!");

        }

        static void DNAIntroduction()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                          ╦┌┐┌┌┬┐┬─┐┌─┐┌┬┐┬ ┬┌─┐┌┬┐┬┌─┐┌┐┌  ┌┬┐┌─┐  ╔╦╗╔╗╔╔═╗                              ");
            Console.WriteLine("                          ║│││ │ ├┬┘│ │ │││ ││   │ ││ ││││   │ │ │   ║║║║║╠═╣                              ");
            Console.WriteLine("                          ╩┘└┘ ┴ ┴└─└─┘─┴┘└─┘└─┘ ┴ ┴└─┘┘└┘   ┴ └─┘  ═╩╝╝╚╝╩ ╩                              ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||     DNA, or deoxyribonucleic acid, is the molecule that contains the genetic information       ||   ");
            Console.WriteLine("    ||    necessary for life. It’s found in nearly all living organisms, serving as the blueprint     ||   ");
            Console.WriteLine("    ||    for building, maintaining, and replicating cells. DNA resides mainly in the cell nucleus    ||   ");
            Console.WriteLine("    ||    (in eukaryotic cells) and carries instructions for protein synthesis, which determines an   ||   ");
            Console.WriteLine("    ||                      organism's structure, function, and development.                          ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");

            Console.ReadKey();
        }

        static void GenesFunctions()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                     ╔═╗┌─┐┌┐┌┌─┐┌─┐  ┌─┐┌┐┌┌┬┐  ╔╦╗┬ ┬┌─┐┬┬─┐  ╔═╗┬ ┬┌┐┌┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                  ");
            Console.WriteLine("                     ║ ╦├┤ │││├┤ └─┐  ├─┤│││ ││   ║ ├─┤├┤ │├┬┘  ╠╣ │ │││││   │ ││ ││││└─┐                  ");
            Console.WriteLine("                     ╚═╝└─┘┘└┘└─┘└─┘  ┴ ┴┘└┘─┴┘   ╩ ┴ ┴└─┘┴┴└─  ╚  └─┘┘└┘└─┘ ┴ ┴└─┘┘└┘└─┘                  ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||     Genes are segments of DNA that act as instructions for building proteins and regulating    ||   ");
            Console.WriteLine("    ||   various biological processes within an organism. Each gene is made up of a specific sequence ||   ");
            Console.WriteLine("    ||    of nucleotide bases (adenine, thymine, cytosine, and guanine), which determines its unique  ||   ");
            Console.WriteLine("    ||                         function and the specific proteins it produces.                        ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");

            Console.ReadKey();
        }

        static void DNAReplication()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                  ╔╦╗╔╗╔╔═╗  ╦═╗┌─┐┌─┐┬  ┬┌─┐┌─┐┌┬┐┬┌─┐┌┐┌                                 ");
            Console.WriteLine("                                   ║║║║║╠═╣  ╠╦╝├┤ ├─┘│  ││  ├─┤ │ ││ ││││                                 ");
            Console.WriteLine("                                  ═╩╝╝╚╝╩ ╩  ╩╚═└─┘┴  ┴─┘┴└─┘┴ ┴ ┴ ┴└─┘┘└┘                                 ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||     DNA replication is the process by which a cell makes an identical copy of its DNA,         ||   ");
            Console.WriteLine("    ||   ensuring that each new cell receives the same genetic information as the original. This      ||   ");
            Console.WriteLine("    ||   process is essential during cell division, allowing genetic information to be passed on      ||   ");
            Console.WriteLine("    ||                  accurately from one generation of cells to the next.                          ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void GeneExpression()
        {
            Console.Clear();
            Console.WriteLine("Gene Expression and Regulation");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("             ╔═╗┌─┐┌┐┌┌─┐  ╔═╗─┐ ┬┌─┐┬─┐┌─┐┌─┐┌─┐┬┌─┐┌┐┌  ┌─┐┌┐┌┌┬┐  ╦═╗┌─┐┌─┐┬ ┬┬  ┌─┐┌┬┐┬┌─┐┌┐┌          ");
            Console.WriteLine("             ║ ╦├┤ │││├┤   ║╣ ┌┴┬┘├─┘├┬┘├┤ └─┐└─┐││ ││││  ├─┤│││ ││  ╠╦╝├┤ │ ┬│ ││  ├─┤ │ ││ ││││          ");
            Console.WriteLine("             ╚═╝└─┘┘└┘└─┘  ╚═╝┴ └─┴  ┴└─└─┘└─┘└─┘┴└─┘┘└┘  ┴ ┴┘└┘─┴┘  ╩╚═└─┘└─┘└─┘┴─┘┴ ┴ ┴ ┴└─┘┘└┘          ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||      Gene expression and regulation refer to the processes by which genes are activated,       ||   ");
            Console.WriteLine("    ||     transcribed, and translated into proteins, and the mechanisms that control when, where,    ||   ");
            Console.WriteLine("    ||      and how much of a gene product (usually a protein) is made. Proper gene regulation is     ||   ");
            Console.WriteLine("    ||               essential for development, adaptation, and cellular function.                    ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void GeneticVariation()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("             ╔═╗┌─┐┌┐┌┌─┐  ╔═╗─┐ ┬┌─┐┬─┐┌─┐┌─┐┌─┐┬┌─┐┌┐┌  ┌─┐┌┐┌┌┬┐  ╦═╗┌─┐┌─┐┬ ┬┬  ┌─┐┌┬┐┬┌─┐┌┐┌          ");
            Console.WriteLine("             ║ ╦├┤ │││├┤   ║╣ ┌┴┬┘├─┘├┬┘├┤ └─┐└─┐││ ││││  ├─┤│││ ││  ╠╦╝├┤ │ ┬│ ││  ├─┤ │ ││ ││││          ");
            Console.WriteLine("             ╚═╝└─┘┘└┘└─┘  ╚═╝┴ └─┴  ┴└─└─┘└─┘└─┘┴└─┘┘└┘  ┴ ┴┘└┘─┴┘  ╩╚═└─┘└─┘└─┘┴─┘┴ ┴ ┴ ┴└─┘┘└┘          ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||      Gene expression and regulation refer to the processes by which genes are activated,       ||   ");
            Console.WriteLine("    ||     transcribed, and translated into proteins, and the mechanisms that control when, where,    ||   ");
            Console.WriteLine("    ||      and how much of a gene product (usually a protein) is made. Proper gene regulation is     ||   ");
            Console.WriteLine("    ||               essential for development, adaptation, and cellular function.                    ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");

            Console.ReadKey();
        }

        static void InheritancePatterns()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                          ╦┌┐┌┬ ┬┌─┐┬─┐┬┌┬┐┌─┐┌┐┌┌─┐┌─┐  ╔═╗┌─┐┌┬┐┌┬┐┌─┐┬─┐┌┐┌┌─┐                          ");
            Console.WriteLine("                          ║│││├─┤├┤ ├┬┘│ │ ├─┤││││  ├┤   ╠═╝├─┤ │  │ ├┤ ├┬┘│││└─┐                          ");
            Console.WriteLine("                          ╩┘└┘┴ ┴└─┘┴└─┴ ┴ ┴ ┴┘└┘└─┘└─┘  ╩  ┴ ┴ ┴  ┴ └─┘┴└─┘└┘└─┘                          ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||        Inheritance patterns describe how genetic traits and conditions are passed from one     ||   ");
            Console.WriteLine("    ||         generation to the next. These patterns are determined by the location of the gene      ||   ");
            Console.WriteLine("    ||     (whether on autosomal or sex chromosomes) and whether the trait is dominant, recessive, or ||   ");
            Console.WriteLine("    ||                    follows other specific inheritance mechanisms.                              ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void GeneticTechnologies()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                           ╔═╗┌─┐┌┐┌┌─┐┌┬┐┬┌─┐  ╔╦╗┌─┐┌─┐┬ ┬┌┐┌┌─┐┬  ┌─┐┌─┐┬┌─┐┌─┐                         ");
            Console.WriteLine("                           ║ ╦├┤ │││├┤  │ ││     ║ ├┤ │  ├─┤││││ ││  │ ││ ┬│├┤ └─┐                         ");
            Console.WriteLine("                           ╚═╝└─┘┘└┘└─┘ ┴ ┴└─┘   ╩ └─┘└─┘┴ ┴┘└┘└─┘┴─┘└─┘└─┘┴└─┘└─┘                         ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||   Genetic technologies are techniques and tools developed to manipulate, analyze, and modify   ||   ");
            Console.WriteLine("    ||  genes and genetic material. These technologies play a critical role in medicine, agriculture, ||   ");
            Console.WriteLine("    ||    forensics, and biological research, enabling advances in areas like gene therapy, disease   ||   ");
            Console.WriteLine("    ||                             diagnostics, and genetic engineering.                              ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void HumanGenomeProjectInfo()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                          ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                        ");
            Console.WriteLine("                          ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                         ");
            Console.WriteLine("                          ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                         ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    The Human Genome Project (HGP) was an international research initiative with the primary    ||   ");
            Console.WriteLine("    ||       goal of mapping and understanding all the genes in human DNA. Launched in 1990 and       ||   ");
            Console.WriteLine("    ||       completed in 2003, it aimed to identify the sequence of the approximately 3 billion      ||   ");
            Console.WriteLine("    ||       nucleotide base pairs that make up human DNA, effectively providing a comprehensive      ||   ");
            Console.WriteLine("    ||                                   reference for the human genome.                              ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void EthicalConsiderations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("          ╔═╗┌┬┐┬ ┬┬┌─┐┌─┐┬    ╔═╗┌─┐┌┐┌┌─┐┬┌┬┐┌─┐┬─┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐  ┬┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┬┌─┐┌─┐        ");
            Console.WriteLine("          ║╣  │ ├─┤││  ├─┤│    ║  │ ││││└─┐│ ││├┤ ├┬┘├─┤ │ ││ ││││└─┐  ││││  ║ ╦├┤ │││├┤  │ ││  └─┐        ");
            Console.WriteLine("          ╚═╝ ┴ ┴ ┴┴└─┘┴ ┴┴─┘  ╚═╝└─┘┘└┘└─┘┴─┴┘└─┘┴└─┴ ┴ ┴ ┴└─┘┘└┘└─┘  ┴┘└┘  ╚═╝└─┘┘└┘└─┘ ┴ ┴└─┘└─┘        ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Genetic research and technologies, including gene editing, genetic testing, and cloning,    ||   ");
            Console.WriteLine("    ||     bring about significant ethical considerations. These involve questions about privacy,     ||   ");
            Console.WriteLine("    ||    fairness, human rights, and potential societal impacts. As genetics advances, so do the     ||   ");
            Console.WriteLine("    ||    ethical complexities surrounding its application, calling for careful consideration of      ||   ");
            Console.WriteLine("    ||                    how genetic information and interventions are used.                         ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void FutureGenetics()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                              ╔═╗┬ ┬┌┬┐┬ ┬┬─┐┌─┐  ┌─┐┌─┐  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┬┌─┐┌─┐                           ");
            Console.WriteLine("                              ╠╣ │ │ │ │ │├┬┘├┤   │ │├┤   ║ ╦├┤ │││├┤  │ ││  └─┐                           ");
            Console.WriteLine("                              ╚  └─┘ ┴ └─┘┴└─└─┘  └─┘└    ╚═╝└─┘┘└┘└─┘ ┴ ┴└─┘└─┘                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    The future of genetics holds immense potential for breakthroughs in medicine, agriculture,  ||   ");
            Console.WriteLine("    ||    environmental conservation, and personalized healthcare. As technologies in gene editing,   ||   ");
            Console.WriteLine("    ||    sequencing, and synthetic biology advance, genetics is likely to transform various fields,  ||   ");
            Console.WriteLine("    ||     ushering in new treatments, enhanced understanding of complex biological processes, and    ||   ");
            Console.WriteLine("    ||                                    ethical challenges.                                         ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void ChromosomesAndTheirFunction()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("             ╔═╗┬ ┬┬─┐┌─┐┌┬┐┌─┐┌─┐┌─┐┌┬┐┌─┐┌─┐  ┌─┐┌┐┌┌┬┐  ╔╦╗┬ ┬┌─┐┬┬─┐  ╔═╗┬ ┬┌┐┌┌─┐┌┬┐┬┌─┐┌┐┌           ");
            Console.WriteLine("             ║  ├─┤├┬┘│ │││││ │└─┐│ ││││├┤ └─┐  ├─┤│││ ││   ║ ├─┤├┤ │├┬┘  ╠╣ │ │││││   │ ││ ││││           ");
            Console.WriteLine("             ╚═╝┴ ┴┴└─└─┘┴ ┴└─┘└─┘└─┘┴ ┴└─┘└─┘  ┴ ┴┘└┘─┴┘   ╩ ┴ ┴└─┘┴┴└─  ╚  └─┘┘└┘└─┘ ┴ ┴└─┘┘└┘           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||   Chromosomes are thread-like structures located in the nucleus of cells, composed of DNA      ||   ");
            Console.WriteLine("    ||   and proteins that play a crucial role in heredity and cellular functions. Each chromosome    ||   ");
            Console.WriteLine("    ||   contains genes, which determine an organism's traits, and is made up of DNA wrapped around   ||   ");
            Console.WriteLine("    ||      proteins called histones. They consist of two identical halves, or sister chromatids,     ||   ");
            Console.WriteLine("    ||      connected at the centromere, and have protective caps called telomeres at their ends.     ||   ");
            Console.WriteLine("    ||          Chromosomes ensure accurate genetic material distribution during cell division        ||   ");
            Console.WriteLine("    ||      (mitosis and meiosis), regulate gene activity, enhance genetic diversity through the      ||   ");
            Console.WriteLine("    ||     shuffling of genetic material, and pass traits from parents to offspring. Additionally,    ||   ");
            Console.WriteLine("    ||     possess mechanisms to repair DNA damage, maintaining genetic stability and integrity.      ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void GeneticMutations()
        {
            int subOption = 0;

            do
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                AnimateGeneticMutations();
                Console.Clear();
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                              ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                           ");
                Console.WriteLine("                             ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                           ");
                Console.WriteLine("                             ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                           ");
                Console.WriteLine("                             ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                           ");
                Console.WriteLine("                             ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                           ");
                Console.WriteLine("                              ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
                Console.WriteLine("        ██                                                                                              ██             ");
                Console.WriteLine("        ██                                                                                              ██             ");
                Console.WriteLine("        ██                                       Genetic Mutations:                                     ██             ");
                Console.WriteLine("        ██                                                                                              ██             ");
                Console.WriteLine("        ██                                                   .:::::..                     .  .          ██             ");
                Console.WriteLine("        ██                                                ^!!7~^^^~!!!~:                 .?~?:          ██             ");
                Console.WriteLine("        ██                                              ~7~:??J::~JJ^ :!7:   .           .^P7.          ██             ");
                Console.WriteLine("        ██                                             77.  J!5!!?Y?!.  ^J^..!?  ..     !7~!77?:        ██             ");
                Console.WriteLine("        ██                                            !?    ??J7^~?Y~!. .:Y^~~J?7777!: ^J^!:~77Y        ██             ");
                Console.WriteLine("        ██          [ 1 ] Types of Mutations          J:    .J7!?!~: .~:..??  J~^^^77?77J~J^~Y!Y        ██             ");
                Console.WriteLine("        ██          [ 2 ] Causes of Mutations         J^    ~J77!J7J:::.:.?P..J^^7~~!^~?Y^^^^~!Y        ██             ");
                Console.WriteLine("        ██          [ 3 ] Effects of Mutations        :J.   J75!~?JJ!~::.!?!7 .7?7!^^^^:77^^^~!Y        ██             ");
                Console.WriteLine("        ██          [ 0 ] Go Back                      ^?~. J75~~7YJ!.:^7?..Y.  :!?!^^^^^~~!7?Y^        ██             ");
                Console.WriteLine("        ██                                              .~7!7J!:::7?~~77^   !7    .~7!?7!!~~~!J         ██             ");
                Console.WriteLine("        ██                                                 :^~!?J?7!~^.     .Y.  .^~!!Y!^..:^J~         ██             ");
                Console.WriteLine("        ██                                                     .:^~!!~^:.    !7 ^J!~^^~7?J?7?^          ██             ");
                Console.WriteLine("        ██                                                          .:^~!!~~^^Y:Y~^~!?~~^~^:            ██             ");
                Console.WriteLine("        ██                                                       ^!!!!!J!!7~~~!:J~^~J?..                ██             ");
                Console.WriteLine("        ██                                                      77^^!!7Y^??!7!: :?7~^!777J!~:           ██             ");
                Console.WriteLine("        ██                                            .::.     ~Y^!J^:::~?7!^~77^.~77!!~J7:~77.         ██             ");
                Console.WriteLine("        ██                                            ~Y?77^.  ?J75^      :!?!^!Y?^..::^7?~!7Y?         ██             ");
                Console.WriteLine("        ██                                             .~?777!7Y!!J         .!JJ^:?J!~^:~J!!!7J         ██             ");
                Console.WriteLine("        ██                                               .!?!!!7YJ:           :!77Y~^~!!~^^~7J:         ██             ");
                Console.WriteLine("        ██                                                 .^~~^:               .^!77!!!!7??!.          ██             ");
                Console.WriteLine("        ██                                                                          ..::::.             ██             ");
                Console.WriteLine("        ██                                                                                              ██             ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.Write("                               Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: TypesOfMutations(); break;
                    case 2: CausesOfMutations(); break;
                    case 3: EffectsOfMutations(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }


        static void AnimateGeneticMutations()
        {
            //  demonstrate genetic mutations using symbols
            string[] frames = new string[]
             {
            "        ====================================================================================================  \n" +
            "                                              Original DNA Sequence:\n" +
            "                                                A-T  C-G  A-T  G-C\n" +
            "                                                 |    |    |    |\n" +
            "                                                 |    |    |    |\n" +
            "                                                 A    T    A    G\n"+
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                              Mutation 1:\n" +
            "                                                A-T  C-G  A-T  G-C\n" +
            "                                                 |    |    |    |\n" +
            "                                                 |    |    |    |\n" +
            "                                                 A    T    G    G\n" +
            "                                                 (A-T changed to A-G)\n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                              Mutation 2:\n" +
            "                                                A-T  C-G  A-T  G-C\n" +
            "                                                 |    |    |    |\n" +
            "                                                 |    |    |    |\n" +
            "                                                 A    T    G    T\n" +
            "                                                 (C-G changed to T-A)\n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +

            "                                              Mutation 3:\n" +
            "                                                A-T  C-G  A-T  G-C\n" +
            "                                                 |    |    |    |\n" +
            "                                                 |    |    |    |\n" +
            "                                                 T    T    G    T\n" +
            "                                                 (A-T changed to T-T)\n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                              Final Mutated DNA Sequence:\n" +
            "                                                T-T  T-A  G-T  G-C\n" +
            "                                                 |    |    |    |\n" +
            "                                                 |    |    |    |\n" +
            "                                                 T    A    G    C\n" +
            "        ====================================================================================================  ",


        };

            // Loop create the animation effect
            for (int i = 0; i < 2; i++) // Repea a longer animation
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                                Genetic Mutations Loading...");
                    Thread.Sleep(1000); // Delay control animation speed
                }
            }
            Console.Clear();
            Console.WriteLine("Genetic Mutations Complete!");
        }

        static void TypesOfMutations()
        {
            int subOption = 0; // In-zero value to enter the loop

            do
            {
                Console.Clear();
                Console.WriteLine("                                                                                                          ");
                Console.WriteLine("                                    ╔═╗┌─┐┌┐┌┌─┐┌┬┐┬┌─┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                        ");
                Console.WriteLine("                                    ║ ╦├┤ │││├┤  │ ││    ║║║│ │ │ ├─┤ │ ││ ││││└─┐                        ");
                Console.WriteLine("                                    ╚═╝└─┘┘└┘└─┘ ┴ ┴└─┘  ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                        ");
                Console.WriteLine("                                                                                                          ");
                Console.WriteLine("        ==================================================================================================");
                Console.WriteLine("        ||                                                                                              ||");
                Console.WriteLine("        ||                                     Genetic Mutations:                                       ||");
                Console.WriteLine("        ||                                  [1] Point Mutations                                         ||");
                Console.WriteLine("        ||                                  [2]Frames hift Mutations                                    ||");
                Console.WriteLine("        ||                                  [3]SilentM utations                                         ||");
                Console.WriteLine("        ||                                  [4]Missense Mutations                                       ||");
                Console.WriteLine("        ||                                  [5]Nonsense Mutations                                       ||");
                Console.WriteLine("        ||                                  [6]Chromosoma lMutations                                    ||");
                Console.WriteLine("        ||                                  [0] Back                                                    ||");
                Console.WriteLine("        ||                                                                                              ||");
                Console.WriteLine("        ==================================================================================================");
                Console.WriteLine("                                                                                                          ");
                Console.Write("                               Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());
                switch (subOption)
                {
                    case 1: PointMutations(); break;
                    case 2: FrameshiftMutations(); break;
                    case 3: SilentMutations(); break;
                    case 4: MissenseMutations(); break;
                    case 5: NonsenseMutations(); break;
                    case 6: ChromosomalMutations(); break;
                    case 0: Console.WriteLine("           Returning to the main menu..."); break;
                    default:
                        break;
                }
            } while (subOption != 0);
        }

        static void PointMutations()
        {
            Console.Clear();
            Console.WriteLine("Point Mutations");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    ╔═╗┌─┐┬┌┐┌┌┬┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                                     ");
            Console.WriteLine("                                    ╠═╝│ │││││ │   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                                     ");
            Console.WriteLine("                                    ╩  └─┘┴┘└┘ ┴   ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                                     ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    Point mutations are alterations in a single nucleotide base pair in DNA that can significantly   ||    ");
            Console.WriteLine("    ||          impact genetic expression and function. They can occur in various forms, including         ||    ");
            Console.WriteLine("    ||        substitutions, insertions, and deletions. Substitutions can be silent (where the change      ||    ");
            Console.WriteLine("    ||        does not affect the amino acid sequence), missense (resulting in a different amino acid),    ||    ");
            Console.WriteLine("    ||        or nonsense (creating a premature stop codon). Although point mutations typically involve    ||    ");
            Console.WriteLine("    ||        a single nucleotide, they can lead to profound effects on protein structure and function,    ||    ");
            Console.WriteLine("    ||        potentially contributing to diseases or phenotypic variations. These mutations can occur     ||    ");
            Console.WriteLine("    ||           spontaneously during DNA replication or be induced by environmental factors such as       ||    ");
            Console.WriteLine("    ||            chemicals or radiation, playing a crucial role in genetic diversity and evolution.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();

        }

        static void FrameshiftMutations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                   ╔═╗┬─┐┌─┐┌┬┐┌─┐┌─┐┬ ┬┬┌─┐┌┬┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                       ");
            Console.WriteLine("                                   ╠╣ ├┬┘├─┤│││├┤ └─┐├─┤│├┤  │   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                       ");
            Console.WriteLine("                                   ╚  ┴└─┴ ┴┴ ┴└─┘└─┘┴ ┴┴└   ┴   ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                       ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||   Frameshift mutations occur when nucleotides are inserted or deleted from the DNA sequence,        ||    ");
            Console.WriteLine("    ||  resulting in a shift of the reading frame during protein synthesis. This can lead to dramatic      ||    ");
            Console.WriteLine("    ||  changes in the resulting amino acid sequence, often producing a nonfunctional protein. If the      ||    ");
            Console.WriteLine("    ||    number of nucleotides deleted or inserted is not a multiple of three, all downstream amino       ||    ");
            Console.WriteLine("    ||   acids will be altered. Frameshift mutations can arise from errors in DNA replication or from      ||    ");
            Console.WriteLine("    ||  environmental factors such as radiation and certain chemicals. These mutations play a significant  ||    ");
            Console.WriteLine("    ||      role in genetic disorders and can contribute to evolutionary processes by introducing new      ||    ");
            Console.WriteLine("    ||                                       variations in a population.                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();

        }

        static void SilentMutations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                   ╔═╗┬┬  ┌─┐┌┐┌┌┬┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                                   ");
            Console.WriteLine("                                   ╚═╗││  ├┤ │││ │   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                                   ");
            Console.WriteLine("                                   ╚═╝┴┴─┘└─┘┘└┘ ┴   ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                                   ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     Silent mutations are changes in the DNA sequence that do not alter the resulting protein's      ||    ");
            Console.WriteLine("    ||    amino acid sequence. These mutations often occur in regions of the DNA that are not critical     ||    ");
            Console.WriteLine("    ||      for protein function, such as synonymous codons that encode the same amino acid. Silent        ||    ");
            Console.WriteLine("    ||      mutations can also arise due to variations in the third nucleotide position of a codon,        ||    ");
            Console.WriteLine("    ||     which frequently does not affect the overall protein structure. While silent mutations are      ||    ");
            Console.WriteLine("    ||     often considered neutral, they can influence gene expression, mRNA stability, and overall       ||    ");
            Console.WriteLine("    ||     protein synthesis efficiency, playing a subtle yet significant role in genetic variability.     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void MissenseMutations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    ╔╦╗┬┌─┐┌─┐┌─┐┌┐┌┌─┐┌─┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                            ");
            Console.WriteLine("                                    ║║║│└─┐└─┐├┤ │││└─┐├┤   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                            ");
            Console.WriteLine("                                    ╩ ╩┴└─┘└─┘└─┘┘└┘└─┘└─┘  ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                            ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     Missense mutations are changes in the DNA sequence that result in the incorporation of a        ||    ");
            Console.WriteLine("    ||     different amino acid into the resulting protein. This alteration can affect the protein's       ||    ");
            Console.WriteLine("    ||    function, stability, and interactions with other molecules. Depending on the specific amino      ||    ");
            Console.WriteLine("    ||     acid substitution, the effects can range from benign to detrimental, potentially leading to     ||    ");
            Console.WriteLine("    ||    genetic disorders or diseases. Missense mutations arise from a single nucleotide substitution,   ||    ");
            Console.WriteLine("    ||     highlighting the importance of precise nucleotide sequences in maintaining protein integrity.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();

        }

        static void NonsenseMutations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                 ╔╗╔┌─┐┌┐┌┌─┐┌─┐┌┐┌┌─┐┌─┐  ┌┬┐┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                             ");
            Console.WriteLine("                                 ║║║│ ││││└─┐├┤ │││└─┐├┤   ││││ │ │ ├─┤ │ ││ ││││└─┐                             ");
            Console.WriteLine("                                 ╝╚╝└─┘┘└┘└─┘└─┘┘└┘└─┘└─┘  ┴ ┴└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                             ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     Nonsense mutations are changes in the DNA sequence that create a premature stop codon,          ||    ");
            Console.WriteLine("    ||    leading to truncated proteins that are often nonfunctional. This type of mutation occurs         ||    ");
            Console.WriteLine("    ||    when a nucleotide substitution changes a codon that normally encodes an amino acid into          ||    ");
            Console.WriteLine("    ||      a stop codon. As a result, the synthesis of the protein is halted, which can severely          ||    ");
            Console.WriteLine("    ||      affect cellular function and lead to various genetic disorders or diseases. Nonsense           ||    ");
            Console.WriteLine("    ||     mutations emphasize the critical importance of the genetic code in determining protein          ||    ");
            Console.WriteLine("    ||    structure and function, as even a single nucleotide change can have drastic consequences.        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();

        }

        static void ChromosomalMutations()
        {

            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                             ╔═╗┬ ┬┬─┐┌─┐┌┬┐┌─┐┌─┐┌─┐┌┬┐┌─┐┬    ┌┬┐┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                        ");
            Console.WriteLine("                             ║  ├─┤├┬┘│ │││││ │└─┐│ ││││├─┤│    ││││ │ │ ├─┤ │ ││ ││││└─┐                        ");
            Console.WriteLine("                             ╚═╝┴ ┴┴└─└─┘┴ ┴└─┘└─┘└─┘┴ ┴┴ ┴┴─┘  ┴ ┴└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                    ||    ");
            Console.WriteLine("    ||       Chromosomal mutations involve alterations to the structure or number of chromosomes,         ||    ");
            Console.WriteLine("    ||      leading to significant genetic changes. These mutations can occur through duplications,       ||    ");
            Console.WriteLine("    ||    deletions, inversions, or translocations of chromosome segments. Such alterations can result    ||    ");
            Console.WriteLine("    ||     in disorders such as Down syndrome, Turner syndrome, and many types of cancer. The effects     ||    ");
            Console.WriteLine("    ||      of chromosomal mutations can be profound, affecting gene dosage, expression, and function,    ||    ");
            Console.WriteLine("    ||                      ultimately impacting an organism's development and health.                    ||    ");
            Console.WriteLine("    ||                                                                                                    ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();

        }




        static void CausesOfMutations()
        {
            Console.Clear();
            Console.WriteLine("Causes of Mutations");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                               ╔═╗┌─┐┬ ┬┌─┐┌─┐┌─┐  ┌─┐┌─┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                             ");
            Console.WriteLine("                               ║  ├─┤│ │└─┐├┤ └─┐  │ │├┤   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                             ");
            Console.WriteLine("                               ╚═╝┴ ┴└─┘└─┘└─┘└─┘  └─┘└    ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                             ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Mutations can arise from various sources, including spontaneous processes during DNA           ||    ");
            Console.WriteLine("    ||     exposure to environmental factors, and the influence of specific chemicals. Spontaneous         ||    ");
            Console.WriteLine("    ||    mutations occur naturally due to errors in DNA synthesis or repair mechanisms. Environmental     ||    ");
            Console.WriteLine("    ||      mutagens, such as UV radiation and chemicals like benzene or formaldehyde, can increase        ||    ");
            Console.WriteLine("    ||        mutation rates by causing DNA damage or interfering with replication. Additionally,          ||    ");
            Console.WriteLine("    ||        certain viruses can integrate their genetic material into host genomes, leading to           ||    ");
            Console.WriteLine("    ||        mutations. Understanding the causes of mutations is essential for studying genetic           ||    ");
            Console.WriteLine("    ||                          diseases and the mechanisms of evolution.                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void EffectsOfMutations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                 ╔═╗┌─┐┌─┐┌─┐┌─┐┌┬┐┌─┐  ┌─┐┌─┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                        ");
            Console.WriteLine("                                 ║╣ ├┤ ├┤ ├┤ │   │ └─┐  │ │├┤   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                        ");
            Console.WriteLine("                                 ╚═╝└  └  └─┘└─┘ ┴ └─┘  └─┘└    ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    Mutations can have a variety of effects on organisms, ranging from neutral to harmful or even    ||    ");
            Console.WriteLine("    ||      beneficial. Some mutations may not affect the phenotype at all, while others can lead to       ||    ");
            Console.WriteLine("    ||     genetic disorders, cancer, or developmental abnormalities. Beneficial mutations may provide     ||    ");
            Console.WriteLine("    ||          an advantage in certain environments, contributing to evolution and adaptation.            ||    ");
            Console.WriteLine("    ||       Additionally, mutations play a crucial role in generating genetic diversity, which is         ||    ");
            Console.WriteLine("    ||      essential for populations to adapt to changing conditions. Understanding the effects of        ||    ");
            Console.WriteLine("    ||        mutations is key in fields such as medicine, agriculture, and evolutionary biology.          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }


        static void GeneEditing()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                GeneEditingAnimation();
                Console.Clear();
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("                                ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗               ");
                Console.WriteLine("                               ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝               ");
                Console.WriteLine("                               ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗               ");
                Console.WriteLine("                               ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║               ");
                Console.WriteLine("                               ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║               ");
                Console.WriteLine("                                ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝               ");
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████ ");
                Console.WriteLine("        ██                                                                                                ██ ");
                Console.WriteLine("        ██                       Gene Editing (CRISPR and Other Technologies):                            ██ ");
                Console.WriteLine("        ██                                                                                                ██ ");
                Console.WriteLine("        ██                                                 PBGY???7777777777777777?????JJJJY77777???      ██ ");
                Console.WriteLine("        ██                                                 ?PB5777!!!!!!!~~~~~~~~~!!!!!!!77777????JJ      ██ ");
                Console.WriteLine("        ██                                                 7JGG?!!~~~~~~~~^^^^^^^^^^~~~~~~!!!!777???      ██ ");
                Console.WriteLine("        ██                                                 77PBY~~^^^^^^^^^:::.:~~^::^^^^~~~~!!!!777      ██ ");
                Console.WriteLine("        ██  [ 1 ] What is CRISPR?                          G5PBPYYJ?7!~^^:::...:7YYJ7^::^^^^~~~~!!!7      ██ ");
                Console.WriteLine("        ██  [ 2 ] How CRISPR Works                         7JPGPY555P55Y7:......:75PP?^::^^^^~~~~!!!      ██ ");
                Console.WriteLine("        ██  [ 3 ] Applications of CRISPR in Medicine       ^^~YGY:::75P5?^......:!Y55J557:::^^^^~~~!      ██ ");
                Console.WriteLine("        ██  [ 4 ] Gene Therapy and CRISPR                  ^^^?GP!75P5?^. ..    ^?J!..^JJ!.:::^^^~~~      ██ ");
                Console.WriteLine("        ██  [ 5 ] Ethical Issues in Gene Editing           ^^:~5GPPP?^  .       .:.  . .^...:::^^^~~      ██ ");
                Console.WriteLine("        ██  [ 6 ] Future of CRISPR Technology              ^^::7GPJ^...   .           ......:::^^^~~      ██ ");
                Console.WriteLine("        ██  [ 7 ] Other Gene Editing Technologies          ^^:::JG5: .  :!7^        ..^.....:::^^^^~      ██ ");
                Console.WriteLine("        ██  [ 8 ] Gene Editing in Agriculture              ^^::::JGY^.^?JJ7:      .^J??^....::::^^^~      ██ ");
                Console.WriteLine("        ██  [ 9 ] Gene Editing and Cancer Research         ^^:::..7PPYPP?^      .!YPPPPJ....:::^^^^~      ██ ");
                Console.WriteLine("        ██  [ 10 ] Risks and Limitations of Gene Editing   ^^::::..^JPG5~.    .!5GPJ^^PG!..::::^^^~~      ██ ");
                Console.WriteLine("        ██  [ 0 ] Go Back                                  ^^^:::::..^7YPPY?!?PGP7:   YBY..::::^^^~~      ██ ");
                Console.WriteLine("        ██                                                 ^^^^:::::....:~7Y5PPGG55YJ?YGP7~~~^^^^^~~      ██ ");
                Console.WriteLine("        ██                                                 ~~^^^^:::::.......::^~!7??JYBG5PPGPPPYJ?7      ██ ");
                Console.WriteLine("        ██                                                 ~~~~^^^^::::::::...........:5B5~~!77YGGGG      ██ ");
                Console.WriteLine("        ██                                                 !!~~~~^^^^^^::::::::::::::^:7BB7^^!YPGPJ?      ██ ");
                Console.WriteLine("        ██                                                 7!!!!~~~~~^^^^^^^^^^^^^^^^^^~GB5!JPGPY77?      ██ ");
                Console.WriteLine("        ██                                                 ?7777!!!!~~~~~~~~~~~~~~~~~~~~YBGPGPY?7???      ██ ");
                Console.WriteLine("        ██                                                 ????77777!!!!7GBBPJ???JJJ77777????JJ77777      ██ ");
                Console.WriteLine("        ██                                                                                                ██ ");
                Console.WriteLine("        ██                                                                                                ██ ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████ ");
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("                                                                                                             ");
                Console.Write("                               Choose an option: ");


                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: WhatIsCRISPR(); break;
                    case 2: HowCRISPRWorks(); break;
                    case 3: ApplicationsOfCRISPR(); break;
                    case 4: GeneTherapy(); break;
                    case 5: EthicalIssuesGeneEditing(); break;
                    case 6: FutureOfCRISPR(); break;
                    case 7: OtherGeneEditingTechnologies(); break;
                    case 8: GeneEditingInAgriculture(); break;
                    case 9: GeneEditingCancerResearch(); break;
                    case 10: RisksAndLimitationsGeneEditing(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void GeneEditingAnimation()
        {

            string[] frames = new string[]
            {
        "        ====================================================================================================  \n "+
        "                                [G]-[A]-[T]-[C]-[A]-[T]-[C]-[G]-[A]-[T]-[C]-[G]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[A]-[T]-[C]-[G]-[A]-[T]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[A]-[T]-[C]-[G]-[A]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[A]-[T]-[C]-[G]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[A]-[T]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[A]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[G]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[A]-[G]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[G]-[A]-[G]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [C]-[G]-[A]-[G]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [C]-[G]-[T]-[G]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n" +
        "        ====================================================================================================  "

            };

            for (int i = 0; i < 3; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                             Gene Editing Loading...");
                    Thread.Sleep(300);
                }
            }


            Console.Clear();
            Console.WriteLine("Gene Editing Complete!");
        }


        static void WhatIsCRISPR()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                      ╦ ╦┬ ┬┌─┐┌┬┐  ┬┌─┐  ╔═╗╦═╗╦╔═╗╔═╗╦═╗┌─┐                                    ");
            Console.WriteLine("                                      ║║║├─┤├─┤ │   │└─┐  ║  ╠╦╝║╚═╗╠═╝╠╦╝ ┌┘                                    ");
            Console.WriteLine("                                      ╚╩╝┴ ┴┴ ┴ ┴   ┴└─┘  ╚═╝╩╚═╩╚═╝╩  ╩╚═ o                                     ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||   CRISPR (Clustered Regularly Interspaced Short Palindromic Repeats) is a revolutionary genetic     ||    ");
            Console.WriteLine("    ||    engineering technology that allows scientists to precisely alter DNA within living organisms.    ||    ");
            Console.WriteLine("    ||      It functions like a pair of molecular scissors, enabling targeted modifications that can       ||    ");
            Console.WriteLine("    ||    lead to advancements in medicine, agriculture, and biological research. Applications include     ||    ");
            Console.WriteLine("    ||      gene editing to correct genetic defects, enhance crop resilience, and develop treatments for   ||    ");
            Console.WriteLine("    ||                    various diseases. This powerful tool has the potential to transform multiple     ||    ");
            Console.WriteLine("    ||                        fields, but it also raises ethical questions regarding its use.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();

        }

        static void HowCRISPRWorks()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                      ╦ ╦┌─┐┬ ┬  ╔═╗╦═╗╦╔═╗╔═╗╦═╗  ╦ ╦┌─┐┬─┐┬┌─┌─┐                               ");
            Console.WriteLine("                                      ╠═╣│ ││││  ║  ╠╦╝║╚═╗╠═╝╠╦╝  ║║║│ │├┬┘├┴┐└─┐                               ");
            Console.WriteLine("                                      ╩ ╩└─┘└┴┘  ╚═╝╩╚═╩╚═╝╩  ╩╚═  ╚╩╝└─┘┴└─┴ ┴└─┘                               ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     CRISPR technology utilizes a guide RNA to locate specific DNA sequences, allowing the Cas9      ||    ");
            Console.WriteLine("    ||    enzyme to cut the DNA at precise locations. Once the DNA is cut, the cell's natural repair       ||    ");
            Console.WriteLine("    ||   mechanisms can be harnessed to insert, delete, or modify genes. This method is highly efficient   ||    ");
            Console.WriteLine("    ||   and can be used for a variety of applications, from basic research to developing gene therapies.  ||    ");
            Console.WriteLine("    ||   The flexibility and precision of CRISPR have made it a widely adopted tool in genetic research.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void ApplicationsOfCRISPR()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                ╔═╗┌─┐┌─┐┬  ┬┌─┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐  ┌─┐┌─┐  ╔═╗╦═╗╦╔═╗╔═╗╦═╗  ┬┌┐┌  ╔╦╗┌─┐┌┬┐┬┌─┐┬┌┐┌┌─┐           ");
            Console.WriteLine("                ╠═╣├─┘├─┘│  ││  ├─┤ │ ││ ││││└─┐  │ │├┤   ║  ╠╦╝║╚═╗╠═╝╠╦╝  ││││  ║║║├┤  ││││  ││││├┤            ");
            Console.WriteLine("                ╩ ╩┴  ┴  ┴─┘┴└─┘┴ ┴ ┴ ┴└─┘┘└┘└─┘  └─┘└    ╚═╝╩╚═╩╚═╝╩  ╩╚═  ┴┘└┘  ╩ ╩└─┘─┴┘┴└─┘┴┘└┘└─┘           ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     CRISPR has significant potential in medicine, including:                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     1. **Gene Therapy**: Correcting genetic disorders by editing faulty genes.                      ||    ");
            Console.WriteLine("    ||     2. **Cancer Treatment**: Targeting and disrupting cancer cell genes to inhibit growth.          ||    ");
            Console.WriteLine("    ||     3. **Infectious Diseases**: Developing treatments for viral infections like HIV.                ||    ");
            Console.WriteLine("    ||     4. **Drug Development**: Creating models for testing new drugs and understanding diseases.      ||    ");
            Console.WriteLine("    ||     5. **Personalized Medicine**: Tailoring treatments based on individual genetic profiles.        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GeneTherapy()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                             ╔═╗┌─┐┌┐┌┌─┐  ╔╦╗┬ ┬┌─┐┬─┐┌─┐┌─┐┬ ┬  ┌─┐┌┐┌┌┬┐  ╔═╗╦═╗╦╔═╗╔═╗╦═╗                    ");
            Console.WriteLine("                             ║ ╦├┤ │││├┤    ║ ├─┤├┤ ├┬┘├─┤├─┘└┬┘  ├─┤│││ ││  ║  ╠╦╝║╚═╗╠═╝╠╦╝                    ");
            Console.WriteLine("                             ╚═╝└─┘┘└┘└─┘   ╩ ┴ ┴└─┘┴└─┴ ┴┴   ┴   ┴ ┴┘└┘─┴┘  ╚═╝╩╚═╩╚═╝╩  ╩╚═                    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     Gene therapy aims to treat or prevent diseases by introducing, removing, or altering genetic    ||    ");
            Console.WriteLine("    ||    material within a patient's cells. CRISPR technology enhances this approach by allowing for      ||    ");
            Console.WriteLine("    ||    precise editing of genes, making it possible to correct mutations that cause genetic disorders.  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     Applications of CRISPR in gene therapy include:                                                 ||    ");
            Console.WriteLine("    ||     1. **Cystic Fibrosis**: Correcting mutations in the CFTR gene responsible for the disease.      ||    ");
            Console.WriteLine("    ||     2. **Sickle Cell Disease**: Editing genes to produce healthy red blood cells.                   ||    ");
            Console.WriteLine("    ||     3. **Hemophilia**: Targeting genes to restore normal blood clotting functions.                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void EthicalIssuesGeneEditing()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                     ╔═╗┌┬┐┬ ┬┬┌─┐┌─┐┬    ╦┌─┐┌─┐┬ ┬┌─┐┌─┐  ┬┌┐┌  ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┌┬┐┬┌┬┐┬┌┐┌┌─┐                ");
            Console.WriteLine("                     ║╣  │ ├─┤││  ├─┤│    ║└─┐└─┐│ │├┤ └─┐  ││││  ║ ╦├┤ │││├┤   ║╣  │││ │ │││││ ┬                ");
            Console.WriteLine("                     ╚═╝ ┴ ┴ ┴┴└─┘┴ ┴┴─┘  ╩└─┘└─┘└─┘└─┘└─┘  ┴┘└┘  ╚═╝└─┘┘└┘└─┘  ╚═╝─┴┘┴ ┴ ┴┘└┘└─┘                ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     The rapid development of gene editing technologies like CRISPR has raised several ethical       ||    ");
            Console.WriteLine("    ||     concerns, including:                                                                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     1. **Safety and Unintended Consequences**: Potential off-target effects that could harm         ||    ");
            Console.WriteLine("    ||        patients or create new health issues.                                                        ||    ");
            Console.WriteLine("    ||     2. **Accessibility and Inequality**: The risk of creating a divide between those who can        ||    ");
            Console.WriteLine("    ||        afford gene editing treatments and those who cannot.                                         ||    ");
            Console.WriteLine("    ||     3. **Genetic Enhancement**: Ethical dilemmas surrounding the desire to enhance human traits,    ||    ");
            Console.WriteLine("    ||        leading to concerns about 'designer babies'.                                                 ||    ");
            Console.WriteLine("    ||     4. **Consent**: Challenges in obtaining informed consent, especially for germline editing that  ||    ");
            Console.WriteLine("    ||        affects future generations.                                                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void FutureOfCRISPR()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                 ╔═╗┬ ┬┌┬┐┬ ┬┬─┐┌─┐  ┌─┐┌─┐  ╔═╗╦═╗╦╔═╗╔═╗╦═╗  ╔╦╗┌─┐┌─┐┬ ┬┌┐┌┌─┐┬  ┌─┐┌─┐┬ ┬                    ");
            Console.WriteLine("                 ╠╣ │ │ │ │ │├┬┘├┤   │ │├┤   ║  ╠╦╝║╚═╗╠═╝╠╦╝   ║ ├┤ │  ├─┤││││ ││  │ ││ ┬└┬┘                    ");
            Console.WriteLine("                 ╚  └─┘ ┴ └─┘┴└─└─┘  └─┘└    ╚═╝╩╚═╩╚═╝╩  ╩╚═   ╩ └─┘└─┘┴ ┴┘└┘└─┘┴─┘└─┘└─┘ ┴                     ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||   The future of CRISPR is promising, with potential to transform medicine, agriculture, and more.   ||    ");
            Console.WriteLine("    ||   Advances may include curing genetic diseases, precise cancer therapies, and engineered crops.     ||    ");
            Console.WriteLine("    ||   New forms like base and prime editing could refine the precision of gene edits. Ethical and       ||    ");
            Console.WriteLine("    ||   safety challenges remain critical, especially in germline editing. Improved delivery methods      ||    ");
            Console.WriteLine("    ||   and expanded applications will likely make CRISPR a core tool in biology and beyond.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void OtherGeneEditingTechnologies()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                ╔═╗┌┬┐┬ ┬┌─┐┬─┐  ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┌┬┐┬┌┬┐┬┌┐┌┌─┐  ╔╦╗┌─┐┌─┐┬ ┬┌┐┌┌─┐┬  ┌─┐┌─┐┬┌─┐┌─┐             ");
            Console.WriteLine("                ║ ║ │ ├─┤├┤ ├┬┘  ║ ╦├┤ │││├┤   ║╣  │││ │ │││││ ┬   ║ ├┤ │  ├─┤││││ ││  │ ││ ┬│├┤ └─┐             ");
            Console.WriteLine("                ╚═╝ ┴ ┴ ┴└─┘┴└─  ╚═╝└─┘┘└┘└─┘  ╚═╝─┴┘┴ ┴ ┴┘└┘└─┘   ╩ └─┘└─┘┴ ┴┘└┘└─┘┴─┘└─┘└─┘┴└─┘└─┘             ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    TALENs (Transcription Activator-Like Effector Nucleases)                                         ||    ");
            Console.WriteLine("    ||    - TALENs bind to specific DNA sequences and introduce cuts. They are versatile but more          ||    ");
            Console.WriteLine("    ||      labor-intensive than CRISPR. They’re useful for high-precision gene targeting.                 ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    ZFNs (Zinc Finger Nucleases)                                                                     ||    ");
            Console.WriteLine("    ||    - ZFNs use engineered zinc finger proteins to target DNA. They were some of the first            ||    ");
            Console.WriteLine("    ||      gene-editing tools, yet their complex engineering limits broader use compared to CRISPR.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    Prime Editing                                                                                    ||    ");
            Console.WriteLine("    ||    - An advanced form of CRISPR that enables highly precise base edits without making DNA           ||    ");
            Console.WriteLine("    ||      double-strand breaks. Prime editing is promising for correcting point mutations.               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    Base Editing                                                                                     ||    ");
            Console.WriteLine("    ||    - Another CRISPR-based tool, base editing allows for single base pair changes, offering          ||    ");
            Console.WriteLine("    ||      precision for small mutations, particularly useful in diseases caused by single base errors.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GeneEditingInAgriculture()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                      ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┌┬┐┬┌┬┐┬┌┐┌┌─┐  ┬┌┐┌  ╔═╗┌─┐┬─┐┬┌─┐┬ ┬┬ ┌┬┐┬ ┬┬─┐┌─┐                      ");
            Console.WriteLine("                      ║ ╦├┤ │││├┤   ║╣  │││ │ │││││ ┬  ││││  ╠═╣│ ┬├┬┘││  │ ││  │ │ │├┬┘├┤                       ");
            Console.WriteLine("                      ╚═╝└─┘┘└┘└─┘  ╚═╝─┴┘┴ ┴ ┴┘└┘└─┘  ┴┘└┘  ╩ ╩└─┘┴└─┴└─┘└─┘┴─┘┴ └─┘┴└─└─┘                      ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Gene editing is transforming agriculture by making crops and livestock more resilient,         ||    ");
            Console.WriteLine("    ||      productive, and sustainable. Some applications include:                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Crop Improvement                                                                               ||    ");
            Console.WriteLine("    ||      - Gene editing enables crops with enhanced traits like drought tolerance, pest resistance,     ||    ");
            Console.WriteLine("    ||        and increased yield. These improvements reduce reliance on pesticides and improve food       ||    ");
            Console.WriteLine("    ||        security, especially in climate-challenged regions.                                          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Nutritional Enhancement                                                                        ||    ");
            Console.WriteLine("    ||      - Gene editing is used to increase nutritional content, such as higher vitamin levels or       ||    ");
            Console.WriteLine("    ||        better protein quality, addressing malnutrition and offering healthier options.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Disease Resistance                                                                             ||    ");
            Console.WriteLine("    ||      - Crops and livestock can be edited for resistance to diseases that impact food supply         ||    ");
            Console.WriteLine("    ||        and lead to heavy agricultural losses, reducing waste and enhancing productivity.            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Reducing Environmental Impact                                                                  ||    ");
            Console.WriteLine("    ||      - Gene-edited plants can improve soil health, reduce greenhouse gases, and even enhance        ||    ");
            Console.WriteLine("    ||        carbon capture. These crops help make agriculture more sustainable and environmentally       ||    ");
            Console.WriteLine("    ||        friendly.                                                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GeneEditingCancerResearch()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("             ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┌┬┐┬┌┬┐┬┌┐┌┌─┐  ┌─┐┌┐┌┌┬┐  ╔═╗┌─┐┌┐┌┌─┐┌─┐┬─┐  ╦═╗┌─┐┌─┐┌─┐┌─┐┬─┐┌─┐┬ ┬            ");
            Console.WriteLine("             ║ ╦├┤ │││├┤   ║╣  │││ │ │││││ ┬  ├─┤│││ ││  ║  ├─┤││││  ├┤ ├┬┘  ╠╦╝├┤ └─┐├┤ ├─┤├┬┘│  ├─┤            ");
            Console.WriteLine("             ╚═╝└─┘┘└┘└─┘  ╚═╝─┴┘┴ ┴ ┴┘└┘└─┘  ┴ ┴┘└┘─┴┘  ╚═╝┴ ┴┘└┘└─┘└─┘┴└─  ╩╚═└─┘└─┘└─┘┴ ┴┴└─└─┘┴ ┴            ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       Gene editing technology has become a powerful tool in cancer research, with applications      ||    ");
            Console.WriteLine("    ||       that include:                                                                                 ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       Targeted Cancer Therapy                                                                       ||    ");
            Console.WriteLine("    ||       - CRISPR and other gene-editing tools can target specific cancer-related genes, allowing      ||    ");
            Console.WriteLine("    ||         researchers to deactivate or repair mutations that drive cancer growth.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       CAR-T Cell Engineering                                                                        ||    ");
            Console.WriteLine("    ||       - Gene editing is used to modify T-cells to recognize and attack cancer cells more            ||    ");
            Console.WriteLine("    ||         in CAR-T cell therapies. This approach shows promise for blood cancers like leukemia.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       Immune System Optimization                                                                    ||    ");
            Console.WriteLine("    ||       - Gene editing enhances immune cells' abilities to evade cancer’s defense mechanisms,         ||    ");
            Console.WriteLine("    ||         providing more robust immune responses against solid tumors.                                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       Cancer-Related Gene Function Analysis                                                         ||    ");
            Console.WriteLine("    ||       - CRISPR allows scientists to study how specific genes contribute to cancer, helping          ||    ");
            Console.WriteLine("    ||         to identify new drug targets and understand cancer resistance to treatments.                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       Tumor Microenvironment Engineering                                                            ||    ");
            Console.WriteLine("    ||       - Gene editing can alter the environment surrounding tumors, affecting factors like           ||    ");
            Console.WriteLine("    ||         immune cell access and nutrient supply to slow or inhibit tumor growth.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void RisksAndLimitationsGeneEditing()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("          ╦═╗┬┌─┐┬┌─┌─┐  ┌─┐┌┐┌┌┬┐  ╦  ┬┌┬┐┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐  ┌─┐┌─┐  ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┌┬┐┬┌┬┐┬┌┐┌┌─┐         ");
            Console.WriteLine("          ╠╦╝│└─┐├┴┐└─┐  ├─┤│││ ││  ║  │││││ │ ├─┤ │ ││ ││││└─┐  │ │├┤   ║ ╦├┤ │││├┤   ║╣  │││ │ │││││ ┬         ");
            Console.WriteLine("          ╩╚═┴└─┘┴ ┴└─┘  ┴ ┴┘└┘─┴┘  ╩═╝┴┴ ┴┴ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘  └─┘└    ╚═╝└─┘┘└┘└─┘  ╚═╝─┴┘┴ ┴ ┴┘└┘└─┘         ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Gene editing holds great potential but also comes with risks and limitations, including:       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Off-Target Effects                                                                             ||    ");
            Console.WriteLine("    ||      - Gene editing tools can unintentionally alter non-targeted DNA sequences, potentially         ||    ");
            Console.WriteLine("    ||        causing harmful mutations or disrupting other genes, leading to unexpected side effects.     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Ethical Concerns                                                                               ||    ");
            Console.WriteLine("    ||      - Editing germline cells could affect future generations, raising concerns about unintended    ||    ");
            Console.WriteLine("    ||        consequences, consent, and the possibility of creating designer traits.                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Technical Challenges                                                                           ||    ");
            Console.WriteLine("    ||      - Precise delivery of gene-editing tools to specific cells or tissues remains challenging.     ||    ");
            Console.WriteLine("    ||        Inefficient delivery methods can reduce the effectiveness of the edits and increase risks.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Limited Understanding of Gene Functions                                                        ||    ");
            Console.WriteLine("    ||      - Our knowledge of all gene functions is still incomplete, meaning that editing certain genes  ||    ");
            Console.WriteLine("    ||        may have unintended and unknown consequences on other biological processes.                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Immune Reactions                                                                               ||    ");
            Console.WriteLine("    ||      - Introducing foreign gene-editing tools, especially in therapeutic settings, can trigger      ||    ");
            Console.WriteLine("    ||        immune responses, which may reduce the effectiveness of the treatment or cause harm.         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Accessibility and Inequity                                                                     ||    ");
            Console.WriteLine("    ||      - High costs and resource demands could make gene editing accessible only to a few,            ||    ");
            Console.WriteLine("    ||        potentially increasing social inequality.                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void HumanGenomeProject()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                HumanGenomeAnimation();
                Console.Clear();
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                         ");
                Console.WriteLine("                               ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                         ");
                Console.WriteLine("                               ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                         ");
                Console.WriteLine("                               ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                         ");
                Console.WriteLine("                               ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                         ");
                Console.WriteLine("                                ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                         ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
                Console.WriteLine("        ██                                                                                                ██           ");
                Console.WriteLine("        ██                                    Human Genome Project:                                       ██           ");
                Console.WriteLine("        ██                                                                                                ██           ");
                Console.WriteLine("        ██                                                   &&&&&&&#BGG5P5PPB#&###&&&&&&&&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██                                                   &&&&&#PJ??7JYJ?7~~YG#&&&&&&&&&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██                                                   &&&&#55P5G5P55JJ55YY5#&&&&&&&&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██                                                   &&&&5PGPGGGPPGPGGPGGPG&&&&&&&&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██                                                   &&&&GPPPGGBGBGBBPBBBBB&&&&&&&&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██  [ 1 ] Overview                                   &&&&BP5PGJ7?BB##BBBBB#&&&&&&&&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██  [ 2 ] Goals                                      &&&&#J!J5?!JG&&&BGB#B#&&&&&&&&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██  [ 3 ] Timeline                                   &&&&&5!55P?BG#GBGB#BB&&&&&&&&&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██  [ 4 ] Achievements                               &&&&&&55GGB#BBGGGBB##&&&&&&&&&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██  [ 5 ] Impact  on Medicine                        &&&&&&#55J5J7~~7Y#BGPB@&&&&&&&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██  [ 6 ] Ethical Concerns Related                   &&&&&&&&#P5J775G5PBBG5B@&&&&&&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██  [ 7 ] International Collaboration                &&&&&&&&&@@&5YPG5?BG5J?5G#&&@&&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██  [ 8 ] Role of Technology                         &&&&&&&&&&&&BYY5YYGP5J!~~~!J5G&&&&&&&&&&&    ██           ");
                Console.WriteLine("        ██  [ 9 ] Project and Personalized Medicine          &&&&&&&&&&&&&PYY77PY77!^~!7!77YP#&&&&&&&&    ██           ");
                Console.WriteLine("        ██  [ 10 ] Future of Genomic Research                &&&&&&&&&&&&@#YJJYYJJP??JYY5J55P5B&&&&&&&    ██           ");
                Console.WriteLine("        ██  [ 0 ] Go Back                                    &&&&&&&&&&&@&BJJYPGP##P?J?Y5BYB##BP&&&&&&    ██           ");
                Console.WriteLine("        ██                                                   &&&&&&&&&&&P??PPPPGGGGP7YJ?JGPGGBP5G&&&&&    ██           ");
                Console.WriteLine("        ██                                                   &&&&&&&&&&Y?5GGGGGGPYYYJ5YJ7?PPYGPGP#&&&&    ██           ");
                Console.WriteLine("        ██                                                   &&&@&&&&@&7?J5555P5P5PP?JYJJJ5PP?5GPG&&&&    ██           ");
                Console.WriteLine("        ██                                                   &&&&&&&&&@5!J5PPPPPPPPGYJGJ?Y?~P5YPBPB@&&    ██           ");
                Console.WriteLine("        ██                                                   &&&&&&&&&&#?Y5P55555P5GP5YYPJ?^7P5JBBG&&&    ██           ");
                Console.WriteLine("        ██                                                   &&&&&&&&&&PPGYYYYYJYPJYYY~YP??!755YJPYB@&    ██           ");
                Console.WriteLine("        ██                                                                                                ██           ");
                Console.WriteLine("        ██                                                                                                ██           ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.Write("                               Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: OverviewHumanGenomeProject(); break;
                    case 2: GoalsHumanGenomeProject(); break;
                    case 3: TimelineHumanGenomeProject(); break;
                    case 4: AchievementsHumanGenomeProject(); break;
                    case 5: ImpactHumanGenomeProject(); break;
                    case 6: EthicalConcernsHumanGenomeProject(); break;
                    case 7: InternationalCollaboration(); break;
                    case 8: RoleOfTechnology(); break;
                    case 9: PersonalizedMedicine(); break;
                    case 10: FutureGenomicResearch(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void HumanGenomeAnimation()
        {

            string[] frames = new string[]
            {
        "        ====================================================================================================  \n"+
        "                        __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                      (A  )(C  )(G  )(T  )(C  )(G  )(A  )(T  )(C  )(A  )(G  )(T  )\n" +
        "                       \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\n" +
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                       __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                     (A  )(C  )(G  )(T  )(C  )(G  )(A  )(T  )(C  )(A  )(G  )(A  )\n" +
        "                      \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\n" +
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                       __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                     (A  )(C  )(G  )(T  )(C  )(G  )(A  )(T  )(C  )(T  )(G  )(A  )\n" +
        "                      \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\n" +
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                       __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                     (A  )(C  )(G  )(T  )(C  )(G  )(A  )(G  )(C  )(T  )(G  )(A  )\n" +
        "                      \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\n" +
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                       __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                     (A  )(C  )(G  )(T  )(C  )(G  )(A  )(T  )(C  )(T  )(G  )(A  )\n" +
        "                      \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\n" +
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                       __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                     (A  )(C  )(G  )(T  )(C  )(G  )(A  )(T  )(C  )(A  )(G  )(T  )\n" +
        "                      \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__/\n" +
        "        ====================================================================================================  ",

            };

            for (int i = 0; i < 3; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                            Human Genome Sequencing Loading...");
                    Thread.Sleep(300);
                }
            }

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Human Genome Sequencing Complete!");
        }


        static void OverviewHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("     ╔═╗┬  ┬┌─┐┬─┐┬  ┬┬┌─┐┬ ┬  ┌─┐┌─┐  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐      ");
            Console.WriteLine("     ║ ║└┐┌┘├┤ ├┬┘└┐┌┘│├┤ │││  │ │├┤    │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │       ");
            Console.WriteLine("     ╚═╝ └┘ └─┘┴└─ └┘ ┴└─┘└┴┘  └─┘└     ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴       ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) was an international research effort that mapped and            ||    ");
            Console.WriteLine("    ||      sequenced all the genes of the human genome. Completed in 2003, the HGP revolutionized         ||    ");
            Console.WriteLine("    ||      biology and genetics, with several key goals and accomplishments:                              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Mapping the Human Genome                                                                       ||    ");
            Console.WriteLine("    ||      - Scientists identified approximately 20,000-25,000 genes and mapped their locations on        ||    ");
            Console.WriteLine("    ||        human chromosomes, laying the foundation for understanding gene function and structure.      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Sequencing DNA                                                                                 ||    ");
            Console.WriteLine("    ||      - By decoding the three billion base pairs in human DNA, researchers gained insight into       ||    ");
            Console.WriteLine("    ||        genetic diversity and hereditary factors influencing health and disease.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Advancing Genomic Medicine                                                                     ||    ");
            Console.WriteLine("    ||      - The HGP enabled personalized medicine by helping scientists link specific genes to           ||    ");
            Console.WriteLine("    ||        diseases and create targeted treatments based on individual genetic profiles.                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Open Data for Global Research                                                                  ||    ");
            Console.WriteLine("    ||      - All HGP data was made publicly available, fueling worldwide research, accelerating           ||    ");
            Console.WriteLine("    ||        biomedical advances, and fostering collaboration.                                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Legacy and Future Research                                                                     ||    ");
            Console.WriteLine("    ||      - The HGP's success has led to further genome projects, including those of other species,      ||    ");
            Console.WriteLine("    ||        and has set the stage for gene editing and synthetic biology advancements.                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GoalsHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("           ╔═╗┌─┐┌─┐┬  ┌─┐  ┌─┐┌─┐  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐         ");
            Console.WriteLine("           ║ ╦│ │├─┤│  └─┐  │ │├┤    │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │          ");
            Console.WriteLine("           ╚═╝└─┘┴ ┴┴─┘└─┘  └─┘└     ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴          ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) set out to map and understand all genes in human DNA, with      ||    ");
            Console.WriteLine("    ||      several ambitious goals driving this monumental project:                                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Sequencing the Human Genome                                                                    ||    ");
            Console.WriteLine("    ||      - One of the main goals was to sequence the three billion DNA base pairs in the human genome,  ||    ");
            Console.WriteLine("    ||        laying the groundwork for understanding genetic instructions and variation.                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Identifying All Human Genes                                                                    ||    ");
            Console.WriteLine("    ||      - Researchers aimed to locate and identify all human genes (estimated to be 20,000-25,000),    ||    ");
            Console.WriteLine("    ||        providing a comprehensive catalog to drive biomedical advances and diagnostics.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Mapping Genetic Variation                                                                      ||    ");
            Console.WriteLine("    ||      - The project sought to understand variations between individuals and populations, providing   ||    ");
            Console.WriteLine("    ||        insight into inherited traits, susceptibility to diseases, and human evolution.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Developing Technologies                                                                        ||    ");
            Console.WriteLine("    ||      - A major goal was to create new tools and methods for genome analysis, improving accuracy,    ||    ");
            Console.WriteLine("    ||        speed, and accessibility for future genetic research.                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Promoting Ethical, Legal, and Social Awareness                                                 ||    ");
            Console.WriteLine("    ||      - The HGP recognized the need to address the ethical, legal, and social implications of        ||    ");
            Console.WriteLine("    ||        genetic knowledge, aiming to ensure responsible use of genomic data.                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void TimelineHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("       ╔╦╗┬┌┬┐┌─┐┬  ┬┌┐┌┌─┐  ┌─┐┌─┐  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐        ");
            Console.WriteLine("        ║ ││││├┤ │  ││││├┤   │ │├┤    │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │         ");
            Console.WriteLine("        ╩ ┴┴ ┴└─┘┴─┘┴┘└┘└─┘  └─┘└     ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴         ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Key Milestones :                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1990                                                                                           ||    ");
            Console.WriteLine("    ||      - The Human Genome Project officially launched as an international effort, led by the          ||    ");
            Console.WriteLine("    ||        United States, with a goal of mapping the entire human genome within 15 years.               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1992                                                                                           ||    ");
            Console.WriteLine("    ||      - The project completed the first chromosome map, marking the initial success in mapping       ||    ");
            Console.WriteLine("    ||        the order of genes on a human chromosome.                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1996                                                                                           ||    ");
            Console.WriteLine("    ||      - The HGP created an extensive public database for genomic data, allowing researchers          ||    ");
            Console.WriteLine("    ||        worldwide to access and build on the project’s findings.                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1999                                                                                           ||    ");
            Console.WriteLine("    ||      - Scientists completed the first fully sequenced human chromosome, Chromosome 22, a            ||    ");
            Console.WriteLine("    ||        major milestone in understanding human genetics.                                             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2000                                                                                           ||    ");
            Console.WriteLine("    ||      - The first draft of the human genome was announced, covering over 90% of the entire genome    ||    ");
            Console.WriteLine("    ||        and marking a significant breakthrough in genetics.                                          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2003                                                                                           ||    ");
            Console.WriteLine("    ||      - The Human Genome Project was completed, two years ahead of schedule, providing a             ||    ");
            Console.WriteLine("    ||        comprehensive map of the human genome and opening new doors for medical and genetic          ||    ");
            Console.WriteLine("    ||        research.                                                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void AchievementsHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                           ╔═╗┌─┐┬ ┬┬┌─┐┬  ┬┌─┐┌┬┐┌─┐┌┐┌┌┬┐┌─┐  ┌─┐┌─┐  ┌┬┐┬ ┬┌─┐                                ");
            Console.WriteLine("                           ╠═╣│  ├─┤│├┤ └┐┌┘├┤ │││├┤ │││ │ └─┐  │ │├┤    │ ├─┤├┤                                 ");
            Console.WriteLine("                           ╩ ╩└─┘┴ ┴┴└─┘ └┘ └─┘┴ ┴└─┘┘└┘ ┴ └─┘  └─┘└     ┴ ┴ ┴└─┘                                ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                          ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                              ");
            Console.WriteLine("                          ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                               ");
            Console.WriteLine("                          ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                               ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) achieved several groundbreaking milestones that have            ||    ");
            Console.WriteLine("    ||      our understanding of genetics, medicine, and biology:                                          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Complete Sequence of the Human Genome                                                       ||    ");
            Console.WriteLine("    ||      - Successfully mapped and sequenced the entire human genome, encompassing approximately        ||    ");
            Console.WriteLine("    ||        3 billion base pairs and identifying around 20,000-25,000 genes.                             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Genetic Variation Mapping                                                                   ||    ");
            Console.WriteLine("    ||      - Characterized genetic variation across populations, helping to identify links between        ||    ");
            Console.WriteLine("    ||        genetic variations and specific diseases.                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Advances in Genomic Medicine                                                                ||    ");
            Console.WriteLine("    ||      - Laid the foundation for personalized medicine by correlating genetic information with        ||    ");
            Console.WriteLine("    ||        disease susceptibility and treatment responses.                                              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Development of New Technologies                                                             ||    ");
            Console.WriteLine("    ||      - Fostered innovation in DNA sequencing and analysis technologies, leading to faster, cheaper, ||    ");
            Console.WriteLine("    ||        and more accurate genomic research methods.                                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Public Access to Genetic Data                                                               ||    ");
            Console.WriteLine("    ||      - Made genomic data publicly available, encouraging collaboration and research worldwide.      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void ImpactHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                  ╦┌┬┐┌─┐┌─┐┌─┐┌┬┐  ┌─┐┌─┐  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐                       ");
            Console.WriteLine("                  ║│││├─┘├─┤│   │   │ │├┤    │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤                        ");
            Console.WriteLine("                  ╩┴ ┴┴  ┴ ┴└─┘ ┴   └─┘└     ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘                       ");
            Console.WriteLine("                                ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐  ┌─┐┌┐┌  ╔╦╗┌─┐┌┬┐┬┌─┐┬┌┐┌┌─┐                               ");
            Console.WriteLine("                                ╠═╝├┬┘│ │ │├┤ │   │   │ ││││  ║║║├┤  ││││  ││││├┤                                ");
            Console.WriteLine("                                ╩  ┴└─└─┘└┘└─┘└─┘ ┴   └─┘┘└┘  ╩ ╩└─┘─┴┘┴└─┘┴┘└┘└─┘                               ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) has significantly impacted medicine in several transformative   ||    ");
            Console.WriteLine("    ||      ways, leading to advancements in diagnosis, treatment, and understanding of diseases:          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Personalized Medicine                                                                       ||    ");
            Console.WriteLine("    ||      - Enabled tailored medical treatments based on individual genetic profiles, allowing for       ||    ");
            Console.WriteLine("    ||        more effective therapies with fewer side effects.                                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Early Diagnosis and Screening                                                               ||    ");
            Console.WriteLine("    ||      - Improved diagnostic tools for genetic disorders, allowing for earlier detection and          ||    ");
            Console.WriteLine("    ||        intervention in conditions such as cystic fibrosis and certain cancers.                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Targeted Therapies                                                                          ||    ");
            Console.WriteLine("    ||      - Development of targeted therapies, such as monoclonal antibodies for cancer treatment,       ||    ");
            Console.WriteLine("    ||        based on specific genetic mutations.                                                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Understanding Genetic Diseases                                                              ||    ");
            Console.WriteLine("    ||      - Enhanced knowledge of the genetic basis of complex diseases, such as Alzheimer's and         ||    ");
            Console.WriteLine("    ||        diabetes, informing prevention and treatment strategies.                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Pharmacogenomics                                                                            ||    ");
            Console.WriteLine("    ||      - Integration of genetic information into drug development, leading to safer and more          ||    ");
            Console.WriteLine("    ||        effective medications based on genetic variability in drug metabolism.                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void EthicalConcernsHumanGenomeProject()
        {
            Console.Clear();

            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                         ╔═╗┌┬┐┬ ┬┬┌─┐┌─┐┬    ╔═╗┌─┐┌┐┌┌─┐┌─┐┬─┐┌┐┌┌─┐  ╦═╗┌─┐┬  ┌─┐┌┬┐┌─┐┌┬┐                    ");
            Console.WriteLine("                         ║╣  │ ├─┤││  ├─┤│    ║  │ │││││  ├┤ ├┬┘│││└─┐  ╠╦╝├┤ │  ├─┤ │ ├┤  ││                    ");
            Console.WriteLine("                         ╚═╝ ┴ ┴ ┴┴└─┘┴ ┴┴─┘  ╚═╝└─┘┘└┘└─┘└─┘┴└─┘└┘└─┘  ╩╚═└─┘┴─┘┴ ┴ ┴ └─┘─┴┘                    ");
            Console.WriteLine("                     ┌┬┐┌─┐  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                ");
            Console.WriteLine("                      │ │ │   │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                 ");
            Console.WriteLine("                      ┴ └─┘   ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) raises several ethical concerns that have important             ||    ");
            Console.WriteLine("    ||      for individuals and society, including:                                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Privacy and Confidentiality                                                                 ||    ");
            Console.WriteLine("    ||      - Concerns about how genetic information is stored and shared, including potential misuse of   ||    ");
            Console.WriteLine("    ||        personal genetic data by employers or insurers.                                              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Genetic Discrimination                                                                      ||    ");
            Console.WriteLine("    ||      - Risks of discrimination based on genetic information, such as employment or insurance .      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Informed Consent                                                                            ||    ");
            Console.WriteLine("    ||      - Ethical issues surrounding obtaining informed consent from participants in genetic,          ||    ");
            Console.WriteLine("    ||        particularly regarding the use and sharing of their genetic information.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Access to Genetic Information                                                               ||    ");
            Console.WriteLine("    ||      - Concerns about equitable access to genetic testing and therapies,                            ||    ");
            Console.WriteLine("    ||        disparities among different populations.                                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Potential for 'Designer Babies'                                                             ||    ");
            Console.WriteLine("    ||      - Ethical dilemmas regarding genetic modification of embryos and the potential for creating    ||    ");
            Console.WriteLine("    ||        'designer babies' based on desirable traits, raising concerns about eugenics.                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void InternationalCollaboration()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("               ╦┌┐┌┌┬┐┌─┐┬─┐┌┐┌┌─┐┌┬┐┬┌─┐┌┐┌┌─┐┬    ╔═╗┌─┐┬  ┬  ┌─┐┌┐ ┌─┐┬─┐┌─┐┌┬┐┬┌─┐┌┐┌                        ");
            Console.WriteLine("               ║│││ │ ├┤ ├┬┘│││├─┤ │ ││ ││││├─┤│    ║  │ ││  │  ├─┤├┴┐│ │├┬┘├─┤ │ ││ ││││                        ");
            Console.WriteLine("               ╩┘└┘ ┴ └─┘┴└─┘└┘┴ ┴ ┴ ┴└─┘┘└┘┴ ┴┴─┘  ╚═╝└─┘┴─┘┴─┘┴ ┴└─┘└─┘┴└─┴ ┴ ┴ ┴└─┘┘└┘                        ");
            Console.WriteLine("                ┬┌┐┌  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                       ");
            Console.WriteLine("                ││││   │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                        ");
            Console.WriteLine("                ┴┘└┘   ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) exemplified international collaboration in genetic research,    ||    ");
            Console.WriteLine("    ||      involving numerous countries and institutions working together toward common goals:            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Global Partnership                                                                          ||    ");
            Console.WriteLine("    ||      - Launched in 1990, the HGP was an international effort involving institutions from the        ||    ");
            Console.WriteLine("    ||        United States, United Kingdom, Japan, France, and Germany, among others.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Sharing of Data and Resources                                                               ||    ");
            Console.WriteLine("    ||      - Promoted open access to genetic data, ensuring that all researchers could benefit from       ||    ");
            Console.WriteLine("    ||        shared information, fostering collaboration and innovation.                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Coordinated Efforts                                                                         ||    ");
            Console.WriteLine("    ||      - Coordinated sequencing efforts through various centers and consortia, including the          ||    ");
            Console.WriteLine("    ||        International Human Genome Sequencing Consortium (IHGSC).                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. National and International Funding                                                          ||    ");
            Console.WriteLine("    ||      - Supported by significant funding from governments, private organizations, and international  ||    ");
            Console.WriteLine("    ||        agencies, including the National Institutes of Health (NIH) and the Wellcome Trust.          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Contribution to Global Health                                                               ||    ");
            Console.WriteLine("    ||      - Facilitated international research collaborations focused on global health issues,           ||    ");
            Console.WriteLine("    ||        such as understanding genetic predispositions to diseases in diverse populations.            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void RoleOfTechnology()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                      ╦═╗┌─┐┬  ┌─┐  ┌─┐┌─┐  ╔╦╗┌─┐┌─┐┬ ┬┌┐┌┌─┐┬  ┌─┐┌─┐┬ ┬  ┬┌┐┌  ┌┬┐┬ ┬┌─┐                      ");
            Console.WriteLine("                      ╠╦╝│ ││  ├┤   │ │├┤    ║ ├┤ │  ├─┤││││ ││  │ ││ ┬└┬┘  ││││   │ ├─┤├┤                       ");
            Console.WriteLine("                      ╩╚═└─┘┴─┘└─┘  └─┘└     ╩ └─┘└─┘┴ ┴┘└┘└─┘┴─┘└─┘└─┘ ┴   ┴┘└┘   ┴ ┴ ┴└─┘                      ");
            Console.WriteLine("                               ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                         ");
            Console.WriteLine("                               ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                          ");
            Console.WriteLine("                               ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                          ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Technology played a crucial role in the Human Genome Project (HGP), enabling the successful    ||    ");
            Console.WriteLine("    ||      mapping and sequencing of the human genome through various innovative methods and tools:       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. DNA Sequencing Techniques                                                                   ||    ");
            Console.WriteLine("    ||      - Development and refinement of sequencing technologies, including Sanger sequencing and       ||    ");
            Console.WriteLine("    ||        next-generation sequencing (NGS), which significantly increased speed and accuracy.          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Bioinformatics                                                                              ||    ");
            Console.WriteLine("    ||      - Utilization of computational tools and algorithms to analyze, interpret, and store           ||    ");
            Console.WriteLine("    ||        vast amounts of genetic data generated during the project.                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Automated Laboratory Equipment                                                              ||    ");
            Console.WriteLine("    ||      - Implementation of robotics and automation in laboratories to streamline sample preparation,  ||    ");
            Console.WriteLine("    ||        sequencing, and data analysis, improving efficiency and reducing human error.                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Genetic Mapping Technologies                                                                ||    ");
            Console.WriteLine("    ||      -Use of technologies for genetic mapping, including restriction fragment length polymorphism   ||    ");
            Console.WriteLine("    ||        (RFLP) and single nucleotide polymorphism (SNP) analysis, to identify genetic variations.    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Collaborative Platforms                                                                     ||    ");
            Console.WriteLine("    ||      -Creation of databases and online platforms, such as the UCSC Genome Browser and GenBank,      ||    ");
            Console.WriteLine("    ||        facilitating data sharing and collaboration among researchers worldwide.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void PersonalizedMedicine()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                            ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                            ");
            Console.WriteLine("                            ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                             ");
            Console.WriteLine("                            ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                             ");
            Console.WriteLine("                      ┌─┐┌┐┌┌┬┐  ╔═╗┌─┐┬─┐┌─┐┌─┐┌┐┌┌─┐┬  ┬┌─┐┌─┐┌┬┐  ╔╦╗┌─┐┌┬┐┬┌─┐┬┌┐┌┌─┐                        ");
            Console.WriteLine("                      ├─┤│││ ││  ╠═╝├┤ ├┬┘└─┐│ ││││├─┤│  │┌─┘├┤  ││  ║║║├┤  ││││  ││││├┤                         ");
            Console.WriteLine("                      ┴ ┴┘└┘─┴┘  ╩  └─┘┴└─└─┘└─┘┘└┘┴ ┴┴─┘┴└─┘└─┘─┴┘  ╩ ╩└─┘─┴┘┴└─┘┴┘└┘└─┘                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) has laid the foundation for personalized medicine, transforming ||    ");
            Console.WriteLine("    ||      healthcare by enabling tailored treatment approaches based on individual genetic information:  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Genetic Profiling                                                                           ||    ");
            Console.WriteLine("    ||      - Utilization of genomic data to create comprehensive genetic profiles for individuals,        ||    ");
            Console.WriteLine("    ||        enhancing understanding of disease susceptibility and drug response.                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Tailored Therapies                                                                          ||    ");
            Console.WriteLine("    ||      - Development of targeted therapies based on specific genetic mutations, improving treatment   ||    ");
            Console.WriteLine("    ||        efficacy and reducing side effects in conditions like cancer and rare genetic disorders.     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Pharmacogenomics                                                                            ||    ");
            Console.WriteLine("    ||      - Integration of genetic information to guide medication selection and dosage, optimizing      ||    ");
            Console.WriteLine("    ||        treatment plans based on individual metabolism and genetic variations.                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Disease Prevention                                                                          ||    ");
            Console.WriteLine("    ||      - Identification of genetic predispositions allows for proactive health measures and           ||    ");
            Console.WriteLine("    ||        lifestyle modifications to prevent diseases before they manifest.                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Genetic Counseling                                                                          ||    ");
            Console.WriteLine("    ||      - Enhanced genetic counseling services to help individuals and families understand genetic     ||    ");
            Console.WriteLine("    ||        risks, testing options, and implications for health and treatment.                           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void FutureGenomicResearch()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                      ╦ ╦┌─┐┬ ┬  ╔═╗╦═╗╦╔═╗╔═╗╦═╗  ╦ ╦┌─┐┬─┐┬┌─┌─┐                               ");
            Console.WriteLine("                                      ╠═╣│ ││││  ║  ╠╦╝║╚═╗╠═╝╠╦╝  ║║║│ │├┬┘├┴┐└─┐                               ");
            Console.WriteLine("                                      ╩ ╩└─┘└┴┘  ╚═╝╩╚═╩╚═╝╩  ╩╚═  ╚╩╝└─┘┴└─┴ ┴└─┘                               ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The future of genomic research is poised for significant advancements and transformative       ||    ");
            Console.WriteLine("    ||      developments, driven by technological innovations and interdisciplinary collaboration:         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Advancements in Sequencing Technologies                                                     ||    ");
            Console.WriteLine("    ||      - Continued improvement in sequencing methods, including ultra-high-throughput sequencing and  ||    ");
            Console.WriteLine("    ||        single-cell sequencing, leading to faster and more cost-effective genome analysis.           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Integration of Artificial Intelligence                                                      ||    ");
            Console.WriteLine("    ||      - Leveraging AI and machine learning algorithms to analyze complex genomic data, enhance       ||    ");
            Console.WriteLine("    ||        predictive models, and identify novel genetic variants associated with diseases.             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Expanded Applications in Medicine                                                           ||    ");
            Console.WriteLine("    ||      - Increasing use of genomics in precision medicine, including tailored therapies,              ||    ");
            Console.WriteLine("    ||        preventive medicine, and understanding disease mechanisms.                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Genomic Editing and Therapeutics                                                            ||    ");
            Console.WriteLine("    ||      - Further development of gene editing technologies, such as CRISPR, for therapeutic            ||    ");
            Console.WriteLine("    ||        applications, including the treatment of genetic disorders and cancers.                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Population Genomics                                                                         ||    ");
            Console.WriteLine("    ||      - Expansion of population genomics studies to understand genetic diversity,                    ||    ");
            Console.WriteLine("    ||        disease susceptibility, and responses to therapies across different ethnic and demographic   ||    ");
            Console.WriteLine("    ||        groups.                                                                                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Ethical and Social Considerations                                                           ||    ");
            Console.WriteLine("    ||      - Ongoing discussions about the ethical implications of genomic research, including data       ||    ");
            Console.WriteLine("    ||        privacy, genetic discrimination, and equitable access to genomic technologies.               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Interdisciplinary Collaboration                                                             ||    ");
            Console.WriteLine("    ||      - Increased collaboration among geneticists, clinicians, bioinformaticians, and social         ||    ");
            Console.WriteLine("    ||        scientists to address complex biological questions and improve health outcomes.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void Epigenetics()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                EpigeneticsAnimation();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear(); Console.WriteLine("                                                                                           ");
                Console.WriteLine("                                                                                                              ");
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                  ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗             ");
                Console.WriteLine("                                 ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝             ");
                Console.WriteLine("                                 ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗             ");
                Console.WriteLine("                                 ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║             ");
                Console.WriteLine("                                 ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║             ");
                Console.WriteLine("                                  ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝             ");
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████ ");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ██                                            Epigenetics:                                        ██");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ██                                            ::::..........................................::::  ██");
                Console.WriteLine("        ██                                            :::................  .  .   ...................:::  ██");
                Console.WriteLine("        ██                                            :.............      .               .............:  ██");
                Console.WriteLine("        ██                                            ............        . .^^^^           ............  ██");
                Console.WriteLine("        ██                                            ..........       .  . :~~~~:.  .        ..........  ██");
                Console.WriteLine("        ██                                            ........       . . .  :~~~^.....         .........  ██");
                Console.WriteLine("        ██  [ 1 ] What is Epigenetics?                ........ ...  ....  ...^~!~....  . . .  ..........  ██");
                Console.WriteLine("        ██  [ 2 ] DNA Methylation                     ............ .  ..:^^~^~~^~^:^~:..         .......  ██");
                Console.WriteLine("        ██  [ 3 ] Histone Modification                .....::.......:^^^~~7~^~^^~^:7~^^~^^:::::.:^^::...  ██");
                Console.WriteLine("        ██  [ 4 ] Environmental Impact on Epigenetics ...:^~!~^^~~~^~^^:^:~!:^~~^^!!:::::^^^^^^:^~~^:...  ██");
                Console.WriteLine("        ██  [ 5 ] Role of Epigenetics in Disease      .....::........ . ..:~^~~!^^^^.   ......   .......  ██");
                Console.WriteLine("        ██  [ 0 ] Go Back                             ...... .      .......^^~~^~:^:.. ..      .........  ██");
                Console.WriteLine("        ██                                            .........      . ....^^^~^^^^:.   .       ........  ██");
                Console.WriteLine("        ██                                            ........          . ::^^:::^^:.           ........  ██");
                Console.WriteLine("        ██                                            ..........          :::::::::..         ..........  ██");
                Console.WriteLine("        ██                                            ...........         ..:^^::.           ...........  ██");
                Console.WriteLine("        ██                                            :............         .:^~~^.        ............:  ██");
                Console.WriteLine("        ██                                            ::...............    :::::::^^   ...............::  ██");
                Console.WriteLine("        ██                                            ::::.................~^::^::^^................::::  ██");
                Console.WriteLine("        ██                                            :::::::...............^^~^:::..............:::::::  ██");
                Console.WriteLine("        ██                                            ^::::::::..............:^~~^:............::::::::^  ██");
                Console.WriteLine("        ██                                            ^^^::::::::::........^~^^^^^~^.......::::::::::^^^  ██");
                Console.WriteLine("        ██                                            ^^^^^^::::::::::::::.~~^^^^^~^.:::::::::::::^^^^^^  ██");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████ ");
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                                                                                            ");
                Console.Write("                        Choose an option: ");
                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: WhatIsEpigenetics(); break;
                    case 2: DNAMethylation(); break;
                    case 3: HistoneModification(); break;
                    case 4: EnvironmentalImpact(); break;
                    case 5: RoleInDisease(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void EpigeneticsAnimation()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            string[] frames = new string[]
            {
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]  \n" +
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]\n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]\n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]  \n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                       |               [CH3]                    \n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]  \n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                      [CH3]       [CH3]          [CH3]            \n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]\n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]\n"+
                "        ====================================================================================================  ",
         };

            for (int i = 0; i < 2; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                       Epigenetic Modifications in Progress...");
                    Thread.Sleep(300);
                }
            }

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Epigenetic Modifications Complete!");
        }


        static void WhatIsEpigenetics()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                ╦ ╦┬ ┬┌─┐┌┬┐  ┬┌─┐  ╔═╗┌─┐┬┌─┐┌─┐┌┐┌┌─┐┌┬┐┬┌─┐┌─┐┌─┐                             ");
            Console.WriteLine("                                ║║║├─┤├─┤ │   │└─┐  ║╣ ├─┘││ ┬├┤ │││├┤  │ ││  └─┐ ┌┘                             ");
            Console.WriteLine("                                ╚╩╝┴ ┴┴ ┴ ┴   ┴└─┘  ╚═╝┴  ┴└─┘└─┘┘└┘└─┘ ┴ ┴└─┘└─┘ o                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Epigenetics is the study of heritable changes in gene expression that do not involve changes   ||    ");
            Console.WriteLine("    ||      to the underlying DNA sequence. This field explores how environmental factors can influence    ||    ");
            Console.WriteLine("    ||      gene activity, leading to variations in phenotype without altering the genetic code.           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Mechanisms of Epigenetics                                                                   ||    ");
            Console.WriteLine("    ||      - Key mechanisms include DNA methylation, histone modification, and non-coding RNA molecules.  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. DNA Methylation                                                                             ||    ");
            Console.WriteLine("    ||      - Addition of methyl groups to DNA molecules, typically at cytosine bases, which can inhibit   ||    ");
            Console.WriteLine("    ||        gene transcription and reduce gene expression.                                               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Histone Modification                                                                        ||    ");
            Console.WriteLine("    ||      - Post-translational modifications of histone proteins that can affect chromatin structure     ||    ");
            Console.WriteLine("    ||        and gene accessibility, thus influencing gene expression patterns.                           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Environmental Influences                                                                    ||    ");
            Console.WriteLine("    ||      - Factors such as diet, stress, toxins, and aging can lead to epigenetic changes, impacting    ||    ");
            Console.WriteLine("    ||        gene expression and contributing to various health conditions.                               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Epigenetics and Development                                                                 ||    ");
            Console.WriteLine("    ||      - Plays a critical role in cellular differentiation, determining how stem cells develop into   ||    ");
            Console.WriteLine("    ||        various cell types with specific functions.                                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void DNAMethylation()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                     ╔╦╗╔╗╔╔═╗  ╔╦╗┌─┐┌┬┐┬ ┬┬ ┬┬  ┌─┐┌┬┐┬┌─┐┌┐┌                                  ");
            Console.WriteLine("                                      ║║║║║╠═╣  ║║║├┤  │ ├─┤└┬┘│  ├─┤ │ ││ ││││                                  ");
            Console.WriteLine("                                     ═╩╝╝╚╝╩ ╩  ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴─┘┴ ┴ ┴ ┴└─┘┘└┘                                  ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      DNA methylation is a key epigenetic modification involving the addition of a methyl group      ||    ");
            Console.WriteLine("    ||      to the DNA molecule, typically at the cytosine base of CpG dinucleotides. This process plays   ||    ");
            Console.WriteLine("    ||      a crucial role in regulating gene expression, maintaining genomic stability, and influencing   ||    ");
            Console.WriteLine("    ||      various biological processes:                                                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Mechanism of DNA Methylation                                                                ||    ");
            Console.WriteLine("    ||      - DNA methylation occurs through the action of DNA methyltransferases, which catalyze the      ||    ");
            Console.WriteLine("    ||        transfer of a methyl group from S-adenosylmethionine (SAM) to the cytosine residue.          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Regulation of Gene Expression                                                               ||    ");
            Console.WriteLine("    ||      - Methylation of gene promoter regions typically leads to transcriptional silencing,           ||    ");
            Console.WriteLine("    ||        preventing gene expression. Conversely, demethylation can activate gene transcription.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Role in Development                                                                         ||    ");
            Console.WriteLine("    ||      - DNA methylation patterns change throughout development, playing a vital role in cellular     ||    ");
            Console.WriteLine("    ||        differentiation and tissue-specific gene expression.                                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Influence of Environmental Factors                                                          ||    ");
            Console.WriteLine("    ||      - Environmental factors such as diet, toxins, and stress can lead to changes in DNA            ||    ");
            Console.WriteLine("    ||        methylation patterns, potentially influencing health and disease susceptibility.             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Implications for Disease                                                                    ||    ");
            Console.WriteLine("    ||      - Aberrant DNA methylation is associated with various diseases, including cancer,              ||    ");
            Console.WriteLine("    ||        neurological disorders, and metabolic diseases, often serving as biomarkers for diagnosis.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void HistoneModification()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                              ╦ ╦┬┌─┐┌┬┐┌─┐┌┐┌┌─┐  ╔╦╗┌─┐┌┬┐┬┌─┐┬┌─┐┌─┐┌┬┐┬┌─┐┌┐┌                                ");
            Console.WriteLine("                              ╠═╣│└─┐ │ │ ││││├┤   ║║║│ │ │││├┤ ││  ├─┤ │ ││ ││││                                ");
            Console.WriteLine("                              ╩ ╩┴└─┘ ┴ └─┘┘└┘└─┘  ╩ ╩└─┘─┴┘┴└  ┴└─┘┴ ┴ ┴ ┴└─┘┘└┘                                ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Histone modification refers to a set of biochemical modifications to the histone proteins that ||    ");
            Console.WriteLine("    ||      package and order DNA into structural units called nucleosomes. These modifications play a     ||    ");
            Console.WriteLine("    ||      critical role in regulating gene expression and chromatin structure:                           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Types of Histone Modifications                                                              ||    ");
            Console.WriteLine("    ||      - Common types include acetylation, methylation, phosphorylation, ubiquitination, and          ||    ");
            Console.WriteLine("    ||        sumoylation, each affecting gene expression in different ways.                               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Acetylation                                                                                 ||    ");
            Console.WriteLine("    ||      - Addition of an acetyl group to lysine residues on histones, leading to a relaxed chromatin   ||    ");
            Console.WriteLine("    ||        structure and enhanced gene transcription.                                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Methylation                                                                                 ||    ");
            Console.WriteLine("    ||      - Addition of methyl groups to lysine or arginine residues, which can either activate or       ||    ");
            Console.WriteLine("    ||        repress transcription depending on the specific context and the number of methyl groups .    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Phosphorylation                                                                             ||    ");
            Console.WriteLine("    ||      - Addition of phosphate groups to specific amino acids, often associated with chromatin        ||    ");
            Console.WriteLine("    ||        remodeling during cell division and response to DNA damage.                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Functional Implications                                                                     ||    ");
            Console.WriteLine("    ||      - Histone modifications impact the accessibility of DNA for transcription factors and other    ||    ");
            Console.WriteLine("    ||        regulatory proteins, thereby influencing gene expression and cellular function.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void EnvironmentalImpact()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("        ╔═╗┌┐┌┬  ┬┬┬─┐┌─┐┌┐┌┌┬┐┌─┐┌┐┌┌┬┐┌─┐┬    ╦┌┬┐┌─┐┌─┐┌─┐┌┬┐  ┌─┐┌┐┌  ╔═╗┌─┐┬┌─┐┌─┐┌┐┌┌─┐┌┬┐┬┌─┐┌─┐          ");
            Console.WriteLine("        ║╣ │││└┐┌┘│├┬┘│ │││││││├┤ │││ │ ├─┤│    ║│││├─┘├─┤│   │   │ ││││  ║╣ ├─┘││ ┬├┤ │││├┤  │ ││  └─┐          ");
            Console.WriteLine("        ╚═╝┘└┘ └┘ ┴┴└─└─┘┘└┘┴ ┴└─┘┘└┘ ┴ ┴ ┴┴─┘  ╩┴ ┴┴  ┴ ┴└─┘ ┴   └─┘┘└┘  ╚═╝┴  ┴└─┘└─┘┘└┘└─┘ ┴ ┴└─┘└─┘          ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Environmental factors can significantly influence epigenetic modifications, which in turn      ||    ");
            Console.WriteLine("    ||      affect gene expression and contribute to various biological processes and diseases.            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Types of Environmental Factors                                                              ||    ");
            Console.WriteLine("    ||      - Factors include diet, toxins, stress, pollution, physical activity, and social interactions. ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Diet and Nutrition                                                                          ||");
            Console.WriteLine("    ||      -Nutrient intake, such as folate, vitamins B12, and others, can influence DNA methylation      || ");
            Console.WriteLine("    ||        patterns and histone modifications, affecting gene expression and health outcomes.           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Exposure to Toxins                                                                          ||");
            Console.WriteLine("    ||      -Chemicals such as heavy metals, pesticides, and endocrine disruptors can alter epigenetic     || ");
            Console.WriteLine("    ||        marks, leading to changes in gene expression linked to various diseases.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Stress and Lifestyle                                                                        ||");
            Console.WriteLine("    ||      -Chronic stress can induce epigenetic changes that affect stress - response genes and          || ");
            Console.WriteLine("    ||        influence mental health and behavior.                                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Physical Activity                                                                           ||");
            Console.WriteLine("    ||      -Regular exercise can lead to beneficial epigenetic changes that enhance metabolic health      || ");
            Console.WriteLine("    ||        and reduce the risk of chronic diseases.                                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Epigenetic Inheritance                                                                      ||");
            Console.WriteLine("    ||      -Some epigenetic changes induced by environmental factors can be passed down to future         || ");
            Console.WriteLine("    ||        generations, impacting their health and development.                                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Implications for Disease                                                                    ||");
            Console.WriteLine("    ||      -Understanding how environmental factors influence epigenetics can help identify               || ");
            Console.WriteLine("    ||        mechanisms behind complex diseases, such as cancer, cardiovascular diseases, and             ||    ");
            Console.WriteLine("    ||        autoimmune disorders.                                                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      8. Research and Therapeutic Applications                                                       ||");
            Console.WriteLine("    ||      -Ongoing research aims to uncover how environmental influences interact with epigenetics       || ");
            Console.WriteLine("    ||        to develop strategies for disease prevention and personalized medicine.                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void RoleInDisease()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                   ╦═╗┌─┐┬  ┌─┐  ┌─┐┌─┐  ╔═╗┌─┐┬┌─┐┌─┐┌┐┌┌─┐┌┬┐┬┌─┐┌─┐  ┬┌┐┌  ╔╦╗┬┌─┐┌─┐┌─┐┌─┐┌─┐                ");
            Console.WriteLine("                   ╠╦╝│ ││  ├┤   │ │├┤   ║╣ ├─┘││ ┬├┤ │││├┤  │ ││  └─┐  ││││   ║║│└─┐├┤ ├─┤└─┐├┤                 ");
            Console.WriteLine("                   ╩╚═└─┘┴─┘└─┘  └─┘└    ╚═╝┴  ┴└─┘└─┘┘└┘└─┘ ┴ ┴└─┘└─┘  ┴┘└┘  ═╩╝┴└─┘└─┘┴ ┴└─┘└─┘                ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Epigenetics plays a crucial role in the development and progression of various diseases by     ||    ");
            Console.WriteLine("    ||      influencing gene expression without altering the underlying DNA sequence. This has important   ||    ");
            Console.WriteLine("    ||      implications for understanding disease mechanisms and developing therapeutic strategies.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Cancer                                                                                      ||    ");
            Console.WriteLine("    ||      - Abnormal epigenetic modifications, such as DNA methylation and histone modification,         ||    ");
            Console.WriteLine("    ||        contribute to oncogenesis by silencing tumor suppressor genes or activating oncogenes.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Cardiovascular Diseases                                                                     ||    ");
            Console.WriteLine("    ||      - Epigenetic changes in response to environmental factors can affect genes involved in         ||    ");
            Console.WriteLine("    ||        inflammation, lipid metabolism, and blood pressure regulation, increasing disease risk.      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Neurological Disorders                                                                      ||    ");
            Console.WriteLine("    ||      - Epigenetic mechanisms are implicated in various neurological conditions, including           ||    ");
            Console.WriteLine("    ||        Alzheimer's disease and depression, influencing synaptic plasticity and neuronal function.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Autoimmune Diseases                                                                         ||    ");
            Console.WriteLine("    ||      - Dysregulation of epigenetic marks can lead to inappropriate gene expression, contributing    ||    ");
            Console.WriteLine("    ||        to the development of autoimmune disorders such as lupus and rheumatoid arthritis.           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Metabolic Disorders                                                                         ||    ");
            Console.WriteLine("    ||      - Epigenetic changes can affect metabolic pathways, contributing to obesity, diabetes,         ||    ");
            Console.WriteLine("    ||        and related conditions through altered gene expression.                                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void EvolutionAndGenetics()
        {
            int subOption = 0;

            do
            {

                Console.Clear();
                EvolutionAndGeneticsAnimation();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.WriteLine("                                                                                                                      ");
                Console.WriteLine("                                                                                                                      ");
                Console.WriteLine("                                  ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                      ");
                Console.WriteLine("                                 ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                      ");
                Console.WriteLine("                                 ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                      ");
                Console.WriteLine("                                 ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                      ");
                Console.WriteLine("                                 ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                      ");
                Console.WriteLine("                                  ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                      ");
                Console.WriteLine("                                                                                                                      ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████          ");
                Console.WriteLine("        ██                                                                                                ██          ");
                Console.WriteLine("        ██                            Evolution and Genetics:                                             ██          ");
                Console.WriteLine("        ██                                                                                                ██          ");
                Console.WriteLine("        ██                                                                                                ██          ");
                Console.WriteLine("        ██                                                                                                ██          ");
                Console.WriteLine("        ██                                                                                                ██          ");
                Console.WriteLine("        ██                                                                  .!7:                          ██          ");
                Console.WriteLine("        ██                                                                  ~&&5                          ██          ");
                Console.WriteLine("        ██   [ 1 ] What is Evolution?                                     .5#B~             .^!!!7JP5^    ██          ");
                Console.WriteLine("        ██   [ 2 ] Natural Selection                            ..        ~&#&J           :?G##&&#BBP^    ██          ");
                Console.WriteLine("        ██   [ 3 ] Genetic Drift                              ^5BB!       .G##P.         ?B&####&P..      ██          ");
                Console.WriteLine("        ██   [ 4 ] Gene Flow                                 ~#&#5^       !###BJ:       !#####B##~        ██          ");
                Console.WriteLine("        ██   [ 5 ] Evolutionary Developmental Biology        J&#&7        J&#&B7:       Y&###BJB!         ██          ");
                Console.WriteLine("        ██   [ 0 ] Go Back                        .!PB5.    ~B##JJJ?.    .B#7?#B:       P&B5B#BP          ██          ");
                Console.WriteLine("        ██                                        !B&&P!.    ?###Y: ?!    Y#?  ~&J      !##! ?#&?::       ██          ");
                Console.WriteLine("        ██                                       Y####P.      ~#B5B:     !#!    5G.   .J#B7  Y&P..        ██          ");
                Console.WriteLine("        ██                              ..:^7J! .YB&BY#G.     YY. YY::~~!G5      P5!!^YBB~   P&Y          ██          ");
                Console.WriteLine("        ██                            ~YBBB#&#!  ^G7JPY5Y. .75BG5?~^5B5YPBG! .:.::!5B5PBG7 .^5BB?         ██          ");
                Console.WriteLine("        ██                           :7?GP7P~J~:~5G!.77~^^.^J?^~J5B5~^7^?!5#J!J!J~7~J:!~5#7^P5J5B5^       ██          ");
                Console.WriteLine("        ██                           .!~?5Y5~.?BPJYPGY7J~?~?^.::7:?P#Y?^!?.7GB?~J!?!J^!^!Y&?:J~7~P#!:7^!  ██          ");
                Console.WriteLine("        ██                        ^: ..?GPJJPBP7:.^~^YBG77!~?:::7!5:~5B57?^^:?BGJ!!~?~~~! J&5!^J^~P#?:!?  ██          ");
                Console.WriteLine("        ██                        ?~.:.!^J7~J~5B5~.~~7YJPGY??~~!?::   ^?PPP5PP?!5PPPPY.    !GB??~J^Y#J7:  ██          ");
                Console.WriteLine("        ██                        G~.:.7^Y?7Y^7~5B577~?!^YGY5PPPJ.       .^~^:   .:::.      .!5GP57^JBGJ  ██          ");
                Console.WriteLine("        ██                        5BP!:!^J7~?::  :7Y5PPPPY7                                    :!?Y55^~J  ██          ");
                Console.WriteLine("        ██                        ::?PGPPG!           .                                                   ██          ");
                Console.WriteLine("        ██                            .::.                                                                ██          ");
                Console.WriteLine("        ██                                                                                                ██          ");
                Console.WriteLine("        ██                                                                                                ██          ");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████          ");
                Console.WriteLine("                                                                                                                      ");
                Console.WriteLine("                                                                                                                      ");
                Console.Write("                        Choose an option: ");
                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: WhatIsEvolution(); break;
                    case 2: NaturalSelection(); break;
                    case 3: GeneticDrift(); break;
                    case 4: GeneFlow(); break;
                    case 5: EvolutionaryDevelopmentalBiology(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void EvolutionAndGeneticsAnimation()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            string[] frames = new string[]
            {
        "        ====================================================================================================  \n"+
        "                                              ========================  \n" +
        "                                              || A - T - G - C - A ||  \n" +
        "                                              || C - G - T - A - C ||  \n" +
        "                                              ========================  \n" +
        "                                                   Initial Sequence     \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                              ========================  \n" +
        "                                              || A - T - G - C - A ||  \n" +
        "                                              || C - G - T - A - C ||  \n" +
        "                                              ========================  \n" +
        "                                                      Stable            \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                             ========================  \n" +
        "                                             || A - T - G - C - T ||  \n" + // Mutation at 5th position
        "                                             || C - G - T - A - C ||  \n" +
        "                                             ========================  \n" +
        "                                                   Mutation A -> T     \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                              ========================  \n" +
        "                                              || A - T - G - C - T ||  \n" + // Retaining mutation
        "                                              || C - G - T - G - C ||  \n" + // Mutation at 4th position
        "                                              ========================  \n" +
        "                                                  Adaptation G -> T     \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                              ========================  \n" +
        "                                              || A - A - G - C - T ||  \n" + // Mutation at 2nd position
        "                                              || C - G - T - G - C ||  \n" + // Retaining previous mutations
        "                                              ========================  \n" +
        "                                                  Evolution A -> A      \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                              ========================  \n" +
        "                                              || A - A - G - C - T ||  \n" + // Final state with mutations
        "                                              || C - A - T - G - C ||  \n" + // Change at 2nd position
        "                                              ========================  \n" +
        "                                                   Final Sequence       \n"+
        "        ====================================================================================================  ",
            };

            for (int i = 0; i < 2; i++) // Loop to repeat the animation
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                          Evolution and Genetics in Action...");
                    Thread.Sleep(700); // Pause for 700 milliseconds for clarity
                }
            }

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Evolution and Genetics Process Complete!");
        }


        static void WhatIsEvolution()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                 ┬ ┬┬ ┬┌─┐┌┬┐  ┬┌─┐  ┌─┐┬  ┬┌─┐┬  ┬ ┬┌┬┐┬┌─┐┌┐┌┌─┐                               ");
            Console.WriteLine("                                 │││├─┤├─┤ │   │└─┐  ├┤ └┐┌┘│ ││  │ │ │ ││ ││││ ┌┘                               ");
            Console.WriteLine("                                 └┴┘┴ ┴┴ ┴ ┴   ┴└─┘  └─┘ └┘ └─┘┴─┘└─┘ ┴ ┴└─┘┘└┘ o                                ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Evolution is the process by which different kinds of living organisms develop and diversify    ||    ");
            Console.WriteLine("    ||      from earlier forms over successive generations. It is driven by mechanisms such as natural     ||    ");
            Console.WriteLine("    ||      selection, mutation, gene flow, and genetic drift.                                             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Natural Selection                                                                           ||    ");
            Console.WriteLine("    ||      - The mechanism proposed by Charles Darwin, where organisms with favorable traits are more     ||    ");
            Console.WriteLine("    ||        likely to survive and reproduce, leading to the adaptation of species over time.             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Mutation                                                                                    ||    ");
            Console.WriteLine("    ||      - Random changes in DNA sequences that can introduce new traits or variations in a population, ||    ");
            Console.WriteLine("    ||        which can be beneficial, neutral, or harmful.                                                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Gene Flow                                                                                   ||    ");
            Console.WriteLine("    ||      - The transfer of genetic material between populations through migration or interbreeding,     ||    ");
            Console.WriteLine("    ||        which can increase genetic diversity and alter allele frequencies.                           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Genetic Drift                                                                               ||    ");
            Console.WriteLine("    ||      - A random process that can cause allele frequencies to change in a population, especially in  ||    ");
            Console.WriteLine("    ||        small populations, leading to the loss of genetic diversity.                                 ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Speciation                                                                                  ||    ");
            Console.WriteLine("    ||      - The process by which new species arise, often through mechanisms such as geographical        ||    ");
            Console.WriteLine("    ||        isolation, reproductive isolation, or adaptive radiation.                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void NaturalSelection()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                ╔╗╔┌─┐┌┬┐┬ ┬┬─┐┌─┐┬    ╔═╗┌─┐┬  ┌─┐┌─┐┌┬┐┬┌─┐┌┐┌                                 ");
            Console.WriteLine("                                ║║║├─┤ │ │ │├┬┘├─┤│    ╚═╗├┤ │  ├┤ │   │ ││ ││││                                 ");
            Console.WriteLine("                                ╝╚╝┴ ┴ ┴ └─┘┴└─┴ ┴┴─┘  ╚═╝└─┘┴─┘└─┘└─┘ ┴ ┴└─┘┘└┘                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Natural selection is a fundamental mechanism of evolution proposed by Charles Darwin. It       ||    ");
            Console.WriteLine("    ||      explains how species adapt to their environments over time through differential survival and   ||    ");
            Console.WriteLine("    ||      reproduction of individuals with favorable traits.                                             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Variation                                                                                   ||    ");
            Console.WriteLine("    ||      - Within any population, individuals exhibit variations in traits, such as size, color, or     ||    ");
            Console.WriteLine("    ||        behavior. These variations can be genetic and are often influenced by environmental factors. ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Competition                                                                                 ||    ");
            Console.WriteLine("    ||      - Organisms compete for limited resources, such as food, mates, and habitat. This competition  ||    ");
            Console.WriteLine("    ||        creates a struggle for survival, influencing which individuals are more likely to survive    ||    ");
            Console.WriteLine("    ||        and reproduce.                                                                               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Survival of the Fittest                                                                     ||    ");
            Console.WriteLine("    ||      - Individuals with traits better suited to their environment are more likely to survive and    ||    ");
            Console.WriteLine("    ||        reproduce, passing on their advantageous traits to the next generation.                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Adaptation                                                                                  ||    ");
            Console.WriteLine("    ||      - Over time, natural selection leads to adaptations, where populations develop traits that     ||    ");
            Console.WriteLine("    ||        enhance their survival and reproduction in specific environments.                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Speciation                                                                                  ||    ");
            Console.WriteLine("    ||      - Prolonged natural selection can result in speciation, the emergence of new species,          ||    ");
            Console.WriteLine("    ||        when populations of the same species become reproductively isolated due to differing         ||    ");
            Console.WriteLine("    ||        environmental pressures.                                                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Evidence of Natural Selection                                                               ||    ");
            Console.WriteLine("    ||      - Evidence supporting natural selection includes observations in the fossil record, studies of ||    ");
            Console.WriteLine("    ||        antibiotic resistance in bacteria, and experimental evidence from laboratory studies.        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Human Influence                                                                             ||    ");
            Console.WriteLine("    ||      - Human activities, such as habitat destruction and climate change, can influence natural      ||    ");
            Console.WriteLine("    ||        selection, altering the pressures faced by species and potentially leading to rapid          ||    ");
            Console.WriteLine("    ||        evolutionary changes.                                                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      8. Implications for Conservation                                                               ||    ");
            Console.WriteLine("    ||      - Understanding natural selection is crucial for conservation efforts, as it helps predict     ||    ");
            Console.WriteLine("    ||        how species might respond to environmental changes and informs strategies for preserving     ||    ");
            Console.WriteLine("    ||        biodiversity.                                                                                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GeneticDrift()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                          ╔═╗┌─┐┌┐┌┌─┐┌┬┐┬┌─┐  ╔╦╗┬─┐┬┌─┐┌┬┐                                     ");
            Console.WriteLine("                                          ║ ╦├┤ │││├┤  │ ││     ║║├┬┘│├┤  │                                      ");
            Console.WriteLine("                                          ╚═╝└─┘┘└┘└─┘ ┴ ┴└─┘  ═╩╝┴└─┴└   ┴                                      ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Genetic drift is a mechanism of evolution that involves random changes in allele frequencies   ||    ");
            Console.WriteLine("    ||      within a population over time, particularly in small populations. These changes can lead to    ||    ");
            Console.WriteLine("    ||      the loss of genetic diversity and can influence evolutionary trajectories.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Random Sampling                                                                             ||    ");
            Console.WriteLine("    ||      - Genetic drift occurs due to the random sampling of alleles from one generation to the next,  ||    ");
            Console.WriteLine("    ||        leading to fluctuations in allele frequencies that are not driven by natural selection.      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Founder Effect                                                                              ||    ");
            Console.WriteLine("    ||      - When a small group of individuals establishes a new population, the allele frequencies in    ||    ");
            Console.WriteLine("    ||        that group may differ significantly from the original population, leading to a reduced       ||    ");
            Console.WriteLine("    ||        genetic diversity in the new population.                                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Bottleneck Effect                                                                           ||    ");
            Console.WriteLine("    ||      - A sudden reduction in population size, such as due to environmental events or human          ||    ");
            Console.WriteLine("    ||        activities, can drastically reduce genetic diversity and alter allele frequencies in the     ||    ");
            Console.WriteLine("    ||        surviving population.                                                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Implications for Evolution                                                                  ||    ");
            Console.WriteLine("    ||      - Genetic drift can lead to the fixation or loss of alleles over time, influencing the         ||    ");
            Console.WriteLine("    ||        evolution of traits within populations. It can also affect speciation processes.             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Interaction with Natural Selection                                                          ||    ");
            Console.WriteLine("    ||      - Genetic drift can interact with natural selection, where random changes may favor certain    ||    ");
            Console.WriteLine("    ||        alleles in specific environments, complicating the understanding of evolutionary dynamics.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GeneFlow()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                            ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┬  ┌─┐┬ ┬                                           ");
            Console.WriteLine("                                            ║ ╦├┤ │││├┤   ╠╣ │  │ ││││                                           ");
            Console.WriteLine("                                            ╚═╝└─┘┘└┘└─┘  ╚  ┴─┘└─┘└┴┘                                           ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Gene flow, also known as gene migration, is the transfer of genetic material between           ||    ");
            Console.WriteLine("    ||      populations through processes such as migration, interbreeding, or the movement of gametes.    ||    ");
            Console.WriteLine("    ||      It plays a crucial role in maintaining genetic diversity and influencing evolutionary dynamics.||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Mechanisms of Gene Flow                                                                     ||    ");
            Console.WriteLine("    ||      - Gene flow can occur through various mechanisms, including the movement of individuals,       ||    ");
            Console.WriteLine("    ||        pollen transfer in plants, and dispersal of seeds.                                           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Importance for Genetic Diversity                                                            ||    ");
            Console.WriteLine("    ||      - Gene flow increases genetic diversity within populations by introducing new alleles, which   ||    ");
            Console.WriteLine("    ||        can enhance adaptability and resilience to environmental changes.                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Impact on Local Populations                                                                 ||    ");
            Console.WriteLine("    ||      - While gene flow can benefit populations by increasing diversity, it can also threaten local  ||    ");
            Console.WriteLine("    ||        adaptations by diluting unique alleles, leading to a loss of local traits.                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Gene Flow and Speciation                                                                    ||    ");
            Console.WriteLine("    ||      - Gene flow can inhibit speciation by allowing gene exchange between populations, which may    ||    ");
            Console.WriteLine("    ||        reduce the chances of reproductive isolation.                                                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Human Influence on Gene Flow                                                                ||    ");
            Console.WriteLine("    ||      - Human activities, such as habitat fragmentation and urbanization, can disrupt natural gene   ||    ");
            Console.WriteLine("    ||        flow, leading to isolated populations and decreased genetic diversity.                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void EvolutionaryDevelopmentalBiology()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("      ╔═╗┬  ┬┌─┐┬  ┬ ┬┌┬┐┬┌─┐┌┐┌┌─┐┬─┐┬ ┬  ╔╦╗┌─┐┬  ┬┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐┌┐┌┌┬┐┌─┐┬    ╔╗ ┬┌─┐┬  ┌─┐┌─┐┬ ┬         ");
            Console.WriteLine("      ║╣ └┐┌┘│ ││  │ │ │ ││ ││││├─┤├┬┘└┬┘   ║║├┤ └┐┌┘├┤ │  │ │├─┘│││├┤ │││ │ ├─┤│    ╠╩╗││ ││  │ ││ ┬└┬┘         ");
            Console.WriteLine("      ╚═╝ └┘ └─┘┴─┘└─┘ ┴ ┴└─┘┘└┘┴ ┴┴└─ ┴   ═╩╝└─┘ └┘ └─┘┴─┘└─┘┴  ┴ ┴└─┘┘└┘ ┴ ┴ ┴┴─┘  ╚═╝┴└─┘┴─┘└─┘└─┘ ┴          ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Evolutionary developmental biology (evo-devo) is a field of biology that studies the           ||    ");
            Console.WriteLine("    ||      relationship between development and evolutionary processes. It integrates concepts from       ||    ");
            Console.WriteLine("    ||      evolutionary biology, genetics, and developmental biology to understand how developmental      ||    ");
            Console.WriteLine("    ||      processes influence evolutionary change.                                                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Core Concepts                                                                               ||    ");
            Console.WriteLine("    ||      - Evo-devo examines how changes in developmental pathways can lead to morphological and        ||    ");
            Console.WriteLine("    ||        functional diversity among organisms over evolutionary time.                                 ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Developmental Pathways                                                                      ||    ");
            Console.WriteLine("    ||      - Key developmental processes, such as cell differentiation, growth, and pattern formation,    ||    ");
            Console.WriteLine("    ||        play critical roles in shaping organismal form and function.                                 ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Evolutionary Change                                                                         ||    ");
            Console.WriteLine("    ||      - Small genetic changes during development can result in significant evolutionary adaptations, ||    ");
            Console.WriteLine("    ||        leading to novel traits or even new species over time.                                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Homology and Evolution                                                                      ||    ");
            Console.WriteLine("    ||      - Evo-devo studies homologies in developmental mechanisms across different species, helping    ||    ");
            Console.WriteLine("    ||        to trace evolutionary relationships and understand the origins of complex traits.            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void MainModule()
        {
            int mainChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ██                    ███╗   ███╗ ██████╗ ██████╗ ██╗   ██╗██╗     ███████╗                       ██");
                Console.WriteLine("        ██                    ████╗ ████║██╔═══██╗██╔══██╗██║   ██║██║     ██╔════╝                       ██");
                Console.WriteLine("        ██                    ██╔████╔██║██║   ██║██║  ██║██║   ██║██║     █████╗                         ██");
                Console.WriteLine("        ██                    ██║╚██╔╝██║██║   ██║██║  ██║██║   ██║██║     ██╔══╝                         ██");
                Console.WriteLine("        ██                    ██║ ╚═╝ ██║╚██████╔╝██████╔╝╚██████╔╝███████╗███████╗                       ██");
                Console.WriteLine("        ██                    ╚═╝     ╚═╝ ╚═════╝ ╚═════╝  ╚═════╝ ╚══════╝╚══════╝                       ██");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ██                                    [1] Module 1                                                ██");
                Console.WriteLine("        ██                                    [2] Module 2                                                ██");
                Console.WriteLine("        ██                                    [3] Module 3                                                ██");
                Console.WriteLine("        ██                                    [4] Activity                                                ██");
                Console.WriteLine("        ██                                    [0] Exit                                                    ██");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine("  ");
                Console.Write("                          Enter your choice: ");
                mainChoice = int.Parse(Console.ReadLine());

                switch (mainChoice)
                {
                    case 1:
                        DisplayModule1();
                        break;
                    case 2:
                        DisplayModule2();
                        break;
                    case 3:
                        DisplayModule3();
                        break;
                    case 4:
                        Activity();
                        break;
                    case 0:
                        DisplayModule3();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (mainChoice != 0);
        }

        static void DisplayModule1()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ██                      ███    ███  ██████  ██████  ██    ██ ██      ███████      ██              ██");
                Console.WriteLine("        ██                      ████  ████ ██    ██ ██   ██ ██    ██ ██      ██          ███              ██");
                Console.WriteLine("        ██                      ██ ████ ██ ██    ██ ██   ██ ██    ██ ██      █████        ██              ██");
                Console.WriteLine("        ██                      ██  ██  ██ ██    ██ ██   ██ ██    ██ ██      ██           ██              ██");
                Console.WriteLine("        ██                      ██      ██  ██████  ██████   ██████  ███████ ███████      ██              ██");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ██                            [1]  MACHINE PROBLEM 1.1 : Volume of a Sphere                       ██");
                Console.WriteLine("        ██                            [2]  MACHINE PROBLEM 1.2 : Temperature Conversion                   ██");
                Console.WriteLine("        ██                            [3]  MACHINE PROBLEM 1.3 : Peso-Dollar Conversion                   ██");
                Console.WriteLine("        ██                            [4]  MACHINE PROBLEM 1.4 : Measurement Conversion                   ██");
                Console.WriteLine("        ██                            [5]  MACHINE PROBLEM 1.5 : Two Variables                            ██");
                Console.WriteLine("        ██                            [6]  MACHINE PROBLEM 1.6 : Circumferences of Cirlce                 ██");
                Console.WriteLine("        ██                            [7]  MACHINE PROBLEM 1.7 : Three variables declaration              ██");
                Console.WriteLine("        ██                            [8]  MACHINE PROBLEM 1.8 : Purchase Price                           ██");
                Console.WriteLine("        ██                            [9]  MACHINE PROBLEM 1.9 : Economic order quantity                  ██");
                Console.WriteLine("        ██                            [10] MACHINE PROBLEM 1.10: radius of a Circle                       ██");
                Console.WriteLine("        ██                                                [0] Back                                        ██");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine("");
                Console.Write("                          Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Module1_1(); break;
                    case 2: Module1_2(); break;
                    case 3: Module1_3(); break;
                    case 4: Module1_4(); break;
                    case 5: Module1_5(); break;
                    case 6: Module1_6(); break;
                    case 7: Module1_7(); break;
                    case 8: Module1_8(); break;
                    case 9: Module1_9(); break;
                    case 10: Module1_10(); break;
                    default:
                        Console.WriteLine("Returning to main menu...");
                        break;
                }
            } while (choice != 0);
        }
        static void Module1_1()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██   Machine Problem 1.1: Create a program to compute the volume of a sphere. Use the formula:    ██");
            Console.WriteLine("        ██                                     V = (4 / 3) *r                                            ██");
            Console.WriteLine("        ██       3 where  is equal to 3.1416 approximately.The variable r is the radius. Display         ██");
            Console.WriteLine("        ██                                  the volume of a sphere.                                       ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");
            double r, v, pie = 3.1416;
            Console.Write("                                              Enter the radius:");
            r = Convert.ToDouble(Console.ReadLine());

            v = (4 / 3) * pie * r * r * r;

            Console.WriteLine("                                           The value of radius: " + v);
            Console.WriteLine("");
            Console.Write("[0] back / [1] continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module1_1();
                    break;
                case 0:
                    DisplayModule1();
                    break;
            }


        }
        static void Module1_2()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██                       Machine Problem 1.2: Write a program that converts                       ██");
            Console.WriteLine("        ██                           the input Celsius degree into its equivalent                         ██");
            Console.WriteLine("        ██                       Fahrenheit degree. Use the formula: F = (9 / 5) * C + 32.                ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");
            double F, C, num1 = 9, num2 = 5, num3 = 32;

            Console.Write("                                             Enter The Celcius degree: ");
            C = Convert.ToDouble(Console.ReadLine());
            F = (num1 / num2) * C + num3;
            Console.WriteLine("                                 The equivalent of Celsius degree to Farenheit is: " + F);

            Console.Write("[0] back / [1] continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module1_2();
                    break;
                case 0:
                    DisplayModule1();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }

        }
        static void Module1_3()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██                       Machine Problem 1.3: Write a program that converts the                   ██");
            Console.WriteLine("        ██              input dollar to its peso exchange rate equivalent.Assume that the present         ██");
            Console.WriteLine("        ██              exchange rate is 53.95 pesos against the dollar. Then display the peso            ██");
            Console.WriteLine("        ██                                       equivalent exchange rate.                                ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");
            double input, D = 53.95, total;
            Console.Write("                                                  Enter the dollar: ");
            input = Convert.ToDouble(Console.ReadLine());

            total = input * D;

            Console.WriteLine("                                     The equivalent in the dollar to peso is " + total);

            Console.Write("[0] back / [1] continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module1_3();
                    break;
                case 0:
                    DisplayModule1();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module1_4()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██              Machine Problem 1.4: Write a program that converts an input inch(es) into         ██");
            Console.WriteLine("        ██              its equivalent centimeters.Take note that one inch is equivalent to 2.54 cms.     ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");
            double inch, total, cms = 2.54;

            Console.Write("                                                     Enter The inch: ");
            inch = Convert.ToDouble(Console.ReadLine());
            total = inch * cms;
            Console.WriteLine("                                         The equivalent of inch to cm is " + total);
            Console.Write("[0] back / [1] continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module1_4();
                    break;
                case 0:
                    DisplayModule1();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module1_5()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██        Machine Problem 1.5: Write a program that exchanges the value of two variables :        ██");
            Console.WriteLine("        ██         x and y. The output must be: The value of variable y will become the value of          ██");
            Console.WriteLine("        ██                                     variable x, and vise versa.                                ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");
            int y = 6;
            int x = 5;
            int s = x;
            x = y;
            y = s;
            Console.WriteLine("x=" + x + "\ny=" + y);

            Console.Write("[0] back / [1] continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module1_5();
                    break;
                case 0:
                    DisplayModule1();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module1_6()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██         Machine Problem 1.6: Design a program to find the circumference of a circle.           ██");
            Console.WriteLine("        ██                                       Use the formula:                                         ██");
            Console.WriteLine("        ██                    C = 2r, where  is approximately equivalent to 3.1416.                     ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");
            double total, c = 2, a = 3.1416, r;

            Console.Write("                                                 Enter The circ: ");
            r = Convert.ToDouble(Console.ReadLine());

            total = a * c * r;

            Console.WriteLine("                                                Total: " + total);

            Console.Write("[0] back / [1] continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module1_6();
                    break;
                case 0:
                    DisplayModule1();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module1_7()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 1.7: You can solve the worded - problem number 5 with the use of three      ██");
            Console.WriteLine("        ██         variables declaration.Now try to solve it with only two variables declaration.         ██");
            Console.WriteLine("        ██            Formulate with an equation that exchanges the value of variable x and y.            ██");
            Console.WriteLine("        ██            The hint is: use 3 equations that involve with plus and minus operations            ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            double x, y;

            Console.Write("                                                      Enter The X Value: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("                                                       Enter The Y Value: ");
            y = Convert.ToDouble(Console.ReadLine());


            x = x + y;

            y = x - y;

            x = x - y;
            Console.WriteLine("                                                  x = " + x + ", y = " + y);

            Console.Write("[0] back / [1] continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module1_7();
                    break;
                case 0:
                    DisplayModule1();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }

        }
        static void Module1_8()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 1.8: Calculate the yearly depreciation of an item based on purchase price,  ██");
            Console.WriteLine("        ██                               years of service, and salvage value.                             ██");
            Console.WriteLine("        ██                                 Use the formula: D = (P - S) / Y                               ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            double P, Y, S, D;

            Console.Write("                                                      Enter the purchase price of the item: ");
            P = Convert.ToDouble(Console.ReadLine());

            Console.Write("                                              Enter the expected number of years of service: ");
            Y = Convert.ToDouble(Console.ReadLine());

            Console.Write("                                                 Enter the expected salvage value of the item: ");
            S = Convert.ToDouble(Console.ReadLine());

            D = (P - S) / Y;

            Console.WriteLine("                                                  The yearly depreciation is: " + D);

            Console.WriteLine();
            Console.Write("[0] back / [1] continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module1_8();
                    break;
                case 0:
                    DisplayModule1();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }

        static void Module1_9()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 1.9: Determine the Economic Order Quantity (EOQ) for each product.          ██");
            Console.WriteLine("        ██                            Formula: EOQ = sqrt((2 * R * S) / I)                                ██");
            Console.WriteLine("        ██                             Where:                                                             ██");
            Console.WriteLine("        ██                             R = total yearly production requirement                            ██");
            Console.WriteLine("        ██                             S = setup cost per order                                           ██");
            Console.WriteLine("        ██                             I = inventory carrying cost per unit                               ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            double num1 = 2, R, S, I, EOQ;

            Console.Write("                                        Enter the yearly production requirement: ");
            R = Convert.ToDouble(Console.ReadLine());

            Console.Write("                                        Enter the setup cost per order: ");
            S = Convert.ToDouble(Console.ReadLine());

            Console.Write("                                        Enter the inventory carrying cost per unit: ");
            I = Convert.ToDouble(Console.ReadLine());

            EOQ = Math.Sqrt((num1 * R * S) / I);

            Console.WriteLine("                                        The Economic Order Quantity (EOQ) is: " + EOQ);

            Console.WriteLine();
            Console.Write("[0] back / [1] continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module1_9();
                    break;
                case 0:
                    DisplayModule1();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module1_10()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██            Machine Problem 1.10: Calculate the area of a circle given its radius.              ██");
            Console.WriteLine("        ██                                       Formula: A = π * r^2                                     ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            double r, A, pi = 3.1416;

            Console.Write("                                            Enter the radius of the circle: ");
            r = Convert.ToDouble(Console.ReadLine());

            A = pi * r * r;

            Console.WriteLine($"                                            The area of a circle with radius {r} is: {A}");

            Console.WriteLine();
            Console.Write("[0] back / [1] continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module1_10();
                    break;
                case 0:
                    DisplayModule1();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }



        static void DisplayModule2()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ██                  ███    ███  ██████  ██████  ██    ██ ██      ███████     ██████               ██");
                Console.WriteLine("        ██                  ████  ████ ██    ██ ██   ██ ██    ██ ██      ██               ██              ██");
                Console.WriteLine("        ██                  ██ ████ ██ ██    ██ ██   ██ ██    ██ ██      █████        █████               ██");
                Console.WriteLine("        ██                  ██  ██  ██ ██    ██ ██   ██ ██    ██ ██      ██          ██                   ██");
                Console.WriteLine("        ██                  ██      ██  ██████  ██████   ██████  ███████ ███████     ███████              ██");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ██                      [1]  MACHINE PROBLEM 2.1 : Determine Vowel or Consonant                   ██");
                Console.WriteLine("        ██                      [2]  MACHINE PROBLEM 2.2 : Determine Date value                           ██");
                Console.WriteLine("        ██                      [3]  MACHINE PROBLEM 2.3 : Determine Temperature value                    ██");
                Console.WriteLine("        ██                      [4]  MACHINE PROBLEM 2.4 : Determine type of aircraft                     ██");
                Console.WriteLine("        ██                      [5]  MACHINE PROBLEM 2.5 : Determine type of ship                         ██");
                Console.WriteLine("        ██                      [6]  MACHINE PROBLEM 2.6 : Determine earthquake range                     ██");
                Console.WriteLine("        ██                      [7]  MACHINE PROBLEM 2.7 : Number to word conversion                      ██");
                Console.WriteLine("        ██                      [8]  MACHINE PROBLEM 2.8 : Ordinary numbers to Roman numerals             ██");
                Console.WriteLine("        ██                      [9]  MACHINE PROBLEM 2.9 : Compute and assess tuition fee                 ██");
                Console.WriteLine("        ██                      [10] MACHINE PROBLEM 2.10: Grade equivalent                               ██");
                Console.WriteLine("        ██                      [0] Back                                                                  ██");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine("");
                Console.Write("                          Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Module2_1(); break;
                    case 2: Module2_2(); break;
                    case 3: Module2_3(); break;
                    case 4: Module2_4(); break;
                    case 5: Module2_5(); break;
                    case 6: Module2_6(); break;
                    case 7: Module2_7(); break;
                    case 8: Module2_8(); break;
                    case 9: Module2_9(); break;
                    case 10: Module2_10(); break;
                    case 0: Console.WriteLine("Returning to main menu..."); break;
                    default: Console.WriteLine("Invalid option. Please try again."); break;
                }
            } while (choice != 0);
        }

        static void Module2_1()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 2.1: Determine if an input letter is a vowel or consonant.                  ██");
            Console.WriteLine("        ██        The vowels are: A, E, I, O, U. The program should handle both capital and lowercase.    ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██        1st solution: Use an if/else if/else conditional statement                              ██");
            Console.WriteLine("        ██        2nd solution: Use a switch/case conditional statement                                   ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            Console.Write("                                           Enter the letter: ");
            char letter = char.ToLower(Console.ReadLine()[0]);

            Console.WriteLine();
            Console.WriteLine("                                           Solution 1: Using if/else if/else");
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("                                           The letter is a vowel.");
            }
            else
            {
                Console.WriteLine("                                           The letter is a consonant.");
            }

            Console.WriteLine();
            Console.Write("[0] back / [1] continue: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module2_1();
                    break;
                case 0:
                    DisplayModule2();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }

        static void Module2_2()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 2.2: Display Date based on month, day, and year input.                      ██");
            Console.WriteLine("        ██    The program will display the full month name along with the entered day and year.           ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            double month, days, year;

            Console.Write("                                           Enter the month (1-12): ");
            month = Convert.ToDouble(Console.ReadLine());

            Console.Write("                                           Enter the day: ");
            days = Convert.ToDouble(Console.ReadLine());

            Console.Write("                                           Enter the year: ");
            year = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("                                           Result: ");

            switch (month)
            {
                case 1:
                    Console.WriteLine($"                                           January {days}, {year}");
                    break;
                case 2:
                    Console.WriteLine($"                                           February {days}, {year}");
                    break;
                case 3:
                    Console.WriteLine($"                                           March {days}, {year}");
                    break;
                case 4:
                    Console.WriteLine($"                                           April {days}, {year}");
                    break;
                case 5:
                    Console.WriteLine($"                                           May {days}, {year}");
                    break;
                case 6:
                    Console.WriteLine($"                                           June {days}, {year}");
                    break;
                case 7:
                    Console.WriteLine($"                                           July {days}, {year}");
                    break;
                case 8:
                    Console.WriteLine($"                                           August {days}, {year}");
                    break;
                case 9:
                    Console.WriteLine($"                                           September {days}, {year}");
                    break;
                case 10:
                    Console.WriteLine($"                                           October {days}, {year}");
                    break;
                case 11:
                    Console.WriteLine($"                                           November {days}, {year}");
                    break;
                case 12:
                    Console.WriteLine($"                                           December {days}, {year}");
                    break;
                default:
                    Console.WriteLine("                                           Invalid month input. Please enter a value between 1 and 12.");
                    break;
            }

            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module2_2();
                    break;
                case 0:
                    DisplayModule2();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    DisplayModule2();
                    break;
            }
        }
        static void Module2_3()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 2.3: Determine the state of matter based on temperature input.              ██");
            Console.WriteLine("        ██    The program will display whether the temperature is ICE, WATER, or STEAM.                   ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██                         TEMPERATURE                       MESSAGE                              ██");
            Console.WriteLine("        ██                         Less than 0                       ICE                                  ██");
            Console.WriteLine("        ██                         Between 0 and 100                 WATER                                ██");
            Console.WriteLine("        ██                         Exceeds 100                       STEAM                                ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            double temp;

            Console.Write("                                           Enter the temperature: ");
            temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("                                           Result: ");

            if (temp < 0)
            {
                Console.WriteLine("                                           ICE");
            }
            else if (temp >= 0 && temp <= 100)
            {
                Console.WriteLine("                                           WATER");
            }
            else
            {
                Console.WriteLine("                                           STEAM");
            }

            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module2_3();
                    break;
                case 0:
                    DisplayModule2();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    DisplayModule2();
                    break;
            }
        }
        static void Module2_4()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 2.4: Aircraft Classification by Speed and Length                            ██");
            Console.WriteLine("        ██    This program will label an aircraft as Civilian, Military, or classify it as a bird.        ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    CONDITIONS:                                                                                 ██");
            Console.WriteLine("        ██    - Civilian Aircraft: Speed > 1100 km/h and Length > 52 m                                    ██");
            Console.WriteLine("        ██    - Military Aircraft: Speed < 1100 km/h and Length < 52 m OR                                 ██");
            Console.WriteLine("        ██                       Speed > 500 km/h and Length > 20 m                                       ██");
            Console.WriteLine("        ██    - Bird: Speed < 500 km/h and Length < 20 m                                                  ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            double speed, length;

            Console.Write("                                           Enter the speed in km/h: ");
            speed = Convert.ToDouble(Console.ReadLine());

            Console.Write("                                           Enter the length in meters: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("                                           Result: ");

            if (speed > 1100 && length > 52)
            {
                Console.WriteLine("                                           Civilian Aircraft");
            }
            else if ((speed < 1100 && length < 52) || (speed > 500 && length > 20))
            {
                Console.WriteLine("                                           Military Aircraft");
            }
            else if (speed < 500 && length < 20)
            {
                Console.WriteLine("                                           It's a bird");
            }
            else
            {
                Console.WriteLine("                                           Unidentified Classification");
            }

            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module2_4();
                    break;
                case 0:
                    DisplayModule2();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    DisplayModule2();
                    break;
            }
        }

        static void Module2_5()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██                      Machine Problem 2.5: Determine Ship Class by Class ID                     ██");
            Console.WriteLine("        ██           The program will output the type of ship based on the provided class ID.             ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██                               CLASS ID                          SHIP CLASS                     ██");
            Console.WriteLine("        ██                               B or b                            Battleship                     ██");
            Console.WriteLine("        ██                               C or c                            Cruiser                        ██");
            Console.WriteLine("        ██                               D or d                            Destroyer                      ██");
            Console.WriteLine("        ██                               F or f                            Frigate                        ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            Console.Write("                                           Enter the class ID (B, C, D, F): ");
            char letter = char.ToLowerInvariant(Console.ReadLine()[0]);

            Console.WriteLine();
            Console.WriteLine("                                           Result: ");

            if (letter == 'b')
            {
                Console.WriteLine("                                           Battleship");
            }
            else if (letter == 'c')
            {
                Console.WriteLine("                                           Cruiser");
            }
            else if (letter == 'd')
            {
                Console.WriteLine("                                           Destroyer");
            }
            else if (letter == 'f')
            {
                Console.WriteLine("                                           Frigate");
            }
            else
            {
                Console.WriteLine("                                           Unknown Class ID");
            }

            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module2_5();
                    break;
                case 0:
                    DisplayModule2();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    DisplayModule2();
                    break;
            }
        }


        static void Module2_6()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 2.6: Determine Earthquake Damage by Richter Scale Value                     ██");
            Console.WriteLine("        ██    This program characterizes earthquake damage based on the Richter scale input.              ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    RICHTER SCALE                      DAMAGE CHARACTERIZATION                                  ██");
            Console.WriteLine("        ██    N < 5.0                            Little or no damage                                      ██");
            Console.WriteLine("        ██    5.0 <= N < 5.5                     Some damage                                              ██");
            Console.WriteLine("        ██    5.5 <= N < 6.5                     Serious damage                                           ██");
            Console.WriteLine("        ██    6.5 <= N < 7.5                     Disaster                                                 ██");
            Console.WriteLine("        ██    Higher than 7.5                    Catastrophe                                              ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            double N;

            Console.Write("                                           Enter the Richter scale value: ");
            N = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("                                           Damage Characterization: ");

            if (N < 5.0)
            {
                Console.WriteLine("                                           Little or no damage");
            }
            else if (N >= 5.0 && N < 5.5)
            {
                Console.WriteLine("                                           Some damage");
            }
            else if (N >= 5.5 && N < 6.5)
            {
                Console.WriteLine("                                           Serious damage");
            }
            else if (N >= 6.5 && N < 7.5)
            {
                Console.WriteLine("                                           Disaster");
            }
            else
            {
                Console.WriteLine("                                           Catastrophe");
            }

            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module2_6();
                    break;
                case 0:
                    DisplayModule2();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    DisplayModule2();
                    break;
            }
        }


        static void Module2_7()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 2.7: Write the program that accepts a number and outputs its equivalent     ██");
            Console.WriteLine("        ██    in words. Enter a number: 1380               Output: One thousand three hundred eighty      ██");
            Console.WriteLine("        ██                   Take note: The maximum input number is 3000.                                 ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            Console.Write("Enter a number you want (up to 3000): ");
            int num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 3000)
            {
                Console.WriteLine("Number is out of range. Please enter a number between 1 and 3000.");
            }
            else
            {
                Console.WriteLine("Output: " + NumberToWords(num));
            }

            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module2_7();
                    break;
                case 0:
                    DisplayModule2();
                    break;
                default:
                    DisplayModule2();
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }

        static string NumberToWords(int num)
        {
            if (num == 0) return "zero";

            string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string result = "";

            if (num >= 1000)
            {
                result += ones[num / 1000] + " thousand ";
                num %= 1000;
            }

            if (num >= 100)
            {
                result += ones[num / 100] + " hundred ";
                num %= 100;
            }

            if (num >= 20)
            {
                result += tens[num / 10] + " ";
                num %= 10;
            }
            else if (num >= 10 && num < 20)
            {
                result += teens[num - 10] + " ";
                num = 0;
            }

            if (num > 0)
            {
                result += ones[num] + " ";
            }

            return result.Trim();
        }

        static void Module2_8()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 2.8: Write a program that accepts a number and outputs its equivalent       ██");
            Console.WriteLine("        ██    Roman numerals. Enter a number: 1380               Output: MMDCCCLXXX                       ██");
            Console.WriteLine("        ██    Take note: The maximum input number is 3000.                                                ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            Console.Write("Enter a number you want (up to 3000): ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0 || num > 3000)
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 3000.");
            }
            else
            {
                Console.WriteLine("Output: " + NumberToRoman(num));
            }

            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module2_8();
                    break;
                case 0:
                    DisplayModule2();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }

        static string NumberToRoman(int num)
        {
            string romanNumeral = ""; // Initialize here

            if (num >= 1000)
            {
                romanNumeral += new string('M', num / 1000);
                num %= 1000;
            }
            if (num >= 900)
            {
                romanNumeral += "CM";
                num -= 900;
            }
            else if (num >= 500)
            {
                romanNumeral += "D";
                num -= 500;
            }
            else if (num >= 400)
            {
                romanNumeral += "CD";
                num -= 400;
            }
            if (num >= 100)
            {
                romanNumeral += new string('C', num / 100);
                num %= 100;
            }
            if (num >= 90)
            {
                romanNumeral += "XC";
                num -= 90;
            }
            else if (num >= 50)
            {
                romanNumeral += "L";
                num -= 50;
            }
            else if (num >= 40)
            {
                romanNumeral += "XL";
                num -= 40;
            }
            if (num >= 10)
            {
                romanNumeral += new string('X', num / 10);
                num %= 10;
            }
            if (num == 9)
            {
                romanNumeral += "IX";
                num -= 9;
            }
            else if (num >= 5)
            {
                romanNumeral += "V";
                num -= 5;
            }
            else if (num == 4)
            {
                romanNumeral += "IV";
                num -= 4;
            }

            romanNumeral += new string('I', num);

            return romanNumeral;
        }
        static void Module2_9()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 2.9: Write a program that computes and assesses the tuition fee of students ██");
            Console.WriteLine("        ██    based on the selected mode of payment (Cash, Two Installments, Three Installments).         ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            Console.Write("Enter Tuition Fee Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Select Payment Plan");
            Console.WriteLine("1. Cash (10% Discount)");
            Console.WriteLine("2. Two Installments (5% Discount)");
            Console.WriteLine("3. Three Installments (10% Discount)");
            Console.WriteLine("0. Exit");

            Console.Write("                          Enter your choice: ");
            int input = Convert.ToInt32(Console.ReadLine());

            double discount10Percent = amount * 0.10;
            double discount5Percent = amount * 0.05;
            double interest5Percent = amount * 0.05;

            if (input == 1)
            {
                Console.WriteLine("You chose Cash Payment.");
                Console.WriteLine($"Your Total Tuition Fee is: {amount - discount10Percent}");
            }
            else if (input == 2)
            {
                Console.WriteLine("You chose Two Installments.");
                Console.WriteLine($"Your Total Tuition Fee is: {amount - discount5Percent}");
            }
            else if (input == 3)
            {
                Console.WriteLine("You chose Three Installments.");
                Console.WriteLine($"Your Total Tuition Fee is: {amount + interest5Percent}");
            }
            else if (input == 0)
            {
                Console.WriteLine("Thank you for using the program.");
                Console.WriteLine("Exiting the program...");
            }
            else
            {
                Console.WriteLine("Invalid Input! Please try again.");
            }

            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module2_9();
                    break;
                case 0:
                    DisplayModule2();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module2_10()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 2.10: Write a program that accepts an input grade in percentile form and    ██");
            Console.WriteLine("        ██          outputs its grade equivalent based on the given range of percentile and grade         ██");
            Console.WriteLine("        ██                                        equivalent table.                                       ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            Console.Write("Enter Grade (in percentile): ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 98 && grade <= 100)
            {
                Console.WriteLine("Grade Equivalent: 1.00");
            }
            else if (grade >= 95 && grade <= 97)
            {
                Console.WriteLine("Grade Equivalent: 1.25");
            }
            else if (grade >= 92 && grade <= 94)
            {
                Console.WriteLine("Grade Equivalent: 1.50");
            }
            else if (grade >= 89 && grade <= 91)
            {
                Console.WriteLine("Grade Equivalent: 1.75");
            }
            else if (grade >= 85 && grade <= 88)
            {
                Console.WriteLine("Grade Equivalent: 2.00");
            }
            else if (grade >= 82 && grade <= 84)
            {
                Console.WriteLine("Grade Equivalent: 2.25");
            }
            else if (grade >= 80 && grade <= 81)
            {
                Console.WriteLine("Grade Equivalent: 2.50");
            }
            else if (grade >= 77 && grade <= 79)
            {
                Console.WriteLine("Grade Equivalent: 2.75");
            }
            else if (grade >= 75 && grade <= 76)
            {
                Console.WriteLine("Grade Equivalent: 3.00");
            }
            else
            {
                Console.WriteLine("Grade Equivalent: Out of Range");
            }

            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module2_10();
                    break;
                case 0:
                    DisplayModule2();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }

        static void DisplayModule3()
        {
            int choice;
            do
            {
                Console.Clear();
            Console.WriteLine("");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ██                 ███    ███  ██████  ██████  ██    ██ ██      ███████     ██████                ██");
                Console.WriteLine("        ██                 ████  ████ ██    ██ ██   ██ ██    ██ ██      ██               ██               ██");
                Console.WriteLine("        ██                 ██ ████ ██ ██    ██ ██   ██ ██    ██ ██      █████        █████                ██");
                Console.WriteLine("        ██                 ██  ██  ██ ██    ██ ██   ██ ██    ██ ██      ██               ██               ██");
                Console.WriteLine("        ██                 ██      ██  ██████  ██████   ██████  ███████ ███████     ██████                ██");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ██                 [1]  MACHINE PROBLEM 3.1 : Calculate looping sequence number                   ██");
                Console.WriteLine("        ██                 [2]  MACHINE PROBLEM 3.2 : Produce Number sequence                             ██");
                Console.WriteLine("        ██                 [3]  MACHINE PROBLEM 3.3 : Produce number sequence (reverse order)             ██");
                Console.WriteLine("        ██                 [4]  MACHINE PROBLEM 3.4 : Calculate factorial value                           ██");
                Console.WriteLine("        ██                 [5]  MACHINE PROBLEM 3.5 : Fibonacci sequence numbers                          ██");
                Console.WriteLine("        ██                 [6]  MACHINE PROBLEM 3.6 : Calculate power value                               ██");
                Console.WriteLine("        ██                 [7]  MACHINE PROBLEM 3.7 : Sum of square of numbers                            ██");
                Console.WriteLine("        ██                 [8]  MACHINE PROBLEM 3.8 : Calculate sum of sequence of numbers                ██");
                Console.WriteLine("        ██                 [9]  MACHINE PROBLEM 3.9 : Reverses input numbers                              ██");
                Console.WriteLine("        ██                 [10]  MACHINE PROBLEM 3.10 : Sum of power N                                    ██");
                Console.WriteLine("        ██                 [0] Back                                                                       ██");
                Console.WriteLine("        ██                                                                                                ██");
                Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
                Console.WriteLine("");
                Console.Write("                          Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Module3_1(); break;
                    case 2: Module3_2(); break;
                    case 3: Module3_3(); break;
                    case 4: Module3_4(); break;
                    case 5: Module3_5(); break;
                    case 6: Module3_6(); break;
                    case 7: Module3_7(); break;
                    case 8: Module3_8(); break;
                    case 9: Module3_9(); break;
                    case 10: Module3_10(); break;
                    case 0: Console.WriteLine("Returning to main menu..."); break;
                    default: Console.WriteLine("Invalid option. Please try again."); break;
                }
            } while (choice != 0);
        }
        static void Module3_1()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 3.1: Write a program that calculates and produces sequence numbers and their██");
            Console.WriteLine("        ██    squares using three looping statements.                                                     ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            // First loop for Sequence Numbers
            Console.WriteLine("SEQUENCE NOS.         SQUARED");
            for (int x = 1; x <= num; x++)
            {
                // Second loop for Squares
                int square = x * x;

                // Third loop for printing both values
                Console.WriteLine($"{x,-20} {square}");
            }

            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module3_1();
                    break;
                case 0:
                    DisplayModule3();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module3_2()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 3.2: Write a program that produces the given sequence numbers               ██");
            Console.WriteLine("        ██    (1,5,2,4,3,3,4,2,5,1) using three looping statements.                                       ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            for (int x = 1, y = num; x <= num; x++, y--)
            {
                Console.Write(" " + x + " " + y);
            }

            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module3_2();
                    break;
                case 0:
                    DisplayModule3();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module3_3()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 3.3: Write a program that produces the given sequence numbers               ██");
            Console.WriteLine("        ██    (5,1,4,3,3,2,4,1,5) using three looping statements.                                         ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            for (int x = 1, y = num; x <= num; x++, y--)
            {
                Console.Write(" " + y + " " + x);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module3_3();
                    break;
                case 0:
                    DisplayModule3();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module3_4()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 3.4: Write a program that calculates the factorial value of the input       ██");
            Console.WriteLine("        ██    number n! using the incrementation formula (i++).                                           ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            int input, total = 1;

            Console.Write("Enter the Number: ");
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                total *= i;
                Console.Write(total);

            }

            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module3_4();
                    break;
                case 0:
                    DisplayModule3();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module3_5()
        {
            // Clear the console for a fresh output
            Console.Clear();
            Console.WriteLine("");

            // Display program heading
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 3.5: Write a program that generates and displays the Fibonacci series of    ██");
            Console.WriteLine("        ██    n numbers using three loops. The third number in Fibonacci is the sum of two previous       ██");
            Console.WriteLine("        ██    numbers.                                                                                    ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int f = 1, s = 1, n;

            Console.Write("Fibonacci series: ");

            for (int i = 1; i <= input; i++)
            {
                Console.Write(f + " ");
                n = f + s;
                f = s;
                s = n;
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module3_5();
                    break;
                case 0:
                    DisplayModule3();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module3_6()
        {
            // Clear the console for a fresh output
            Console.Clear();
            Console.WriteLine("");

            // Display program heading
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 3.6: Write a program that calculates the power of the input base number     ██");
            Console.WriteLine("        ██    and exponent number using three loops.                                                      ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            int r = 1;
            Console.Write("Enter the Number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Exponent: ");
            int input2 = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < input2; i++)
            {
                r *= input1;
                Console.Write(input1);
                if (i < input1)
                    Console.Write(" + ");
            }
            Console.Write("=" + r);
            Console.WriteLine();

            // Allow the user to retry or exit
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module3_6();
                    break;
                case 0:
                    DisplayModule3();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module3_7()
        {
            // Clear the console for a fresh output
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 3.7: Write a program that calculates the sum of squares from 1 to n.        ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            int input, total = 0;
            Console.WriteLine("Enter a Number: ");
            input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                total += i * i;
                Console.Write($"{i}^2");
                if (i < input)
                    Console.Write(" + ");

            }
            Console.WriteLine(" =" + total);

            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module3_7();
                    break;
                case 0:
                    DisplayModule3();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }

        static void Module3_8()
        {
            // Clear the console for a fresh output
            Console.Clear();
            Console.WriteLine("");
            // Display program heading
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 3.8: Write a program that calculates the sum of numbers from 1 to n.        ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            int total = 0;

            Console.WriteLine("Enter a Number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                total += i;

                Console.Write($"{i} + ");
            }
            Console.WriteLine("=" + total);
            Console.WriteLine();
            // Allow the user to retry or exit
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module3_8();
                    break;
                case 0:
                    DisplayModule3();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module3_9()
        {
            // Clear the console for a fresh output
            Console.Clear();
            Console.WriteLine("");
            // Display program heading
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██    Machine Problem 3.9: Reverses input numbers                                                 ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");


            Console.Write("Input number: ");
            int number = int.Parse(Console.ReadLine());
            int reversed = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                reversed = reversed * 10 + lastDigit;
                number /= 10;
            }

            Console.WriteLine("Output: " + reversed);

            // Allow the user to retry or exit
            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module3_9();
                    break;
                case 0:
                    DisplayModule3();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
        static void Module3_10()
        {
            // Clear the console for a fresh output
            Console.Clear();
            Console.WriteLine("");

            // Display program heading
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ██                    Machine Problem 3.10: Write a program that calculates                       ██");
            Console.WriteLine("        ██                                                                                                ██");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("");

            int sum = 0;

            Console.WriteLine("Enter a Number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                sum += (int)Math.Pow(i, i);
                Console.Write($"{i}^{i}");
                if (i < input)
                    Console.Write(" + ");
            }

            Console.WriteLine(" = " + sum);

            // Allow the user to retry or exit
            Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Module3_10();
                    break;
                case 0:
                    DisplayModule3();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
        }
         static void Activity(){
            int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                              █████╗  ██████╗████████╗██╗██╗   ██╗██╗████████╗██╗   ██╗");
            Console.WriteLine("                             ██╔══██╗██╔════╝╚══██╔══╝██║██║   ██║██║╚══██╔══╝╚██╗ ██╔╝");
            Console.WriteLine("                             ███████║██║        ██║   ██║██║   ██║██║   ██║    ╚████╔╝ ");
            Console.WriteLine("                             ██╔══██║██║        ██║   ██║╚██╗ ██╔╝██║   ██║     ╚██╔╝  ");
            Console.WriteLine("                             ██║  ██║╚██████╗   ██║   ██║ ╚████╔╝ ██║   ██║      ██║   ");
            Console.WriteLine("                             ╚═╝  ╚═╝ ╚═════╝   ╚═╝   ╚═╝  ╚═══╝  ╚═╝   ╚═╝      ╚═╝   ");
            Console.WriteLine("");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
            Console.WriteLine("        ██                                                                                                ██           ");
            Console.WriteLine("        ██                             [1] Pink Form                                                      ██           ");
            Console.WriteLine("        ██                             [2] Calculator                                                     ██           ");
            Console.WriteLine("        ██                             [3] Compute Salary and Bonus                                       ██           ");
            Console.WriteLine("        ██                             [0] Back                                                           ██           ");
            Console.WriteLine("        ██                                                                                                ██           ");
            Console.WriteLine("        ████████████████████████████████████████████████████████████████████████████████████████████████████           ");
            Console.WriteLine("");
            Console.Write("                         Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        PinkForm();
                        break;
                    case 2:
                        Calculator();
                        break;
                    case 3:
                        ComputeSalaryAndBonus();
                        break;
                    case 0:
                        Console.WriteLine("Going back...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            if (choice != 0)
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }

        } while (choice != 0);

        Console.WriteLine("Exiting the menu. Goodbye!");
    }

    static void PinkForm()
    {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("                                                         ╔═╗┬┌┐┌┬┌─  ┌─┐┌─┐┬─┐┌┬┐                                                               ");
            Console.WriteLine("                                                         ╠═╝││││├┴┐  ├┤ │ │├┬┘│││                                                               ");
            Console.WriteLine("                                                         ╩  ┴┘└┘┴ ┴  └  └─┘┴└─┴ ┴                                                               ");
            Console.WriteLine("");
            Console.WriteLine("                                              Immaculate Conception I-College of Arts and Technology                                            ");
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│ STUDENT NAME         NAME (Last, Given, Middle)                        TERM                             SCHOOL YEAR                          │");
            Console.WriteLine("│ 2024-0050-IC         GREGORIO, FRANCO, MIRARZA                           1                                2024-2025                          │");
            Console.WriteLine("├──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤");
            Console.WriteLine("│ COURSE                       SECTION                                  YEAR LEVEL                        ACADEMIC STATUS                      │");
            Console.WriteLine("│   BSIS                       BSIS 1-2                                     1                             IRREGULAR                            │");
            Console.WriteLine("├──────────────────────────────────────────────────────────────────┬─────────────────────────────────────────┬─────────────────────────────────┤");
            Console.WriteLine("│    CLASS IDSUB NO.CODE     TITLE                            UNITS│ TOTAL:                                  │MODE OF PAYMENT                  │");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│    BSIS 1-2   C-EN1  PURPOSIVE COMMUNICATION                    3│ Registration Fee                1,000.00│ FULL PAYMENT                    │");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│    BSIS 1-2   C-HUM ART APPRECIATION                            3│ Total Tuition Fee              10,500.00│ 1st Payment            15,900.00│");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│    BSIS 1-2   CC2    COMPUTER PROGRAMMING 1 (FUND OF            3│ Stud. Dev/Lab/ComSys/Etc            0.00│ 2nd Payment                 0.00│");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│    BSIS 1-2   TH 1   SALVATION HISTORY                          3│ Total Misc. Fee                 4,400.00│ 3rd Payment                 0.00│");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│    BSIS 1-2   NSTP 1 CWSTS 1                                    3│ Other Fee                           0.00│ 4th Payment                 0.00│");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│                                                                  │ AMOUNT DUE                     15,900.00│ 5th Payment                 0.00│");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│                                                                  │ Discount Fee                      00.00 │ 6th Payment                 0.00│");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│                                                                  │ Other Discount Fee                0.00  │ TOTAL:                          │");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│                                                                  │ TOTAL DISCOUNTS                   0.00  │                                 │");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│                                                                  │ Special Class                     0.00  │                                 │");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│                                                                  │ NET AMOUNT DUE                 15,900.00│                                 │");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│                                                                  ├─────────────────────────────────────────┼─────────────────────────────────┤");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│                                                                  │ CONTRACT:                               │STUDENT'S NAME & SIGNATURE       │");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│                                                                  │  Upom admission at the ICICAT, I hereby │                                 │");
            Console.WriteLine("│                                                                  │promise to obey all the existing rules   │                                 │");
            Console.WriteLine("│                                                                  │                                         │                                 │");
            Console.WriteLine("│                                                                  │and regulation established by the        │                                 │");
            Console.WriteLine("├───────────────────────────────────────┬──────────────────────────┤                                         │                                 │");
            Console.WriteLine("│ DATE                                  │ TOTAL                    │authorities of this                      │     KEYLYN S.D. ZANO            │");
            Console.WriteLine("│       7/09/24                         │                 15       │                                         │                                 │");
            Console.WriteLine("|                                       │                          │institution                              │           Assessed By           │");
            Console.WriteLine("└───────────────────────────────────────┴──────────────────────────┴─────────────────────────────────────────┴─────────────────────────────────┘");
        Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                   PinkForm();
                    break;
                case 0:

                    Activity();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
    }

    static void Calculator()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("                             ╔═╗┌─┐┬  ┌─┐┬ ┬┬  ┌─┐┌┬┐┌─┐┬─┐");
        Console.WriteLine("                             ║  ├─┤│  │  │ ││  ├─┤ │ │ │├┬┘");
        Console.WriteLine("                             ╚═╝┴ ┴┴─┘└─┘└─┘┴─┘┴ ┴ ┴ └─┘┴└─");
        Console.WriteLine("");
            double num1, num2, multi, divide, add, sub;

            //input
            Console.Write("                     Input Num1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("                     Input Num2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            //process
            multi = num1 * num2;
            divide = num1 / num2;
            add = num1 + num2;
            sub = num1 - num2;

            //output
            Console.WriteLine("                     Multiplication: " + multi);
            Console.WriteLine("                     division: " + divide);
            Console.WriteLine("                     addition: " + add);
            Console.WriteLine("                     subtruction: " + sub);
                Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Calculator();                    
                    break;
                case 0:
                Activity();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
     }

    static void ComputeSalaryAndBonus()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("        ╔═╗┌─┐┌┬┐┌─┐┬ ┬┌┬┐┌─┐  ╔═╗┌─┐┬  ┌─┐┬─┐┬ ┬  ┌─┐┌┐┌┌┬┐  ╔╗ ┌─┐┌┐┌┬ ┬┌─┐  ");
        Console.WriteLine("        ║  │ ││││├─┘│ │ │ ├┤   ╚═╗├─┤│  ├─┤├┬┘└┬┘  ├─┤│││ ││  ╠╩╗│ │││││ │└─┐  ");
        Console.WriteLine("        ╚═╝└─┘┴ ┴┴  └─┘ ┴ └─┘  ╚═╝┴ ┴┴─┘┴ ┴┴└─ ┴   ┴ ┴┘└┘─┴┘  ╚═╝└─┘┘└┘└─┘└─┘  ");
        Console.WriteLine("");
string name;
double salary, bonus;

 Console.Write("                            Enter The Name:");
name = Convert.ToString(Console.ReadLine());

Console.Write("                             Enter The salary");
 salary = Convert.ToDouble(Console.ReadLine());

if (salary <= 1000)
{
  bonus = salary * 0.50;
 Console.Write( "                   Hi" + name+"Your Salary is" + bonus);
 }
 else if (salary >= 1000)
 {
   Console.Write("Your salary is 1000");
 }
     Console.WriteLine();
            Console.Write("                      [0] Back / [1] Retry: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ComputeSalaryAndBonus();                    
                    break;
                case 0:
                Activity();
                    break;
                default:
                    Console.WriteLine("Returning to main menu...");
                    break;
            }
     }
    }
}
