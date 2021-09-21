using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace FFImageLoading.MAUI.Sample
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				})
				.ConfigureMauiHandlers(h =>
				{
#if ANDROID
					h.AddCompatibilityRenderer(typeof(FFImageLoading.Forms.CachedImage), typeof(FFImageLoading.Forms.Platform.CachedImageFastRenderer));
#elif IOS
					h.AddCompatibilityRenderer(typeof(FFImageLoading.Forms.CachedImage), typeof(FFImageLoading.Forms.Platform.CachedImageRenderer));
#endif
				});
			return builder.Build();
		}
	}
}
