using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chosenOne = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Genetics Menu:");
                Console.WriteLine("[ 1 ] What is Genetics");
                Console.WriteLine("[ 2 ] Types of Genetic Inheritance");
                Console.WriteLine("[ 3 ] More Information About DNA and Genes");
                Console.WriteLine("[ 4 ] Chromosomes and Their Function");
                Console.WriteLine("[ 5 ] Genetic Mutations");
                Console.WriteLine("[ 6 ] Genetic Disorders");
                Console.WriteLine("[ 7 ] Gene Editing (CRISPR and Other Technologies)");
                Console.WriteLine("[ 8 ] Human Genome Project");
                Console.WriteLine("[ 9 ] Epigenetics");
                Console.WriteLine("[ 10 ] Evolution and Genetics");
                Console.WriteLine("[ 0 ] Exit");
                Console.Write("Choose an option: ");

                chosenOne = Convert.ToInt32(Console.ReadLine());

                switch (chosenOne)
                {
                    case 1: WhatIsGenetics(); break;
                    case 2: TypesOfGeneticInheritance(); break;
                    case 3: MoreInfoAboutDNAAndGenes(); break;
                    case 4: ChromosomesAndTheirFunction(); break;
                    case 5: GeneticMutations(); break;
                    case 6: GeneticDisorders(); break;
                    case 7: GeneEditing(); break;
                    case 8: HumanGenomeProject(); break;
                    case 9: Epigenetics(); break;
                    case 10: EvolutionAndGenetics(); break;
                }

            } while (chosenOne != 0);
        }

        static void WhatIsGenetics()
        {

            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("What is Genetics:");
                Console.WriteLine("Explanation of the field of genetics and its role in studying heredity and variation.");
                Console.Write("input [0] to back: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                // Here you can define methods for each type of inheritance if needed

            } while (subOption != 0);
            
           
        }

        static void TypesOfGeneticInheritance()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Types of Genetic Inheritance:");
                Console.WriteLine("[ 1 ] Dominant Inheritance");
                Console.WriteLine("[ 2 ] Recessive Inheritance");
                Console.WriteLine("[ 3 ] Co-Dominance");
                Console.WriteLine("[ 4 ] Incomplete Dominance");
                Console.WriteLine("[ 5 ] Sex-Linked Inheritance");
                Console.WriteLine("[ 6 ] Mitochondrial Inheritance");
                Console.WriteLine("[ 0 ] Go Back");
                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: Inheritance1(); break;
                    case 2: Inheritance2(); break;
                    case 3: Inheritance3(); break;
                    case 4: Inheritance4(); break;
                    case 5: Inheritance5(); break;
                    case 6: Inheritance6(); break;
                }


                // Here you can define methods for each type of inheritance if needed

            } while (subOption != 0);
        }
        static void Inheritance1()
        {
            Console.WriteLine("[ 1 ] Dominant Inheritance");
        }

        static void Inheritance2()
        {
            Console.WriteLine("[ 2 ] Recessive Inheritance");
        }
        static void Inheritance3()
        {
            Console.WriteLine("[ 3 ] Co-Dominance");
        }
        static void Inheritance4()
        {
            Console.WriteLine("[ 4 ] Incomplete Dominance");
        }
        static void Inheritance5()
        {
            Console.WriteLine("[ 5 ] Sex-Linked Inheritance");
        }

        static void Inheritance6()
        {
            Console.WriteLine("[ 6 ] Mitochondrial Inheritance");
        }



        static void MoreInfoAboutDNAAndGenes()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("More Information About DNA and Genes:");
                Console.WriteLine("[ 1 ] Introduction to DNA");
                Console.WriteLine("[ 2 ] Genes and Their Functions");
                Console.WriteLine("[ 3 ] DNA Replication");
                Console.WriteLine("[ 4 ] Gene Expression and Regulation");
                Console.WriteLine("[ 5 ] Genetic Variation");
                Console.WriteLine("[ 6 ] Inheritance Patterns");
                Console.WriteLine("[ 7 ] Genetic Technologies");
                Console.WriteLine("[ 8 ] Human Genome Project");
                Console.WriteLine("[ 9 ] Ethical Considerations in Genetics");
                Console.WriteLine("[ 10 ] Future of Genetics");
                Console.WriteLine("[ 0 ] Go Back");
                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                // Define methods for each sub-option if needed

            } while (subOption != 0);
        }

        static void ChromosomesAndTheirFunction()
        {


            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Chromosomes and Their Function:");
                Console.WriteLine("Description of chromosomes, how they carry genetic information, and their role in cell division.");
                Console.Write("input [0] to back: ");
                subOption = Convert.ToInt32(Console.ReadLine());

            } while (subOption != 0);
        }

        static void GeneticMutations()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Genetic Mutations:");
                Console.WriteLine("[ 1 ] Types of Mutations");
                Console.WriteLine("[ 2 ] Causes of Mutations");
                Console.WriteLine("[ 3 ] Effects of Mutations");
                Console.WriteLine("[ 0 ] Go Back");
                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                // Define methods for each sub-option if needed

            } while (subOption != 0);
        }

        static void GeneticDisorders()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Genetic Disorders:");
                Console.WriteLine("[ 1 ] Single-Gene Disorders");
                Console.WriteLine("[ 2 ] Chromosomal Disorders");
                Console.WriteLine("[ 3 ] Multifactorial Disorders");
                Console.WriteLine("[ 4 ] Mitochondrial Disorders");
                Console.WriteLine("[ 0 ] Go Back");
                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                // Define methods for each sub-option if needed

            } while (subOption != 0);
        }

        static void GeneEditing()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Gene Editing (CRISPR and Other Technologies):");
                Console.WriteLine("[ 1 ] What is CRISPR?");
                Console.WriteLine("[ 2 ] How CRISPR Works");
                Console.WriteLine("[ 3 ] Applications of CRISPR in Medicine");
                Console.WriteLine("[ 4 ] Gene Therapy and CRISPR");
                Console.WriteLine("[ 5 ] Ethical Issues in Gene Editing");
                Console.WriteLine("[ 6 ] Future of CRISPR Technology");
                Console.WriteLine("[ 7 ] Other Gene Editing Technologies (Zinc Finger Nucleases, TALENs)");
                Console.WriteLine("[ 8 ] Gene Editing in Agriculture");
                Console.WriteLine("[ 9 ] Gene Editing and Cancer Research");
                Console.WriteLine("[ 10 ] Risks and Limitations of Gene Editing");
                Console.WriteLine("[ 0 ] Go Back");
                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                // Define methods for each sub-option if needed

            } while (subOption != 0);
        }

        static void HumanGenomeProject()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Human Genome Project:");
                Console.WriteLine("[ 1 ] Overview of the Human Genome Project");
                Console.WriteLine("[ 2 ] Goals of the Human Genome Project");
                Console.WriteLine("[ 3 ] Timeline of the Human Genome Project");
                Console.WriteLine("[ 4 ] Achievements of the Human Genome Project");
                Console.WriteLine("[ 5 ] Impact of the Human Genome Project on Medicine");
                Console.WriteLine("[ 6 ] Ethical Concerns Related to the Human Genome Project");
                Console.WriteLine("[ 7 ] International Collaboration in the Human Genome Project");
                Console.WriteLine("[ 8 ] Role of Technology in the Human Genome Project");
                Console.WriteLine("[ 9 ] Human Genome Project and Personalized Medicine");
                Console.WriteLine("[ 10 ] Future of Genomic Research");
                Console.WriteLine("[ 0 ] Go Back");
                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                // Define methods for each sub-option if needed

            } while (subOption != 0);
        }

        static void Epigenetics()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Epigenetics:");
                Console.WriteLine("[ 1 ] What is Epigenetics?");
                Console.WriteLine("[ 2 ] DNA Methylation");
                Console.WriteLine("[ 3 ] Histone Modification");
                Console.WriteLine("[ 4 ] Environmental Impact on Epigenetics");
                Console.WriteLine("[ 5 ] Role of Epigenetics in Disease");
                Console.WriteLine("[ 0 ] Go Back");
                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                // Define methods for each sub-option if needed

            } while (subOption != 0);
        }

        static void EvolutionAndGenetics()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Evolution and Genetics:");
                Console.WriteLine("[ 1 ] What is Evolution?");
                Console.WriteLine("[ 2 ] Natural Selection");
                Console.WriteLine("[ 3 ] Genetic Drift");
                Console.WriteLine("[ 4 ] Gene Flow");
                Console.WriteLine("[ 5 ] Evolutionary Developmental Biology");
                Console.WriteLine("[ 0 ] Go Back");
                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                // Define methods for each sub-option if needed

            } while (subOption != 0);
        }
    }
}
