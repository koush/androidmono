namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListAdapter_))]
	public partial interface ExpandableListAdapter  : global::MonoJavaBridge.IJavaObject 
	{
		bool isEmpty();
		void registerDataSetObserver(android.database.DataSetObserver arg0);
		void unregisterDataSetObserver(android.database.DataSetObserver arg0);
		long getGroupId(int arg0);
		bool areAllItemsEnabled();
		bool hasStableIds();
		int getGroupCount();
		int getChildrenCount(int arg0);
		global::java.lang.Object getGroup(int arg0);
		global::java.lang.Object getChild(int arg0, int arg1);
		long getChildId(int arg0, int arg1);
		global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3);
		global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4);
		bool isChildSelectable(int arg0, int arg1);
		void onGroupExpanded(int arg0);
		void onGroupCollapsed(int arg0);
		long getCombinedChildId(long arg0, long arg1);
		long getCombinedGroupId(long arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ExpandableListAdapter))]
	internal sealed partial class ExpandableListAdapter_ : java.lang.Object, ExpandableListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ExpandableListAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty17004;
		bool android.widget.ExpandableListAdapter.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "isEmpty", "()Z", ref global::android.widget.ExpandableListAdapter_._isEmpty17004);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver17005;
		void android.widget.ExpandableListAdapter.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.ExpandableListAdapter_._registerDataSetObserver17005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver17006;
		void android.widget.ExpandableListAdapter.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.ExpandableListAdapter_._unregisterDataSetObserver17006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId17007;
		long android.widget.ExpandableListAdapter.getGroupId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getGroupId", "(I)J", ref global::android.widget.ExpandableListAdapter_._getGroupId17007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled17008;
		bool android.widget.ExpandableListAdapter.areAllItemsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "areAllItemsEnabled", "()Z", ref global::android.widget.ExpandableListAdapter_._areAllItemsEnabled17008);
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds17009;
		bool android.widget.ExpandableListAdapter.hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "hasStableIds", "()Z", ref global::android.widget.ExpandableListAdapter_._hasStableIds17009);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupCount17010;
		int android.widget.ExpandableListAdapter.getGroupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getGroupCount", "()I", ref global::android.widget.ExpandableListAdapter_._getGroupCount17010);
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCount17011;
		int android.widget.ExpandableListAdapter.getChildrenCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getChildrenCount", "(I)I", ref global::android.widget.ExpandableListAdapter_._getChildrenCount17011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroup17012;
		global::java.lang.Object android.widget.ExpandableListAdapter.getGroup(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getGroup", "(I)Ljava/lang/Object;", ref global::android.widget.ExpandableListAdapter_._getGroup17012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChild17013;
		global::java.lang.Object android.widget.ExpandableListAdapter.getChild(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getChild", "(II)Ljava/lang/Object;", ref global::android.widget.ExpandableListAdapter_._getChild17013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChildId17014;
		long android.widget.ExpandableListAdapter.getChildId(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getChildId", "(II)J", ref global::android.widget.ExpandableListAdapter_._getChildId17014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupView17015;
		global::android.view.View android.widget.ExpandableListAdapter.getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ExpandableListAdapter_._getGroupView17015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getChildView17016;
		global::android.view.View android.widget.ExpandableListAdapter.getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ExpandableListAdapter_._getChildView17016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isChildSelectable17017;
		bool android.widget.ExpandableListAdapter.isChildSelectable(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "isChildSelectable", "(II)Z", ref global::android.widget.ExpandableListAdapter_._isChildSelectable17017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupExpanded17018;
		void android.widget.ExpandableListAdapter.onGroupExpanded(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "onGroupExpanded", "(I)V", ref global::android.widget.ExpandableListAdapter_._onGroupExpanded17018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupCollapsed17019;
		void android.widget.ExpandableListAdapter.onGroupCollapsed(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "onGroupCollapsed", "(I)V", ref global::android.widget.ExpandableListAdapter_._onGroupCollapsed17019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCombinedChildId17020;
		long android.widget.ExpandableListAdapter.getCombinedChildId(long arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getCombinedChildId", "(JJ)J", ref global::android.widget.ExpandableListAdapter_._getCombinedChildId17020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCombinedGroupId17021;
		long android.widget.ExpandableListAdapter.getCombinedGroupId(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getCombinedGroupId", "(J)J", ref global::android.widget.ExpandableListAdapter_._getCombinedGroupId17021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ExpandableListAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ExpandableListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
