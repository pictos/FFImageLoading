using System;
using Microsoft.Maui.Controls;

namespace FFImageLoading.Forms
{
    
	public interface ICacheKeyFactory
	{
		string GetKey(ImageSource imageSource, object bindingContext);
	}
}

