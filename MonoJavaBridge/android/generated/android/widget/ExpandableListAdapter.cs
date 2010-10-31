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
		private static global::MonoJavaBridge.MethodId _m0;
		bool android.widget.ExpandableListAdapter.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "isEmpty", "()Z", ref global::android.widget.ExpandableListAdapter_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.widget.ExpandableListAdapter.registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.ExpandableListAdapter_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.widget.ExpandableListAdapter.unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.widget.ExpandableListAdapter_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		long android.widget.ExpandableListAdapter.getGroupId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getGroupId", "(I)J", ref global::android.widget.ExpandableListAdapter_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool android.widget.ExpandableListAdapter.areAllItemsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "areAllItemsEnabled", "()Z", ref global::android.widget.ExpandableListAdapter_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool android.widget.ExpandableListAdapter.hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "hasStableIds", "()Z", ref global::android.widget.ExpandableListAdapter_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int android.widget.ExpandableListAdapter.getGroupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getGroupCount", "()I", ref global::android.widget.ExpandableListAdapter_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		int android.widget.ExpandableListAdapter.getChildrenCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getChildrenCount", "(I)I", ref global::android.widget.ExpandableListAdapter_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.lang.Object android.widget.ExpandableListAdapter.getGroup(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getGroup", "(I)Ljava/lang/Object;", ref global::android.widget.ExpandableListAdapter_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.lang.Object android.widget.ExpandableListAdapter.getChild(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getChild", "(II)Ljava/lang/Object;", ref global::android.widget.ExpandableListAdapter_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		long android.widget.ExpandableListAdapter.getChildId(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getChildId", "(II)J", ref global::android.widget.ExpandableListAdapter_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::android.view.View android.widget.ExpandableListAdapter.getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ExpandableListAdapter_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::android.view.View android.widget.ExpandableListAdapter.getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ExpandableListAdapter_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		bool android.widget.ExpandableListAdapter.isChildSelectable(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "isChildSelectable", "(II)Z", ref global::android.widget.ExpandableListAdapter_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void android.widget.ExpandableListAdapter.onGroupExpanded(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "onGroupExpanded", "(I)V", ref global::android.widget.ExpandableListAdapter_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void android.widget.ExpandableListAdapter.onGroupCollapsed(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "onGroupCollapsed", "(I)V", ref global::android.widget.ExpandableListAdapter_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		long android.widget.ExpandableListAdapter.getCombinedChildId(long arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getCombinedChildId", "(JJ)J", ref global::android.widget.ExpandableListAdapter_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		long android.widget.ExpandableListAdapter.getCombinedGroupId(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ExpandableListAdapter_.staticClass, "getCombinedGroupId", "(J)J", ref global::android.widget.ExpandableListAdapter_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ExpandableListAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ExpandableListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListAdapter"));
		}
	}
}
