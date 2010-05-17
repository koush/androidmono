namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Menu 
	{ 
		android.view.MenuItem add(int arg0); 
		android.view.MenuItem add(int arg0, int arg1, int arg2, java.lang.CharSequence arg3); 
		android.view.MenuItem add(int arg0, int arg1, int arg2, int arg3); 
		android.view.MenuItem add(java.lang.CharSequence arg0); 
		void clear(); 
		int size(); 
		void close(); 
		bool isShortcutKey(int arg0, android.view.KeyEvent arg1); 
		android.view.SubMenu addSubMenu(java.lang.CharSequence arg0); 
		android.view.SubMenu addSubMenu(int arg0, int arg1, int arg2, java.lang.CharSequence arg3); 
		android.view.SubMenu addSubMenu(int arg0); 
		android.view.SubMenu addSubMenu(int arg0, int arg1, int arg2, int arg3); 
		int addIntentOptions(int arg0, int arg1, int arg2, android.content.ComponentName arg3, android.content.Intent[] arg4, android.content.Intent arg5, int arg6, android.view.MenuItem[] arg7); 
		void removeItem(int arg0); 
		void removeGroup(int arg0); 
		void setGroupCheckable(int arg0, bool arg1, bool arg2); 
		void setGroupVisible(int arg0, bool arg1); 
		void setGroupEnabled(int arg0, bool arg1); 
		bool hasVisibleItems(); 
		android.view.MenuItem findItem(int arg0); 
		android.view.MenuItem getItem(int arg0); 
		bool performShortcut(int arg0, android.view.KeyEvent arg1, int arg2); 
		bool performIdentifierAction(int arg0, int arg1); 
		void setQwertyMode(bool arg0); 
	} 
} 
