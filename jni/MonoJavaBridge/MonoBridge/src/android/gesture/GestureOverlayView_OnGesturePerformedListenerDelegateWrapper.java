package android.gesture;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class GestureOverlayView_OnGesturePerformedListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.gesture.GestureOverlayView.OnGesturePerformedListener
{
	static
	{
		MonoBridge.link(GestureOverlayView_OnGesturePerformedListenerDelegateWrapper.class, "onGesturePerformed", "(Landroid/gesture/GestureOverlayView;Landroid/gesture/Gesture;)V", "android.gesture.GestureOverlayView,android.gesture.Gesture");

	}

	@Override
	public native void onGesturePerformed(android.gesture.GestureOverlayView arg0,android.gesture.Gesture arg1);



}
