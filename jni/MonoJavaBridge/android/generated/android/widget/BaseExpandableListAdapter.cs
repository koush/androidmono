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
		internal static global::MonoJavaBridge.MethodId _getGroupId11563;
		public abstract long getGroupId(int arg0);
		internal static global::MonoJavaBridge.MethodId _hasStableIds11564;
		public abstract bool hasStableIds();
		internal static global::MonoJavaBridge.MethodId _getGroupCount11565;
		public abstract int getGroupCount();
		internal static global::MonoJavaBridge.MethodId _getChildrenCount11566;
		public abstract int getChildrenCount(int arg0);
		internal static global::MonoJavaBridge.MethodId _getGroup11567;
		public abstract global::java.lang.Object getGroup(int arg0);
		internal static global::MonoJavaBridge.MethodId _getChild11568;
		public abstract global::java.lang.Object getChild(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getChildId11569;
		public abstract long getChildId(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getGroupView11570;
		public abstract global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3);
		internal static global::MonoJavaBridge.MethodId _getChildView11571;
		public abstract global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4);
		internal static global::MonoJavaBridge.MethodId _isChildSelectable11572;
		public abstract bool isChildSelectable(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isEmpty11573;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._isEmpty11573);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._isEmpty11573);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver11574;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._registerDataSetObserver11574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._registerDataSetObserver11574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver11575;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver11575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver11575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _areAllItemsEnabled11576;
		public virtual bool areAllItemsEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled11576);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled11576);
		}
		internal static global::MonoJavaBridge.MethodId _onGroupExpanded11577;
		public virtual void onGroupExpanded(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._onGroupExpanded11577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._onGroupExpanded11577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onGroupCollapsed11578;
		public virtual void onGroupCollapsed(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._onGroupCollapsed11578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._onGroupCollapsed11578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCombinedChildId11579;
		public virtual long getCombinedChildId(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getCombinedChildId11579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getCombinedChildId11579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCombinedGroupId11580;
		public virtual long getCombinedGroupId(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getCombinedGroupId11580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getCombinedGroupId11580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged11581;
		public virtual void notifyDataSetChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged11581);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged11581);
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetInvalidated11582;
		public virtual void notifyDataSetInvalidated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated11582);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated11582);
		}
		internal static global::MonoJavaBridge.MethodId _getChildType11583;
		public virtual int getChildType(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getChildType11583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getChildType11583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChildTypeCount11584;
		public virtual int getChildTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getChildTypeCount11584);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getChildTypeCount11584);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupType11585;
		public virtual int getGroupType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getGroupType11585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getGroupType11585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupTypeCount11586;
		public virtual int getGroupTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter._getGroupTypeCount11586);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getGroupTypeCount11586);
		}
		internal static global::MonoJavaBridge.MethodId _BaseExpandableListAdapter11587;
		public BaseExpandableListAdapter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._BaseExpandableListAdapter11587);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseExpandableListAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseExpandableListAdapter"));
			global::android.widget.BaseExpandableListAdapter._getGroupId11563 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupId", "(I)J");
			global::android.widget.BaseExpandableListAdapter._hasStableIds11564 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.BaseExpandableListAdapter._getGroupCount11565 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupCount", "()I");
			global::android.widget.BaseExpandableListAdapter._getChildrenCount11566 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.BaseExpandableListAdapter._getGroup11567 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter._getChild11568 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter._getChildId11569 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildId", "(II)J");
			global::android.widget.BaseExpandableListAdapter._getGroupView11570 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter._getChildView11571 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter._isChildSelectable11572 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "isChildSelectable", "(II)Z");
			global::android.widget.BaseExpandableListAdapter._isEmpty11573 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "isEmpty", "()Z");
			global::android.widget.BaseExpandableListAdapter._registerDataSetObserver11574 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver11575 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled11576 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.BaseExpandableListAdapter._onGroupExpanded11577 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupExpanded", "(I)V");
			global::android.widget.BaseExpandableListAdapter._onGroupCollapsed11578 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupCollapsed", "(I)V");
			global::android.widget.BaseExpandableListAdapter._getCombinedChildId11579 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedChildId", "(JJ)J");
			global::android.widget.BaseExpandableListAdapter._getCombinedGroupId11580 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedGroupId", "(J)J");
			global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged11581 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated11582 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetInvalidated", "()V");
			global::android.widget.BaseExpandableListAdapter._getChildType11583 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildType", "(II)I");
			global::android.widget.BaseExpandableListAdapter._getChildTypeCount11584 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildTypeCount", "()I");
			global::android.widget.BaseExpandableListAdapter._getGroupType11585 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupType", "(I)I");
			global::android.widget.BaseExpandableListAdapter._getGroupTypeCount11586 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupTypeCount", "()I");
			global::android.widget.BaseExpandableListAdapter._BaseExpandableListAdapter11587 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _getGroupId11588;
		public override long getGroupId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroupId11588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroupId11588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds11589;
		public override bool hasStableIds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._hasStableIds11589);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._hasStableIds11589);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupCount11590;
		public override int getGroupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroupCount11590);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroupCount11590);
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCount11591;
		public override int getChildrenCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChildrenCount11591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChildrenCount11591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroup11592;
		public override global::java.lang.Object getGroup(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroup11592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroup11592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChild11593;
		public override global::java.lang.Object getChild(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChild11593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChild11593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChildId11594;
		public override long getChildId(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChildId11594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChildId11594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupView11595;
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getGroupView11595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getGroupView11595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getChildView11596;
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._getChildView11596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._getChildView11596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isChildSelectable11597;
		public override bool isChildSelectable(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_._isChildSelectable11597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.BaseExpandableListAdapter_.staticClass, global::android.widget.BaseExpandableListAdapter_._isChildSelectable11597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.BaseExpandableListAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/BaseExpandableListAdapter"));
			global::android.widget.BaseExpandableListAdapter_._getGroupId11588 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupId", "(I)J");
			global::android.widget.BaseExpandableListAdapter_._hasStableIds11589 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "hasStableIds", "()Z");
			global::android.widget.BaseExpandableListAdapter_._getGroupCount11590 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupCount", "()I");
			global::android.widget.BaseExpandableListAdapter_._getChildrenCount11591 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.BaseExpandableListAdapter_._getGroup11592 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter_._getChild11593 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter_._getChildId11594 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildId", "(II)J");
			global::android.widget.BaseExpandableListAdapter_._getGroupView11595 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter_._getChildView11596 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter_._isChildSelectable11597 = @__env.GetMethodIDNoThrow(global::android.widget.BaseExpandableListAdapter_.staticClass, "isChildSelectable", "(II)Z");
		}
	}
}
