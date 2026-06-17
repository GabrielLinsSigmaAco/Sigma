using System.Text.Json;
using System.Net.Http;

public class Manifest
{
    public string version { get; set; }
    public Files files { get; set; }
}

public class Files
{
    public string appEnc { get; set; }
    public string appSig { get; set; }
    public string icon { get; set; }
}

public class UpdateClient
{
    private static HttpClient client = new HttpClient();

    public static async Task<Manifest> GetManifest()
    {
        string url = "https://raw.githubusercontent.com/SEU_USUARIO/SEU_REPO/main/manifest.json";
        var json = await client.GetStringAsync(url);
        return JsonSerializer.Deserialize<Manifest>(json);
    }

    public static async Task<byte[]> Download(string url)
    {
        return await client.GetByteArrayAsync(url);
    }
}
