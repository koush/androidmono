namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.BaseExpandableListAdapter_))]
	public abstract partial class BaseExpandableListAdapter : java.lang.Object, ExpandableListAdapter, HeterogeneousExpandableList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BaseExpandableListAdapter()
		{
			InitJNI();
		}
		protected BaseExpandableListAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId16802;
		public abstract long getGroupId(int arg0);
		internal static global::MonoJavaBridge.MethodId _hasStableIds16803;
		public abstract bool hasStableIds();
		internal static global::MonoJavaBridge.MethodId _getGroupCount16804;
		public abstract int getGroupCount();
		internal static global::MonoJavaBridge.MethodId _getChildrenCount16805;
		public abstract int getChildrenCount(int arg0);
		internal static global::MonoJavaBridge.MethodId _getGroup16806;
		public abstract global::java.lang.Object getGroup(int arg0);
		internal static global::MonoJavaBridge.MethodId _getChild16807;
		public abstract global::java.lang.Object getChild(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getChildId16808;
		public abstract long getChildId(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getGroupView16809;
		public abstract global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3);
		internal static global::MonoJavaBridge.MethodId _getChildView16810;
		public abstract global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4);
		internal static global::MonoJavaBridge.MethodId _isChildSelectable16811;
		public abstract bool isChildSelectable(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isEmpty16812;
		public virtual bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._isEmpty16812);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._isEmpty16812);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver16813;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._registerDataSetObserver16813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._registerDataSetObserver16813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver16814;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver16814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver16814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled16815;
		public virtual bool areAllItemsEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled16815);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled16815);
		}
		internal static global::MonoJavaBridge.MethodId _onGroupExpanded16816;
		public virtual void onGroupExpanded(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._onGroupExpanded16816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._onGroupExpanded16816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupCollapsed16817;
		public virtual void onGroupCollapsed(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._onGroupCollapsed16817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._onGroupCollapsed16817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCombinedChildId16818;
		public virtual long getCombinedChildId(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getCombinedChildId16818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getCombinedChildId16818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCombinedGroupId16819;
		public virtual long getCombinedGroupId(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getCombinedGroupId16819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getCombinedGroupId16819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged16820;
		public virtual void notifyDataSetChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged16820);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged16820);
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetInvalidated16821;
		public virtual void notifyDataSetInvalidated()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated16821);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated16821);
		}
		internal static global::MonoJavaBridge.MethodId _getChildType16822;
		public virtual int getChildType(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getChildType16822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getChildType16822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChildTypeCount16823;
		public virtual int getChildTypeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getChildTypeCount16823);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getChildTypeCount16823);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupType16824;
		public virtual int getGroupType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getGroupType16824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getGroupType16824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupTypeCount16825;
		public virtual int getGroupTypeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getGroupTypeCount16825);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getGroupTypeCount16825);
		}
		internal static global::MonoJavaBridge.MethodId _BaseExpandableListAdapter16826;
		public BaseExpandableListAdapter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._BaseExpandableListAdapter16826);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseExpandableListAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseExpandableListAdapter"));
			global::android.widget.BaseExpandableListAdapter._getGroupId16802 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupId", "(I)J");
			global::android.widget.BaseExpandableListAdapter._hasStableIds16803 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.BaseExpandableListAdapter._getGroupCount16804 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupCount", "()I");
			global::android.widget.BaseExpandableListAdapter._getChildrenCount16805 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.BaseExpandableListAdapter._getGroup16806 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter._getChild16807 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter._getChildId16808 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildId", "(II)J");
			global::android.widget.BaseExpandableListAdapter._getGroupView16809 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter._getChildView16810 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter._isChildSelectable16811 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "isChildSelectable", "(II)Z");
			global::android.widget.BaseExpandableListAdapter._isEmpty16812 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "isEmpty", "()Z");
			global::android.widget.BaseExpandableListAdapter._registerDataSetObserver16813 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver16814 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled16815 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.BaseExpandableListAdapter._onGroupExpanded16816 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupExpanded", "(I)V");
			global::android.widget.BaseExpandableListAdapter._onGroupCollapsed16817 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupCollapsed", "(I)V");
			global::android.widget.BaseExpandableListAdapter._getCombinedChildId16818 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedChildId", "(JJ)J");
			global::android.widget.BaseExpandableListAdapter._getCombinedGroupId16819 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedGroupId", "(J)J");
			global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged16820 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated16821 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetInvalidated", "()V");
			global::android.widget.BaseExpandableListAdapter._getChildType16822 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildType", "(II)I");
			global::android.widget.BaseExpandableListAdapter._getChildTypeCount16823 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildTypeCount", "()I");
			global::android.widget.BaseExpandableListAdapter._getGroupType16824 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupType", "(I)I");
			global::android.widget.BaseExpandableListAdapter._getGroupTypeCount16825 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupTypeCount", "()I");
			global::android.widget.BaseExpandableListAdapter._BaseExpandableListAdapter16826 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.BaseExpandableListAdapter))]
	internal sealed partial class BaseExpandableListAdapter_ : android.widget.BaseExpandableListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BaseExpandableListAdapter_()
		{
			InitJNI();
		}
		internal BaseExpandableListAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId16827;
		public override long getGroupId(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroupId16827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroupId16827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds16828;
		public override bool hasStableIds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._hasStableIds16828);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._hasStableIds16828);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupCount16829;
		public override int getGroupCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroupCount16829);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroupCount16829);
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCount16830;
		public override int getChildrenCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChildrenCount16830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChildrenCount16830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroup16831;
		public override global::java.lang.Object getGroup(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroup16831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroup16831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChild16832;
		public override global::java.lang.Object getChild(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChild16832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChild16832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChildId16833;
		public override long getChildId(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChildId16833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChildId16833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupView16834;
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroupView16834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroupView16834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getChildView16835;
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChildView16835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChildView16835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isChildSelectable16836;
		public override bool isChildSelectable(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._isChildSelectable16836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._isChildSelectable16836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseExpandableListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseExpandableListAdapter"));
			global::android.widget.BaseExpandableListAdapter_._getGroupId16827 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupId", "(I)J");
			global::android.widget.BaseExpandableListAdapter_._hasStableIds16828 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "hasStableIds", "()Z");
			global::android.widget.BaseExpandableListAdapter_._getGroupCount16829 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupCount", "()I");
			global::android.widget.BaseExpandableListAdapter_._getChildrenCount16830 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.BaseExpandableListAdapter_._getGroup16831 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter_._getChild16832 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter_._getChildId16833 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildId", "(II)J");
			global::android.widget.BaseExpandableListAdapter_._getGroupView16834 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter_._getChildView16835 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter_._isChildSelectable16836 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "isChildSelectable", "(II)Z");
		}
	}
}
