namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class BaseExpandableListAdapter : java.lang.Object, ExpandableListAdapter
	{ 
		internal static global::java.lang.Class staticClass; 
		static BaseExpandableListAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.BaseExpandableListAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected BaseExpandableListAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupId9246; 
		public abstract long getGroupId(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds9247; 
		public abstract bool hasStableIds(); 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupCount9248; 
		public abstract int getGroupCount(); 
		internal static global::net.sf.jni4net.jni.MethodId _getChildrenCount9249; 
		public abstract int getChildrenCount(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getGroup9250; 
		public abstract java.lang.Object getGroup(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getChild9251; 
		public abstract java.lang.Object getChild(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getChildId9252; 
		public abstract long getChildId(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupView9253; 
		public abstract android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _getChildView9254; 
		public abstract android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4); 
		internal static global::net.sf.jni4net.jni.MethodId _isChildSelectable9255; 
		public abstract bool isChildSelectable(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty9256; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseExpandableListAdapter)) 
				return @__env.CallBooleanMethod(this, _isEmpty9256); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.BaseExpandableListAdapter.staticClass, _isEmpty9256); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver9257; 
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseExpandableListAdapter)) 
				@__env.CallVoidMethod(this, _registerDataSetObserver9257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.BaseExpandableListAdapter.staticClass, _registerDataSetObserver9257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver9258; 
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseExpandableListAdapter)) 
				@__env.CallVoidMethod(this, _unregisterDataSetObserver9258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.BaseExpandableListAdapter.staticClass, _unregisterDataSetObserver9258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled9259; 
		public virtual bool areAllItemsEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseExpandableListAdapter)) 
				return @__env.CallBooleanMethod(this, _areAllItemsEnabled9259); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.BaseExpandableListAdapter.staticClass, _areAllItemsEnabled9259); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGroupExpanded9260; 
		public virtual void onGroupExpanded(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseExpandableListAdapter)) 
				@__env.CallVoidMethod(this, _onGroupExpanded9260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.BaseExpandableListAdapter.staticClass, _onGroupExpanded9260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGroupCollapsed9261; 
		public virtual void onGroupCollapsed(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseExpandableListAdapter)) 
				@__env.CallVoidMethod(this, _onGroupCollapsed9261, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.BaseExpandableListAdapter.staticClass, _onGroupCollapsed9261, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCombinedChildId9262; 
		public virtual long getCombinedChildId(long arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseExpandableListAdapter)) 
				return @__env.CallLongMethod(this, _getCombinedChildId9262, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.BaseExpandableListAdapter.staticClass, _getCombinedChildId9262, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCombinedGroupId9263; 
		public virtual long getCombinedGroupId(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseExpandableListAdapter)) 
				return @__env.CallLongMethod(this, _getCombinedGroupId9263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.BaseExpandableListAdapter.staticClass, _getCombinedGroupId9263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetChanged9264; 
		public virtual void notifyDataSetChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseExpandableListAdapter)) 
				@__env.CallVoidMethod(this, _notifyDataSetChanged9264); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.BaseExpandableListAdapter.staticClass, _notifyDataSetChanged9264); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyDataSetInvalidated9265; 
		public virtual void notifyDataSetInvalidated() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.BaseExpandableListAdapter)) 
				@__env.CallVoidMethod(this, _notifyDataSetInvalidated9265); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.BaseExpandableListAdapter.staticClass, _notifyDataSetInvalidated9265); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BaseExpandableListAdapter9266; 
		public BaseExpandableListAdapter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.BaseExpandableListAdapter.staticClass, _BaseExpandableListAdapter9266, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.BaseExpandableListAdapter.staticClass = @__class; 
			global::android.widget.BaseExpandableListAdapter._getGroupId9246 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupId", "(I)J"); 
			global::android.widget.BaseExpandableListAdapter._hasStableIds9247 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "hasStableIds", "()Z"); 
			global::android.widget.BaseExpandableListAdapter._getGroupCount9248 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupCount", "()I"); 
			global::android.widget.BaseExpandableListAdapter._getChildrenCount9249 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildrenCount", "(I)I"); 
			global::android.widget.BaseExpandableListAdapter._getGroup9250 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;"); 
			global::android.widget.BaseExpandableListAdapter._getChild9251 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;"); 
			global::android.widget.BaseExpandableListAdapter._getChildId9252 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildId", "(II)J"); 
			global::android.widget.BaseExpandableListAdapter._getGroupView9253 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.BaseExpandableListAdapter._getChildView9254 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.BaseExpandableListAdapter._isChildSelectable9255 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "isChildSelectable", "(II)Z"); 
			global::android.widget.BaseExpandableListAdapter._isEmpty9256 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "isEmpty", "()Z"); 
			global::android.widget.BaseExpandableListAdapter._registerDataSetObserver9257 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.BaseExpandableListAdapter._unregisterDataSetObserver9258 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.BaseExpandableListAdapter._areAllItemsEnabled9259 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "areAllItemsEnabled", "()Z"); 
			global::android.widget.BaseExpandableListAdapter._onGroupExpanded9260 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupExpanded", "(I)V"); 
			global::android.widget.BaseExpandableListAdapter._onGroupCollapsed9261 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "onGroupCollapsed", "(I)V"); 
			global::android.widget.BaseExpandableListAdapter._getCombinedChildId9262 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedChildId", "(JJ)J"); 
			global::android.widget.BaseExpandableListAdapter._getCombinedGroupId9263 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "getCombinedGroupId", "(J)J"); 
			global::android.widget.BaseExpandableListAdapter._notifyDataSetChanged9264 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetChanged", "()V"); 
			global::android.widget.BaseExpandableListAdapter._notifyDataSetInvalidated9265 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "notifyDataSetInvalidated", "()V"); 
			global::android.widget.BaseExpandableListAdapter._BaseExpandableListAdapter9266 = @__env.GetMethodID(global::android.widget.BaseExpandableListAdapter.staticClass, "<init>", "()V"); 
		} 
	} 
} 
