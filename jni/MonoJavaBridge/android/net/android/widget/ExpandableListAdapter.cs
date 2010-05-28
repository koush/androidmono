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

	public partial class ExpandableListAdapter_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __ExpandableListAdapter.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __ExpandableListAdapter : java.lang.Object, ExpandableListAdapter
	{ 
		internal static global::java.lang.Class staticClass; 
		static __ExpandableListAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.__ExpandableListAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.__ExpandableListAdapter(@__env); 
			} 
		} 
		internal __ExpandableListAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty10132; 
		 bool android.widget.ExpandableListAdapter.isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return @__env.CallBooleanMethod(this, global::android.widget.__ExpandableListAdapter._isEmpty10132); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._isEmpty10132); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver10133; 
		 void android.widget.ExpandableListAdapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.__ExpandableListAdapter._registerDataSetObserver10133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._registerDataSetObserver10133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver10134; 
		 void android.widget.ExpandableListAdapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.__ExpandableListAdapter._unregisterDataSetObserver10134, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._unregisterDataSetObserver10134, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupId10135; 
		 long android.widget.ExpandableListAdapter.getGroupId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return @__env.CallLongMethod(this, global::android.widget.__ExpandableListAdapter._getGroupId10135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getGroupId10135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled10136; 
		 bool android.widget.ExpandableListAdapter.areAllItemsEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return @__env.CallBooleanMethod(this, global::android.widget.__ExpandableListAdapter._areAllItemsEnabled10136); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._areAllItemsEnabled10136); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10137; 
		 bool android.widget.ExpandableListAdapter.hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return @__env.CallBooleanMethod(this, global::android.widget.__ExpandableListAdapter._hasStableIds10137); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._hasStableIds10137); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupCount10138; 
		 int android.widget.ExpandableListAdapter.getGroupCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return @__env.CallIntMethod(this, global::android.widget.__ExpandableListAdapter._getGroupCount10138); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getGroupCount10138); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildrenCount10139; 
		 int android.widget.ExpandableListAdapter.getChildrenCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return @__env.CallIntMethod(this, global::android.widget.__ExpandableListAdapter._getChildrenCount10139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getChildrenCount10139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroup10140; 
		 global::java.lang.Object android.widget.ExpandableListAdapter.getGroup(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter._getGroup10140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getGroup10140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChild10141; 
		 global::java.lang.Object android.widget.ExpandableListAdapter.getChild(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter._getChild10141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getChild10141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildId10142; 
		 long android.widget.ExpandableListAdapter.getChildId(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return @__env.CallLongMethod(this, global::android.widget.__ExpandableListAdapter._getChildId10142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getChildId10142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupView10143; 
		 global::android.view.View android.widget.ExpandableListAdapter.getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter._getGroupView10143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getGroupView10143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildView10144; 
		 global::android.view.View android.widget.ExpandableListAdapter.getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter._getChildView10144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getChildView10144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChildSelectable10145; 
		 bool android.widget.ExpandableListAdapter.isChildSelectable(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return @__env.CallBooleanMethod(this, global::android.widget.__ExpandableListAdapter._isChildSelectable10145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._isChildSelectable10145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGroupExpanded10146; 
		 void android.widget.ExpandableListAdapter.onGroupExpanded(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.__ExpandableListAdapter._onGroupExpanded10146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._onGroupExpanded10146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGroupCollapsed10147; 
		 void android.widget.ExpandableListAdapter.onGroupCollapsed(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				@__env.CallVoidMethod(this, global::android.widget.__ExpandableListAdapter._onGroupCollapsed10147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._onGroupCollapsed10147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCombinedChildId10148; 
		 long android.widget.ExpandableListAdapter.getCombinedChildId(long arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return @__env.CallLongMethod(this, global::android.widget.__ExpandableListAdapter._getCombinedChildId10148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getCombinedChildId10148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCombinedGroupId10149; 
		 long android.widget.ExpandableListAdapter.getCombinedGroupId(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__ExpandableListAdapter)) 
				return @__env.CallLongMethod(this, global::android.widget.__ExpandableListAdapter._getCombinedGroupId10149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__ExpandableListAdapter.staticClass, global::android.widget.__ExpandableListAdapter._getCombinedGroupId10149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.__ExpandableListAdapter.staticClass = @__class; 
			global::android.widget.__ExpandableListAdapter._isEmpty10132 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.isEmpty", "()Z"); 
			global::android.widget.__ExpandableListAdapter._registerDataSetObserver10133 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.__ExpandableListAdapter._unregisterDataSetObserver10134 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.__ExpandableListAdapter._getGroupId10135 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getGroupId", "(I)J"); 
			global::android.widget.__ExpandableListAdapter._areAllItemsEnabled10136 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.areAllItemsEnabled", "()Z"); 
			global::android.widget.__ExpandableListAdapter._hasStableIds10137 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.hasStableIds", "()Z"); 
			global::android.widget.__ExpandableListAdapter._getGroupCount10138 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getGroupCount", "()I"); 
			global::android.widget.__ExpandableListAdapter._getChildrenCount10139 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getChildrenCount", "(I)I"); 
			global::android.widget.__ExpandableListAdapter._getGroup10140 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getGroup", "(I)Ljava/lang/Object;"); 
			global::android.widget.__ExpandableListAdapter._getChild10141 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getChild", "(II)Ljava/lang/Object;"); 
			global::android.widget.__ExpandableListAdapter._getChildId10142 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getChildId", "(II)J"); 
			global::android.widget.__ExpandableListAdapter._getGroupView10143 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.__ExpandableListAdapter._getChildView10144 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.__ExpandableListAdapter._isChildSelectable10145 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.isChildSelectable", "(II)Z"); 
			global::android.widget.__ExpandableListAdapter._onGroupExpanded10146 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.onGroupExpanded", "(I)V"); 
			global::android.widget.__ExpandableListAdapter._onGroupCollapsed10147 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.onGroupCollapsed", "(I)V"); 
			global::android.widget.__ExpandableListAdapter._getCombinedChildId10148 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getCombinedChildId", "(JJ)J"); 
			global::android.widget.__ExpandableListAdapter._getCombinedGroupId10149 = @__env.GetMethodID(global::android.widget.__ExpandableListAdapter.staticClass, "android.widget.ExpandableListAdapter.getCombinedGroupId", "(J)J"); 
		} 
	} 
} 
