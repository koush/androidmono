namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface MenuItem 
	{ 
		bool isChecked(); 
		android.view.MenuItem setChecked(bool arg0); 
		bool isEnabled(); 
		android.view.MenuItem setEnabled(bool arg0); 
		android.content.Intent getIntent(); 
		android.view.MenuItem setVisible(bool arg0); 
		bool isVisible(); 
		android.view.MenuItem setIntent(android.content.Intent arg0); 
		android.view.MenuItem setTitle(int arg0); 
		android.view.MenuItem setTitle(java.lang.CharSequence arg0); 
		java.lang.CharSequence getTitle(); 
		int getItemId(); 
		int getGroupId(); 
		int getOrder(); 
		android.view.MenuItem setTitleCondensed(java.lang.CharSequence arg0); 
		java.lang.CharSequence getTitleCondensed(); 
		android.view.MenuItem setIcon(android.graphics.drawable.Drawable arg0); 
		android.view.MenuItem setIcon(int arg0); 
		android.graphics.drawable.Drawable getIcon(); 
		android.view.MenuItem setShortcut(char arg0, char arg1); 
		android.view.MenuItem setNumericShortcut(char arg0); 
		char getNumericShortcut(); 
		android.view.MenuItem setAlphabeticShortcut(char arg0); 
		char getAlphabeticShortcut(); 
		android.view.MenuItem setCheckable(bool arg0); 
		bool isCheckable(); 
		bool hasSubMenu(); 
		android.view.SubMenu getSubMenu(); 
		android.view.MenuItem setOnMenuItemClickListener(android.view.MenuItem_OnMenuItemClickListener arg0); 
		android.view.ContextMenu_ContextMenuInfo getMenuInfo(); 
	} 
} 
