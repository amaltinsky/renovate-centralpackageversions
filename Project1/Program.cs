class Project1
{
    static readonly HttpClient client = new HttpClient();

    static void Main()
    {
        var response = client.GetAsync("http://www.github.com/").Result;
        response.EnsureSuccessStatusCode();
        var responseBody = response.Content.ReadAsStringAsync().Result;
        Console.WriteLine(responseBody);
    }
}