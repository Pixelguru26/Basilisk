using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Newtonsoft.Json;

namespace Basilisk
{
	public class Theme
	{
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color Panel;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color PanelLight;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color PanelDark;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color PanelInput;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color PanelBorder;

		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color Input;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color InputBack;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color InputFore;

		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color Background;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color Foreground;

		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color Text;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color TextLink;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color TextUser;

		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color Title;
	}
}
