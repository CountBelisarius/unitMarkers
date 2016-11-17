using System;
namespace belisarius.unitMarkers
{
	public class Unit
	{
		private string _name
		{
			get
			{
				return _name;
			}

			set
			{
				if (value.Length == 0 || value.Length > 50)
				{
					throw new OverflowException();
				}
				_name = value;

			}
		}

		private int _strength
		{
			get
			{
				return _strength;
			}

			set
			{
				if (value < 1 || value > 5000)
				{
					throw new OverflowException();
				}
				_strength = value;
			}

		}


		public Unit()
		{
			
		}
	}
}
