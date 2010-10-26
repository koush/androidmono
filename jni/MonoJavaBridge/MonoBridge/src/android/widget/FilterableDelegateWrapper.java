package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class FilterableDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.Filterable
{
	static
	{
		MonoBridge.link(FilterableDelegateWrapper.class, "getFilter", "()Landroid/widget/Filter;", "");

	}

	@Override
	public native android.widget.Filter getFilter();



}
