namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ExpandableListAdapter 
	{ 
		bool isEmpty(); 
		void registerDataSetObserver(android.database.DataSetObserver arg0); 
		void unregisterDataSetObserver(android.database.DataSetObserver arg0); 
		long getGroupId(int arg0); 
		bool areAllItemsEnabled(); 
		bool hasStableIds(); 
		int getGroupCount(); 
		int getChildrenCount(int arg0); 
		java.lang.Object getGroup(int arg0); 
		java.lang.Object getChild(int arg0, int arg1); 
		long getChildId(int arg0, int arg1); 
		android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3); 
		android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4); 
		bool isChildSelectable(int arg0, int arg1); 
		void onGroupExpanded(int arg0); 
		void onGroupCollapsed(int arg0); 
		long getCombinedChildId(long arg0, long arg1); 
		long getCombinedGroupId(long arg0); 
	} 
} 
