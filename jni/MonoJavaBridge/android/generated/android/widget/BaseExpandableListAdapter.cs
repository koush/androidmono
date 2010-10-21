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
		internal static global::MonoJavaBridge.MethodId _getGroupId16708;
		public abstract long getGroupId(int arg0);
		internal static global::MonoJavaBridge.MethodId _hasStableIds16709;
		public abstract bool hasStableIds();
		internal static global::MonoJavaBridge.MethodId _getGroupCount16710;
		public abstract int getGroupCount();
		internal static global::MonoJavaBridge.MethodId _getChildrenCount16711;
		public abstract int getChildrenCount(int arg0);
		internal static global::MonoJavaBridge.MethodId _getGroup16712;
		public abstract global::java.lang.Object getGroup(int arg0);
		internal static global::MonoJavaBridge.MethodId _getChild16713;
		public abstract global::java.lang.Object getChild(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getChildId16714;
		public abstract long getChildId(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getGroupView16715;
		public abstract global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3);
		internal static global::MonoJavaBridge.MethodId _getChildView16716;
		public abstract global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4);
		internal static global::MonoJavaBridge.MethodId _isChildSelectable16717;
		public abstract bool isChildSelectable(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isEmpty16718;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._isEmpty16718);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._isEmpty16718);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver16719;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._registerDataSetObserver16719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._registerDataSetObserver16719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver16720;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver16720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver16720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled16721;
		public virtual bool areAllItemsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled16721);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled16721);
		}
		internal static global::MonoJavaBridge.MethodId _onGroupExpanded16722;
		public virtual void onGroupExpanded(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._onGroupExpanded16722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._onGroupExpanded16722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupCollapsed16723;
		public virtual void onGroupCollapsed(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._onGroupCollapsed16723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._onGroupCollapsed16723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCombinedChildId16724;
		public virtual long getCombinedChildId(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getCombinedChildId16724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getCombinedChildId16724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCombinedGroupId16725;
		public virtual long getCombinedGroupId(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getCombinedGroupId16725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getCombinedGroupId16725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged16726;
		public virtual void notifyDataSetChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged16726);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged16726);
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetInvalidated16727;
		public virtual void notifyDataSetInvalidated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated16727);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated16727);
		}
		internal static global::MonoJavaBridge.MethodId _getChildType16728;
		public virtual int getChildType(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getChildType16728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getChildType16728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChildTypeCount16729;
		public virtual int getChildTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getChildTypeCount16729);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getChildTypeCount16729);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupType16730;
		public virtual int getGroupType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getGroupType16730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getGroupType16730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupTypeCount16731;
		public virtual int getGroupTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getGroupTypeCount16731);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getGroupTypeCount16731);
		}
		internal static global::MonoJavaBridge.MethodId _BaseExpandableListAdapter16732;
		public BaseExpandableListAdapter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._BaseExpandableListAdapter16732);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseExpandableListAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseExpandableListAdapter"));
			global::android.widget.BaseExpandableListAdapter._getGroupId16708 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupId", "(I)J");
			global::android.widget.BaseExpandableListAdapter._hasStableIds16709 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.BaseExpandableListAdapter._getGroupCount16710 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupCount", "()I");
			global::android.widget.BaseExpandableListAdapter._getChildrenCount16711 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.BaseExpandableListAdapter._getGroup16712 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter._getChild16713 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter._getChildId16714 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildId", "(II)J");
			global::android.widget.BaseExpandableListAdapter._getGroupView16715 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter._getChildView16716 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter._isChildSelectable16717 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "isChildSelectable", "(II)Z");
			global::android.widget.BaseExpandableListAdapter._isEmpty16718 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "isEmpty", "()Z");
			global::android.widget.BaseExpandableListAdapter._registerDataSetObserver16719 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver16720 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled16721 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.BaseExpandableListAdapter._onGroupExpanded16722 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupExpanded", "(I)V");
			global::android.widget.BaseExpandableListAdapter._onGroupCollapsed16723 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupCollapsed", "(I)V");
			global::android.widget.BaseExpandableListAdapter._getCombinedChildId16724 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedChildId", "(JJ)J");
			global::android.widget.BaseExpandableListAdapter._getCombinedGroupId16725 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedGroupId", "(J)J");
			global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged16726 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated16727 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetInvalidated", "()V");
			global::android.widget.BaseExpandableListAdapter._getChildType16728 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildType", "(II)I");
			global::android.widget.BaseExpandableListAdapter._getChildTypeCount16729 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildTypeCount", "()I");
			global::android.widget.BaseExpandableListAdapter._getGroupType16730 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupType", "(I)I");
			global::android.widget.BaseExpandableListAdapter._getGroupTypeCount16731 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupTypeCount", "()I");
			global::android.widget.BaseExpandableListAdapter._BaseExpandableListAdapter16732 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.BaseExpandableListAdapter))]
	public sealed partial class BaseExpandableListAdapter_ : android.widget.BaseExpandableListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BaseExpandableListAdapter_()
		{
			InitJNI();
		}
		internal BaseExpandableListAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId16733;
		public override long getGroupId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroupId16733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroupId16733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds16734;
		public override bool hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._hasStableIds16734);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._hasStableIds16734);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupCount16735;
		public override int getGroupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroupCount16735);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroupCount16735);
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCount16736;
		public override int getChildrenCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChildrenCount16736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChildrenCount16736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroup16737;
		public override global::java.lang.Object getGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroup16737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroup16737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChild16738;
		public override global::java.lang.Object getChild(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChild16738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChild16738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChildId16739;
		public override long getChildId(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChildId16739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChildId16739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupView16740;
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroupView16740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroupView16740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getChildView16741;
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChildView16741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChildView16741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isChildSelectable16742;
		public override bool isChildSelectable(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._isChildSelectable16742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._isChildSelectable16742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseExpandableListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseExpandableListAdapter"));
			global::android.widget.BaseExpandableListAdapter_._getGroupId16733 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupId", "(I)J");
			global::android.widget.BaseExpandableListAdapter_._hasStableIds16734 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "hasStableIds", "()Z");
			global::android.widget.BaseExpandableListAdapter_._getGroupCount16735 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupCount", "()I");
			global::android.widget.BaseExpandableListAdapter_._getChildrenCount16736 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.BaseExpandableListAdapter_._getGroup16737 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter_._getChild16738 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter_._getChildId16739 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildId", "(II)J");
			global::android.widget.BaseExpandableListAdapter_._getGroupView16740 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter_._getChildView16741 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter_._isChildSelectable16742 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "isChildSelectable", "(II)Z");
		}
	}
}
