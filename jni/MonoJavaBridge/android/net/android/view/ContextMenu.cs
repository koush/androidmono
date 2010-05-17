namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ContextMenu : Menu
	{ 
		android.view.ContextMenu setHeaderTitle(int arg0); 
		android.view.ContextMenu setHeaderTitle(java.lang.CharSequence arg0); 
		android.view.ContextMenu setHeaderIcon(int arg0); 
		android.view.ContextMenu setHeaderIcon(android.graphics.drawable.Drawable arg0); 
		android.view.ContextMenu setHeaderView(android.view.View arg0); 
		void clearHeader(); 
	} 
} 
