namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface InputMethodSession 
	{ 
		void dispatchKeyEvent(int arg0, android.view.KeyEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2); 
		void dispatchTrackballEvent(int arg0, android.view.MotionEvent arg1, android.view.inputmethod.InputMethodSession_EventCallback arg2); 
		void finishInput(); 
		void updateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5); 
		void updateCursor(android.graphics.Rect arg0); 
		void displayCompletions(android.view.inputmethod.CompletionInfo[] arg0); 
		void updateExtractedText(int arg0, android.view.inputmethod.ExtractedText arg1); 
		void appPrivateCommand(java.lang.String arg0, android.os.Bundle arg1); 
		void toggleSoftInput(int arg0, int arg1); 
	} 
} 
