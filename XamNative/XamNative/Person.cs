using System;
using System.Collections.Generic;
namespace XamNative
{
	public class Person
	{
		public string FullName { get; set; }
		public string MobileNo { get; set; }

		public static List<Person> GetItems ()
		{
			return new List<Person> ()
			{
				new Person(){ FullName = "AAA 111", MobileNo = "1111111111"},
				new Person(){ FullName = "BBB 222", MobileNo = "2222222222"},
				new Person(){ FullName = "CCC 333", MobileNo = "3333333333"},
				new Person(){ FullName = "DDD 444", MobileNo = "4444444444"},
				new Person(){ FullName = "EEE 555", MobileNo = "5555555555"},
				new Person(){ FullName = "FFF 666", MobileNo = "6666666666"},
				new Person(){ FullName = "GGG 777", MobileNo = "7777777777"},
			};
		}
	}
}
