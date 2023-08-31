using Newtonsoft.Json.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

public static class SessionExtensions
{
	public static T? Get<T>(this ISession session, string key)
	{
		var value = session.GetString(key);
		return value == null ? default : JsonSerializer.Deserialize<T>(value);
	}

	public static void Set<T>(this ISession session, string key, T value)
	{
		string data = JsonSerializer.Serialize<T>(value);
		session.SetString(key, data);
	}
}
