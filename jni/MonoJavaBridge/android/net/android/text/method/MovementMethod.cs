namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface MovementMethod 
	{ 
		void initialize(android.widget.TextView arg0, android.text.Spannable arg1); 
		bool onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3); 
		bool onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3); 
		bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2); 
		bool onTrackballEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2); 
		bool onKeyOther(android.widget.TextView arg0, android.text.Spannable arg1, android.view.KeyEvent arg2); 
		void onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2); 
		bool canSelectArbitrarily(); 
	} 
} 
