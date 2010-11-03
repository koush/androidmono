package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class RadioGroup_OnCheckedChangeListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.RadioGroup.OnCheckedChangeListener
{
	static
	{
		MonoBridge.link(RadioGroup_OnCheckedChangeListenerDelegateWrapper.class, "onCheckedChanged", "(Landroid/widget/RadioGroup;I)V", "android.widget.RadioGroup,System.Int32");

	}

	public native void onCheckedChanged(android.widget.RadioGroup arg0,int arg1);



}
