namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SubMenu : Menu
	{ 
		android.view.MenuItem getItem(); 
		android.view.SubMenu setIcon(android.graphics.drawable.Drawable arg0); 
		android.view.SubMenu setIcon(int arg0); 
		android.view.SubMenu setHeaderTitle(int arg0); 
		android.view.SubMenu setHeaderTitle(java.lang.CharSequence arg0); 
		android.view.SubMenu setHeaderIcon(android.graphics.drawable.Drawable arg0); 
		android.view.SubMenu setHeaderIcon(int arg0); 
		android.view.SubMenu setHeaderView(android.view.View arg0); 
		void clearHeader(); 
	} 
} 
