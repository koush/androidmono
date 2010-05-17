namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface WindowManager : ViewManager
	{ 
		android.view.Display getDefaultDisplay(); 
		void removeViewImmediate(android.view.View arg0); 
	} 
} 
