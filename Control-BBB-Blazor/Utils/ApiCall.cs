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

    //public static string getMeetingInfo(ID);
  }
}

