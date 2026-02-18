// StatusBarExtras.cs

using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;

namespace MauiStatusBarTest;

[AttachedBindableProperty<Color>("StatusBarColor", CoerceValueMethodName = nameof(CoerceStatusBarColor))]
[AttachedBindableProperty<StatusBarStyle>("StatusBarStyle", CoerceValueMethodName = nameof(CoerceStatusBarStyle))]
public static partial class StatusBarExtras
{
	static object CoerceStatusBarColor(BindableObject bindable, object value)
	{
#if ANDROID || IOS
		CommunityToolkit.Maui.Core.Platform.StatusBar.SetColor((Color?)value);
#endif
		return value;
	}
	static object CoerceStatusBarStyle(BindableObject bindable, object value)
	{
#if ANDROID || IOS
		CommunityToolkit.Maui.Core.Platform.StatusBar.SetStyle((StatusBarStyle)value);
#endif
		return value;
	}
}
