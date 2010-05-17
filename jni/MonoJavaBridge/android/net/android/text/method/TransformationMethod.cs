namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface TransformationMethod 
	{ 
		void onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4); 
		java.lang.CharSequence getTransformation(java.lang.CharSequence arg0, android.view.View arg1); 
	} 
} 
