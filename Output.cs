using System;
using System.Collections.Generic;
namespace test
{
    public class Output
    {
        public static void QualifiedMajority()
        {

            //if population is greater than the amount needed for approval
            if (Vars.populationPercentage > 65)
            {
                //if country agreed is greater than the amount needed for approval
                if (Vars.countriesAgreed > 55)
                {
                    Console.WriteLine("\nFinal Result has been Approved.\n{0}% of the Population Agreed.\n{1}% of Countries Agreed.", Vars.populationPercentage, Vars.countriesAgreed);
                }
                //if country agreed is less than the amount needed for approval
                if (Vars.countriesAgreed <= 55)
                {
                    Console.WriteLine("\nFinal Result has not been Approved.\n{0}% of the Population Agreed.\n{1}% of Countries Agreed.", Vars.populationPercentage, Vars.countriesAgreed);
                }
            }
            //if population is less than or equal the amount needed for approval
            if (Vars.populationPercentage <= 65)
            {
                Console.WriteLine("\nFinal Result has not been Approved.\n{0}% of the Population Agreed.\n{1}% of Countries Agreed.", Vars.populationPercentage, Vars.countriesAgreed);
            }
        }

        public static void SimpleMajority()
        {

            //if population is greater than the amount needed for approval
            if (Vars.populationPercentage > 0)
            {
                //if country agreed is greater than the amount needed for approval
                if (Vars.countriesAgreed > 50)
                {
                    Console.WriteLine("\nFinal Result has been Approved.\n{0}% of the Population Agreed.\n{1}% of Countries Agreed.", Vars.populationPercentage, Vars.countriesAgreed);
                }
                //if country agreed is less than the amount needed for approval
                if (Vars.countriesAgreed <= 50)
                {
                    Console.WriteLine("\nFinal Result has not been Approved.\n{0}% of the Population Agreed.\n{1}% of Countries Agreed.", Vars.populationPercentage, Vars.countriesAgreed);
                }
            }
            //if population is less than or equal the amount needed for approval
            if (Vars.populationPercentage <= 0)
            {
                Console.WriteLine("\nFinal Result has not been Approved.\n{0}% of the Population Agreed.\n{1}% of Countries Agreed.", Vars.populationPercentage, Vars.countriesAgreed);
            }

        }
    }
}


