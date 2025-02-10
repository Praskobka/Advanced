using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
		private List<Person> people;

		public List<Person> People
		{
			get { return people; }
			set { people = value; }
		}
		public Family()
		{
			this.People = new List<Person>();
		}
		public void AddMember(Person member)
		{
			People.Add(member);
		}
		public Person GetOlderstMember()
		{
			int oldest = 0;
			foreach (Person member in People)
			{
				if (member.Age > oldest)
				{
					oldest = member.Age;
				}
			}
			Person result= null;
			foreach (Person member in People)
			{
				if(member.Age ==oldest)
				{
					result = member;
					break;
				}
			}
			return result;
		}
	}
}
