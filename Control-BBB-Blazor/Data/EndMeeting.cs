using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Control_BBB_Blazor.Data
{
	[XmlRoot(ElementName="response")]
	public class EndMeetingResponse {
		[XmlElement(ElementName="returncode")]
		public string Returncode { get; set; }
		[XmlElement(ElementName="messageKey")]
		public string MessageKey { get; set; }
		[XmlElement(ElementName="message")]
		public string Message { get; set; }
	}
}