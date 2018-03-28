namespace BusinessLogic.Http
{
    public interface IHttpClient
    {
        string GetStringAsync(string url);
    }
}
