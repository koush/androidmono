
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
            var collection = handler.Serialize (this);
            return collection;
		}
		
		public void Deserialize (ITypeSerializer handler, DataCollection data)
		{
            handler.Deserialize (this, data);
		}
		#endregion
   
		public AndroidProjectConfiguration () : base()
		{
		}
        
        public AndroidProjectConfiguration (string name) : base (name)
        {
        }
    }
}
