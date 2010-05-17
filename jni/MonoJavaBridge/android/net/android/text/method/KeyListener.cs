namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface KeyListener 
	{ 
		bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3); 
		bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3); 
		int getInputType(); 
		bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2); 
		void clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2); 
	} 
} 
