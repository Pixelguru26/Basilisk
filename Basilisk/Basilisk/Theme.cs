using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Newtonsoft.Json;

namespace Basilisk
{
	public class Theme
	{
        // Menu includes any of the following:
        //  - The Chat Panel
        //  - Popup Menus
        //  - Friends Menu
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color MenuBack;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color MenuLight;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color MenuDark;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color MenuBorder;

        // Panel includes any of the following:
        //  - Friend / Server / Channel List
        //  - Text Input / Button
        //  - Any Buttons
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color PanelBack;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color PanelFore;
        [JsonConverter(typeof(HexColorJsonConverter))]
        public Color PanelInput;
        [JsonConverter(typeof(HexColorJsonConverter))]
        public Color PanelCaret;
        [JsonConverter(typeof(HexColorJsonConverter))]
        public Color PanelBorder;

        // Grounds includes the following:
        //  - Text Color of any Menus
        //  - Background Color of any Misc. Menus / The Main Window
        [JsonConverter(typeof(HexColorJsonConverter))]
		public Color Background;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color Foreground;

        // Text includes the following:
        //  - Color of Text / Text Selection in Chat
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color Text;
		[JsonConverter(typeof(HexColorJsonConverter))]
		public Color TextLink;
        [JsonConverter(typeof(HexColorJsonConverter))]
        public Color TextLinkVisited;
        [JsonConverter(typeof(HexColorJsonConverter))]
		public Color TextUser;
        [JsonConverter(typeof(HexColorJsonConverter))]
		public Color TextSystem;
        [JsonConverter(typeof(HexColorJsonConverter))]
        public Color TextSelection;

        // Misc. includes the following:
        //  - Whatever I want, screw you
        [JsonConverter(typeof(HexColorJsonConverter))]
		public Color Title;
        [JsonConverter(typeof(HexColorJsonConverter))]
        public Color Subtitle;
        [JsonConverter(typeof(HexColorJsonConverter))]
        public Color Tooltip;
        [JsonConverter(typeof(HexColorJsonConverter))]
        public Color TooltipBack;
    }
}
