namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ExpandableListAdapter_))]
	public interface ExpandableListAdapter  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class ExpandableListAdapter_ : java.lang.Object, ExpandableListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExpandableListAdapter_()
		{
			InitJNI();
		}
		internal ExpandableListAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty11757;
		 bool android.widget.ExpandableListAdapter.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._isEmpty11757);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._isEmpty11757);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver11758;
		 void android.widget.ExpandableListAdapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._registerDataSetObserver11758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._registerDataSetObserver11758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver11759;
		 void android.widget.ExpandableListAdapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._unregisterDataSetObserver11759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._unregisterDataSetObserver11759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId11760;
		 long android.widget.ExpandableListAdapter.getGroupId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._getGroupId11760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._getGroupId11760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled11761;
		 bool android.widget.ExpandableListAdapter.areAllItemsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._areAllItemsEnabled11761);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._areAllItemsEnabled11761);
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds11762;
		 bool android.widget.ExpandableListAdapter.hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._hasStableIds11762);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._hasStableIds11762);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupCount11763;
		 int android.widget.ExpandableListAdapter.getGroupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._getGroupCount11763);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._getGroupCount11763);
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCount11764;
		 int android.widget.ExpandableListAdapter.getChildrenCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._getChildrenCount11764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._getChildrenCount11764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroup11765;
		 global::java.lang.Object android.widget.ExpandableListAdapter.getGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._getGroup11765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._getGroup11765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChild11766;
		 global::java.lang.Object android.widget.ExpandableListAdapter.getChild(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._getChild11766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._getChild11766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChildId11767;
		 long android.widget.ExpandableListAdapter.getChildId(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._getChildId11767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._getChildId11767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupView11768;
		 global::android.view.View android.widget.ExpandableListAdapter.getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._getGroupView11768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._getGroupView11768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getChildView11769;
		 global::android.view.View android.widget.ExpandableListAdapter.getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._getChildView11769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._getChildView11769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isChildSelectable11770;
		 bool android.widget.ExpandableListAdapter.isChildSelectable(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._isChildSelectable11770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._isChildSelectable11770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupExpanded11771;
		 void android.widget.ExpandableListAdapter.onGroupExpanded(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._onGroupExpanded11771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._onGroupExpanded11771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupCollapsed11772;
		 void android.widget.ExpandableListAdapter.onGroupCollapsed(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._onGroupCollapsed11772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._onGroupCollapsed11772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCombinedChildId11773;
		 long android.widget.ExpandableListAdapter.getCombinedChildId(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._getCombinedChildId11773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._getCombinedChildId11773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCombinedGroupId11774;
		 long android.widget.ExpandableListAdapter.getCombinedGroupId(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_._getCombinedGroupId11774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ExpandableListAdapter_.staticClass, global::android.widget.ExpandableListAdapter_._getCombinedGroupId11774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ExpandableListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ExpandableListAdapter"));
			global::android.widget.ExpandableListAdapter_._isEmpty11757 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "isEmpty", "()Z");
			global::android.widget.ExpandableListAdapter_._registerDataSetObserver11758 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.ExpandableListAdapter_._unregisterDataSetObserver11759 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.ExpandableListAdapter_._getGroupId11760 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "getGroupId", "(I)J");
			global::android.widget.ExpandableListAdapter_._areAllItemsEnabled11761 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.ExpandableListAdapter_._hasStableIds11762 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "hasStableIds", "()Z");
			global::android.widget.ExpandableListAdapter_._getGroupCount11763 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "getGroupCount", "()I");
			global::android.widget.ExpandableListAdapter_._getChildrenCount11764 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.ExpandableListAdapter_._getGroup11765 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.ExpandableListAdapter_._getChild11766 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.ExpandableListAdapter_._getChildId11767 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "getChildId", "(II)J");
			global::android.widget.ExpandableListAdapter_._getGroupView11768 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ExpandableListAdapter_._getChildView11769 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ExpandableListAdapter_._isChildSelectable11770 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "isChildSelectable", "(II)Z");
			global::android.widget.ExpandableListAdapter_._onGroupExpanded11771 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "onGroupExpanded", "(I)V");
			global::android.widget.ExpandableListAdapter_._onGroupCollapsed11772 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "onGroupCollapsed", "(I)V");
			global::android.widget.ExpandableListAdapter_._getCombinedChildId11773 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "getCombinedChildId", "(JJ)J");
			global::android.widget.ExpandableListAdapter_._getCombinedGroupId11774 = @__env.GetMethodIDNoThrow(global::android.widget.ExpandableListAdapter_.staticClass, "getCombinedGroupId", "(J)J");
		}
	}
}
