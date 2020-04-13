using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Control_BBB_Blazor.Data
{
	[XmlRoot(ElementName="meeting")]
	public class Meeting {
		[XmlElement(ElementName="meetingID")]
		public string MeetingID { get; set; }
		[XmlElement(ElementName="meetingName")]
		public string MeetingName { get; set; }
		[XmlElement(ElementName="createTime")]
		public string CreateTime { get; set; }
		[XmlElement(ElementName="attendeePW")]
		public string AttendeePW { get; set; }
		[XmlElement(ElementName="moderatorPW")]
		public string ModeratorPW { get; set; }
		[XmlElement(ElementName="hasBeenForciblyEnded")]
		public string HasBeenForciblyEnded { get; set; }
		[XmlElement(ElementName="running")]
		public string Running { get; set; }
	}

	[XmlRoot(ElementName="meetings")]
	public class Meetings {
		[XmlElement(ElementName="meeting")]
		public List<Meeting> Meeting { get; set; }
	}

	[XmlRoot(ElementName="response")]
	public class MeetingResponse {
		[XmlElement(ElementName="returncode")]
		public string Returncode { get; set; }
		[XmlElement(ElementName="meetings")]
		public Meetings Meetings { get; set; }
	}
}