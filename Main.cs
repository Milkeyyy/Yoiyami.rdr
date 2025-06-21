using DarkModeForms;
using Produire;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Yoiyami.rdr
{
	public class 宵闇 : IProduireStaticClass
	{
		private static readonly Dictionary<Form, DarkModeCS> dmList = new Dictionary<Form, DarkModeCS>();

		[自分へ]
		public static void 染める([を] Form ウィンドウ)
		{
			if (dmList.ContainsKey(ウィンドウ))
			{
				dmList[ウィンドウ].ApplyTheme(DarkModeCS.DisplayMode.DarkMode);
				return;
			}
			var dm = new DarkModeCS(ウィンドウ);
			dm.ApplyTheme(DarkModeCS.DisplayMode.DarkMode);
			dmList.Add(ウィンドウ, dm);
		}

		[自分を]
		public static void 晴らす([から] Form ウィンドウ)
		{
			if (dmList.ContainsKey(ウィンドウ))
			{
			   	dmList[ウィンドウ].ApplyTheme(DarkModeCS.DisplayMode.ClearMode);
				return;
			}
			var dm = new DarkModeCS(ウィンドウ);
			dm.ApplyTheme(DarkModeCS.DisplayMode.ClearMode);
			dmList.Add(ウィンドウ, dm);
		}

		[自分で]
		public static void 設定する([を] Form ウィンドウ, [へ] DarkModeCS.DisplayMode 設定)
		{
			if (dmList.ContainsKey(ウィンドウ))
			{
				dmList[ウィンドウ].ApplyTheme(設定);
				return;
			}
			var dm = new DarkModeCS(ウィンドウ);
			dm.ApplyTheme(設定);
			dmList.Add(ウィンドウ, dm);
		}
	}

	[列挙体(typeof(DarkModeCS.DisplayMode))]
	public enum 表示設定
	{
		標準 = DarkModeCS.DisplayMode.SystemDefault,
		クリア = DarkModeCS.DisplayMode.ClearMode,
		光 = DarkModeCS.DisplayMode.ClearMode,
		ダーク = DarkModeCS.DisplayMode.DarkMode,
		闇 = DarkModeCS.DisplayMode.DarkMode
	}
}
