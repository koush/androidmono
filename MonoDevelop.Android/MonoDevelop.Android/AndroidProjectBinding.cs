
using System;
using MonoDevelop.Projects;


namespace MonoDevelop.Android
{

	public class AndroidProjectBinding : IProjectBinding
	{
		#region IProjectBinding implementation
		public Project CreateProject (ProjectCreateInformation info, System.Xml.XmlElement projectOptions)
		{
			string lang = projectOptions.GetAttribute ("language");
			return new AndroidProject(lang, info, projectOptions);
		}
		
		public Project CreateSingleFileProject (string sourceFile)
		{
			throw new InvalidOperationException ();
		}
		
		public bool CanCreateSingleFileProject (string sourceFile)
		{
			return false;
		}
		
		public string Name {
			get {
				return "Android";
			}
		}
		#endregion
	}
}
