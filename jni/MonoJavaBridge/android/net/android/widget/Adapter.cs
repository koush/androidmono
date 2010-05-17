namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Adapter 
	{ 
		bool isEmpty(); 
		int getCount(); 
		void registerDataSetObserver(android.database.DataSetObserver arg0); 
		void unregisterDataSetObserver(android.database.DataSetObserver arg0); 
		java.lang.Object getItem(int arg0); 
		long getItemId(int arg0); 
		bool hasStableIds(); 
		android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2); 
		int getItemViewType(int arg0); 
		int getViewTypeCount(); 
	} 
} 
