
using System;
using MonoDevelop.Core;
using MonoDevelop.Core.Serialization;
using MonoDevelop.Projects;
using System.IO;
using System.Text;

namespace MonoDevelop.Android
{

	public class AndroidProjectConfiguration : DotNetProjectConfiguration, ICustomDataItem
	{
		#region ICustomDataItem implementation
		public DataCollection Serialize (ITypeSerializer handler)
		{
			return new DataCollection();
		}
		
		public void Deserialize (ITypeSerializer handler, DataCollection data)
		{
		}
		#endregion

		public AndroidProjectConfiguration ()
		{
		}
	}
}
