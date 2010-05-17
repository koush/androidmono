namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SimpleExpandableListAdapter : android.widget.BaseExpandableListAdapter
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SimpleExpandableListAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.SimpleExpandableListAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.SimpleExpandableListAdapter(@__env); 
			} 
		} 
		protected SimpleExpandableListAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupId10061; 
		public override long getGroupId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return @__env.CallLongMethod(this, _getGroupId10061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.SimpleExpandableListAdapter.staticClass, _getGroupId10061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10062; 
		public override bool hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return @__env.CallBooleanMethod(this, _hasStableIds10062); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.SimpleExpandableListAdapter.staticClass, _hasStableIds10062); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupCount10063; 
		public override int getGroupCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return @__env.CallIntMethod(this, _getGroupCount10063); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.SimpleExpandableListAdapter.staticClass, _getGroupCount10063); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildrenCount10064; 
		public override int getChildrenCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return @__env.CallIntMethod(this, _getChildrenCount10064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.SimpleExpandableListAdapter.staticClass, _getChildrenCount10064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroup10065; 
		public override java.lang.Object getGroup(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getGroup10065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleExpandableListAdapter.staticClass, _getGroup10065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChild10066; 
		public override java.lang.Object getChild(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getChild10066, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleExpandableListAdapter.staticClass, _getChild10066, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildId10067; 
		public override long getChildId(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return @__env.CallLongMethod(this, _getChildId10067, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.SimpleExpandableListAdapter.staticClass, _getChildId10067, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGroupView10068; 
		public override android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getGroupView10068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleExpandableListAdapter.staticClass, _getGroupView10068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildView10069; 
		public override android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getChildView10069, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleExpandableListAdapter.staticClass, _getChildView10069, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChildSelectable10070; 
		public override bool isChildSelectable(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return @__env.CallBooleanMethod(this, _isChildSelectable10070, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.SimpleExpandableListAdapter.staticClass, _isChildSelectable10070, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newGroupView10071; 
		public virtual android.view.View newGroupView(bool arg0, android.view.ViewGroup arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _newGroupView10071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleExpandableListAdapter.staticClass, _newGroupView10071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newChildView10072; 
		public virtual android.view.View newChildView(bool arg0, android.view.ViewGroup arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SimpleExpandableListAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _newChildView10072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SimpleExpandableListAdapter.staticClass, _newChildView10072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SimpleExpandableListAdapter10073; 
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, java.util.List arg6, int arg7, java.lang.String[] arg8, int[] arg9)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, _SimpleExpandableListAdapter10073, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg8), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg9)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SimpleExpandableListAdapter10074; 
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, java.util.List arg6, int arg7, int arg8, java.lang.String[] arg9, int[] arg10)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, _SimpleExpandableListAdapter10074, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg9), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg10)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SimpleExpandableListAdapter10075; 
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, java.lang.String[] arg3, int[] arg4, java.util.List arg5, int arg6, java.lang.String[] arg7, int[] arg8)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, _SimpleExpandableListAdapter10075, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg8)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.SimpleExpandableListAdapter.staticClass = @__class; 
			global::android.widget.SimpleExpandableListAdapter._getGroupId10061 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupId", "(I)J"); 
			global::android.widget.SimpleExpandableListAdapter._hasStableIds10062 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "hasStableIds", "()Z"); 
			global::android.widget.SimpleExpandableListAdapter._getGroupCount10063 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupCount", "()I"); 
			global::android.widget.SimpleExpandableListAdapter._getChildrenCount10064 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildrenCount", "(I)I"); 
			global::android.widget.SimpleExpandableListAdapter._getGroup10065 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;"); 
			global::android.widget.SimpleExpandableListAdapter._getChild10066 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;"); 
			global::android.widget.SimpleExpandableListAdapter._getChildId10067 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildId", "(II)J"); 
			global::android.widget.SimpleExpandableListAdapter._getGroupView10068 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.SimpleExpandableListAdapter._getChildView10069 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.SimpleExpandableListAdapter._isChildSelectable10070 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "isChildSelectable", "(II)Z"); 
			global::android.widget.SimpleExpandableListAdapter._newGroupView10071 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "newGroupView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.SimpleExpandableListAdapter._newChildView10072 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "newChildView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter10073 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;I[Ljava/lang/String;[I)V"); 
			global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter10074 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;II[Ljava/lang/String;[I)V"); 
			global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter10075 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[ILjava/util/List;I[Ljava/lang/String;[I)V"); 
		} 
	} 
} 
