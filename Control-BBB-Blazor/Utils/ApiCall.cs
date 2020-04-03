namespace Control_BBB_Blazor.Utils
{
  public class ApiCall
  {
    public static string getMeetings(string url, string clave)
    {
      var text = EasyEncryption.SHA.ComputeSHA1Hash("getMeetings" + clave);
      return url + "/getMeetings?checksum=" + text;
    }

    //public static string endMeetings(ID sala a cerrar);

    //public static string getMeetingInfo(ID);
  }
}

