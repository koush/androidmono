namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SimpleExpandableListAdapter : android.widget.BaseExpandableListAdapter
	{
		internal new static global::java.lang.Class staticClass;
		static SimpleExpandableListAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SimpleExpandableListAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _getGroupId11558;
		public override long getGroupId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.SimpleExpandableListAdapter._getGroupId11558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._getGroupId11558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds11559;
		public override bool hasStableIds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.SimpleExpandableListAdapter._hasStableIds11559);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._hasStableIds11559);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroupCount11560;
		public override int getGroupCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.SimpleExpandableListAdapter._getGroupCount11560);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._getGroupCount11560);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildrenCount11561;
		public override int getChildrenCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.SimpleExpandableListAdapter._getChildrenCount11561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._getChildrenCount11561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroup11562;
		public override global::java.lang.Object getGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter._getGroup11562, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._getGroup11562, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChild11563;
		public override global::java.lang.Object getChild(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter._getChild11563, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._getChild11563, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildId11564;
		public override long getChildId(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.SimpleExpandableListAdapter._getChildId11564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._getChildId11564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGroupView11565;
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter._getGroupView11565, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._getGroupView11565, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildView11566;
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter._getChildView11566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._getChildView11566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChildSelectable11567;
		public override bool isChildSelectable(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.SimpleExpandableListAdapter._isChildSelectable11567, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._isChildSelectable11567, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newGroupView11568;
		public virtual global::android.view.View newGroupView(bool arg0, android.view.ViewGroup arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter._newGroupView11568, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._newGroupView11568, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newChildView11569;
		public virtual global::android.view.View newChildView(bool arg0, android.view.ViewGroup arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter._newChildView11569, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._newChildView11569, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SimpleExpandableListAdapter11570;
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, java.util.List arg6, int arg7, java.lang.String[] arg8, int[] arg9)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter11570, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg8), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg9));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SimpleExpandableListAdapter11571;
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, java.util.List arg6, int arg7, int arg8, java.lang.String[] arg9, int[] arg10)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter11571, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg9), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg10));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SimpleExpandableListAdapter11572;
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, java.lang.String[] arg3, int[] arg4, java.util.List arg5, int arg6, java.lang.String[] arg7, int[] arg8)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter11572, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg8));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.SimpleExpandableListAdapter.staticClass = @__class;
			global::android.widget.SimpleExpandableListAdapter._getGroupId11558 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupId", "(I)J");
			global::android.widget.SimpleExpandableListAdapter._hasStableIds11559 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "hasStableIds", "()Z");
			global::android.widget.SimpleExpandableListAdapter._getGroupCount11560 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupCount", "()I");
			global::android.widget.SimpleExpandableListAdapter._getChildrenCount11561 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildrenCount", "(I)I");
			global::android.widget.SimpleExpandableListAdapter._getGroup11562 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;");
			global::android.widget.SimpleExpandableListAdapter._getChild11563 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;");
			global::android.widget.SimpleExpandableListAdapter._getChildId11564 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildId", "(II)J");
			global::android.widget.SimpleExpandableListAdapter._getGroupView11565 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SimpleExpandableListAdapter._getChildView11566 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SimpleExpandableListAdapter._isChildSelectable11567 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "isChildSelectable", "(II)Z");
			global::android.widget.SimpleExpandableListAdapter._newGroupView11568 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "newGroupView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SimpleExpandableListAdapter._newChildView11569 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "newChildView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter11570 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;I[Ljava/lang/String;[I)V");
			global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter11571 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;II[Ljava/lang/String;[I)V");
			global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter11572 = @__env.GetMethodID(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[ILjava/util/List;I[Ljava/lang/String;[I)V");
		}
	}
}
