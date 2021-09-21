using System;
using System.Reflection;
using Microsoft.Maui.Controls;

namespace FFImageLoading.Forms.Helpers
{
	//TODO REmove this?
	internal static class Dependency
	{
		public static void Register(Type type, Type renderer)
		{
			var assembly = typeof(Image).GetTypeInfo().Assembly;
			var registrarType = assembly.GetType("Xamarin.Forms.Internals.Registrar") ?? assembly.GetType("Xamarin.Forms.Registrar");
			var registrarProperty = registrarType.GetRuntimeProperty("Registered");

			var registrar = registrarProperty.GetValue(registrarType, null);
			var registerMethod = registrar.GetType().GetRuntimeMethod("Register", new[] { typeof(Type), typeof(Type) });
			registerMethod.Invoke(registrar, new[] { type, renderer });
		}
	}
}
