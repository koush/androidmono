namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class BaseExpandableListAdapter : java.lang.Object, ExpandableListAdapter, HeterogeneousExpandableList
	{
		internal static global::java.lang.Class staticClass;
		static BaseExpandableListAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.BaseExpandableListAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected BaseExpandableListAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroupId10657;
		public abstract long getGroupId(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10658;
		public abstract bool hasStableIds();
		internal static global::net.sf.jni4net.jni.MethodId _getGroupCount10659;
		public abstract int getGroupCount();
		internal static global::net.sf.jni4net.jni.MethodId _getChildrenCount10660;
		public abstract int getChildrenCount(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getGroup10661;
		public abstract global::java.lang.Object getGroup(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getChild10662;
		public abstract global::java.lang.Object getChild(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _getChildId10663;
		public abstract long getChildId(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _getGroupView10664;
		public abstract global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3);
		internal static global::net.sf.jni4net.jni.MethodId _getChildView10665;
		public abstract global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4);
		internal static global::net.sf.jni4net.jni.MethodId _isChildSelectable10666;
		public abstract bool isChildSelectable(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty10667;
		public virtual bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.BaseExpandableListAdapter._isEmpty10667);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._isEmpty10667);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver10668;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter._registerDataSetObserver10668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._registerDataSetObserver10668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver10669;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver10669, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver10669, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled10670;
		public virtual bool areAllItemsEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled10670);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled10670);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGroupExpanded10671;
		public virtual void onGroupExpanded(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter._onGroupExpanded10671, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._onGroupExpanded10671, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGroupCollapsed10672;
		public virtual void onGroupCollapsed(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter._onGroupCollapsed10672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._onGroupCollapsed10672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCombinedChildId10673;
		public virtual long getCombinedChildId(long arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.BaseExpandableListAdapter._getCombinedChildId10673, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getCombinedChildId10673, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCombinedGroupId10674;
		public virtual long getCombinedGroupId(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.BaseExpandableListAdapter._getCombinedGroupId10674, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getCombinedGroupId10674, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged10675;
		public virtual void notifyDataSetChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged10675);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged10675);
		}
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetInvalidated10676;
		public virtual void notifyDataSetInvalidated() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated10676);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated10676);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildType10677;
		public virtual int getChildType(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.BaseExpandableListAdapter._getChildType10677, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getChildType10677, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildTypeCount10678;
		public virtual int getChildTypeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.BaseExpandableListAdapter._getChildTypeCount10678);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getChildTypeCount10678);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroupType10679;
		public virtual int getGroupType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.BaseExpandableListAdapter._getGroupType10679, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getGroupType10679, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroupTypeCount10680;
		public virtual int getGroupTypeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.BaseExpandableListAdapter._getGroupTypeCount10680);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._getGroupTypeCount10680);
		}
		internal static global::net.sf.jni4net.jni.MethodId _BaseExpandableListAdapter10681;
		public BaseExpandableListAdapter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.BaseExpandableListAdapter.staticClass, global::android.widget.BaseExpandableListAdapter._BaseExpandableListAdapter10681, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.BaseExpandableListAdapter.staticClass = @__class;
			global::android.widget.BaseExpandableListAdapter._getGroupId10657 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupId", "(I)J");
			global::android.widget.BaseExpandableListAdapter._hasStableIds10658 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.BaseExpandableListAdapter._getGroupCount10659 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupCount", "()I");
			global::android.widget.BaseExpandableListAdapter._getChildrenCount10660 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.BaseExpandableListAdapter._getGroup10661 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter._getChild10662 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.BaseExpandableListAdapter._getChildId10663 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildId", "(II)J");
			global::android.widget.BaseExpandableListAdapter._getGroupView10664 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter._getChildView10665 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.BaseExpandableListAdapter._isChildSelectable10666 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "isChildSelectable", "(II)Z");
			global::android.widget.BaseExpandableListAdapter._isEmpty10667 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "isEmpty", "()Z");
			global::android.widget.BaseExpandableListAdapter._registerDataSetObserver10668 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver10669 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled10670 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "areAllItemsEnabled", "()Z");
			global::android.widget.BaseExpandableListAdapter._onGroupExpanded10671 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupExpanded", "(I)V");
			global::android.widget.BaseExpandableListAdapter._onGroupCollapsed10672 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupCollapsed", "(I)V");
			global::android.widget.BaseExpandableListAdapter._getCombinedChildId10673 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedChildId", "(JJ)J");
			global::android.widget.BaseExpandableListAdapter._getCombinedGroupId10674 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedGroupId", "(J)J");
			global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged10675 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated10676 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetInvalidated", "()V");
			global::android.widget.BaseExpandableListAdapter._getChildType10677 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildType", "(II)I");
			global::android.widget.BaseExpandableListAdapter._getChildTypeCount10678 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildTypeCount", "()I");
			global::android.widget.BaseExpandableListAdapter._getGroupType10679 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupType", "(I)I");
			global::android.widget.BaseExpandableListAdapter._getGroupTypeCount10680 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupTypeCount", "()I");
			global::android.widget.BaseExpandableListAdapter._BaseExpandableListAdapter10681 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "<init>", "()V");
		}
	}
}
