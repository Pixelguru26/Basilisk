using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;

namespace Basilisk
{
	public sealed class HexColorJsonConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return typeof(Color).Equals(objectType);
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			//writer.WriteValue($"0x{value:x}");
			// System.Drawing.ColorTranslator.FromHtml(hex);
			Color color = value as Color? ?? default(Color);
			writer.WriteValue(ColorTranslator.ToHtml(color));
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var str = reader.ReadAsString();
			if (str == null || !str.StartsWith("#"))
				throw new JsonSerializationException();
			return ColorTranslator.FromHtml(str);
		}
	}
}
