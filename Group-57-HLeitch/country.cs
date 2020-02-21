using System;


namespace test
{
	public class Country

	{
		public bool participating = true;

		//Permanant Variables
		private float _population;
		private bool _eurozoneMember;
		public string name;
		public float population {
			get { return _population; }
			set { _population = value; }


		}

		public Country(string n, float pop, bool euro)
        {
			name = n;
			_population = pop;
			_eurozoneMember = euro;


        }

		  

	

	}

}





