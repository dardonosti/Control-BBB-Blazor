using Control_BBB_Blazor.Data;
using System.Web;
using System;

namespace Control_BBB_Blazor.Utils
{
  public class ApiCall
  {
    public static string getMeetings(string url, string clave)
    {
      var str = EasyEncryption.SHA.ComputeSHA1Hash("getMeetings" + clave);
      return url + "/getMeetings?checksum=" + str;
    }

    //public static string endMeetings(ID sala a cerrar);

    public static string getMeetingInfo(Meeting sala, string url, string clave)
    {
      var str = "getMeetingInfomeetingID=" + Uri.EscapeUriString(sala.MeetingID[0].ToString()) + "&password=" + Uri.EscapeUriString(sala.ModeratorPW[0].ToString()) + clave;
      return url + "/getMeetingInfo?meetingID=" + Uri.EscapeUriString(sala.MeetingID[0].ToString()) + "&password=" + Uri.EscapeUriString(sala.ModeratorPW[0].ToString()) + "&checksum=" + EasyEncryption.SHA.ComputeSHA1Hash(str);
    }
  }
}

