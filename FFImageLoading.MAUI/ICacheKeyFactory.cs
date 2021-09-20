using System;
using Microsoft.Maui.Controls;

namespace FFImageLoading.Forms
{
    [Preserve(AllMembers = true)]
	public interface ICacheKeyFactory
	{
		string GetKey(ImageSource imageSource, object bindingContext);
	}
}

