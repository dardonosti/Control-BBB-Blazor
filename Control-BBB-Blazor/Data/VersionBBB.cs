using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Control_BBB_Blazor.Data
{
	[XmlRoot(ElementName = "response")]
	public class VersionBBB
	{
		[XmlElement(ElementName = "returncode")]
		public string Returncode { get; set; }

		[XmlElement(ElementName = "version")]
		public string Version { get; set; }
	}

}
