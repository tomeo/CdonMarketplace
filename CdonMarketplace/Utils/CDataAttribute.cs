using System;

namespace CdonMarketplace.Utils
{
	public class CDataAttribute : Attribute
	{
		public CDataAttribute(Type propertyType, string property)
		{
			PropertyType = propertyType;
			Property = property;
		}

		public Type PropertyType { get; }
		public string Property { get; }
	}
}
