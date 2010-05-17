namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface InputMethod 
	{ 
		void createSession(android.view.inputmethod.InputMethod_SessionCallback arg0); 
		void setSessionEnabled(android.view.inputmethod.InputMethodSession arg0, bool arg1); 
		void revokeSession(android.view.inputmethod.InputMethodSession arg0); 
		void attachToken(android.os.IBinder arg0); 
		void bindInput(android.view.inputmethod.InputBinding arg0); 
		void unbindInput(); 
		void startInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1); 
		void restartInput(android.view.inputmethod.InputConnection arg0, android.view.inputmethod.EditorInfo arg1); 
		void showSoftInput(int arg0, android.os.ResultReceiver arg1); 
		void hideSoftInput(int arg0, android.os.ResultReceiver arg1); 
	} 
} 
