﻿using System;
using System.Collections.Generic;

namespace test
{
    public abstract class Vars
    {
        
        
        //declaring variables
        public static int iterationValue = 0;
        public static float countriesAgreed = 0;
        public static float populationPercentage = 0;
    }

    public class Inputs
    {
        private static void Main()
        {

            //Arrays for countries and populations
            string[] countries = new string[] { "Austria", "Belgium", "Bulgaria", "Croatia", "Cyprus", "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary", "Ireland", "Italy", "Latvia", "Lithuania", "Luxembourg", "Malta", "Netherlands", "Poland", "Portugal", "Romania", "Slovakia", "Slovenia", "Spain", "Sweden" };
            float[] countryPopulations = new float[] { 1.98f, 2.56f, 1.56f, 0.91f, 0.20f, 2.35f, 1.30f, 0.30f, 1.23f, 14.98f, 18.54f, 2.40f, 2.18f, 1.10f, 13.65f, 0.43f, 0.62f, 0.14f, 0.11f, 3.89f, 8.49f, 2.30f, 4.34f, 1.22f, 0.47f, 10.49f, 2.29f };
            List<Country> listOfCountries = new List<Country> { };


            foreach (string c in countries)
            {
                Country a = new Country(c, countryPopulations[Vars.iterationValue], false);
                listOfCountries.Add(a);
            }
            Vars.iterationValue = 0;

            
            //while value is less than the number of countries loop
                //  while (Vars.iterationValue < 27)
            foreach( Country c in listOfCountries)
            {
                Console.WriteLine("\n{0}\nYes, No or Abstain: ", c.name);
                //taking user input on whether the country is agreeing, disagreeing or abstaining
                string userInput = Console.ReadLine();
                //changing the input to all lowercase
                userInput = userInput.ToLower();
                if (userInput == "yes")
                {
                    //changing population value from string to float
                        //float tempPopulation = float.Parse(Vars.countryPopulations[Vars.iterationValue]);
                    //increasing the population count by the population increase
                    Vars.populationPercentage += c.population;
                    //rounds the population to a 2d.p. percentage, rounds towards the nearest whole no.
                    Math.Round(Vars.populationPercentage, 2, MidpointRounding.AwayFromZero);
                    //if the population exceeds 100, population equals 100
                    if(Vars.populationPercentage > 100)
                    {
                        Vars.populationPercentage = 100;
                    }
                    //increasing the country count by one
                    Vars.countriesAgreed += 1;
                }
                //increasing loop variable by one
                Vars.iterationValue += 1;
            }
            //turning countriesAgreed into a percentage
            Vars.countriesAgreed = (Vars.countriesAgreed / 27) * 100;
            Output.QualifiedMajority();
        }
    }
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