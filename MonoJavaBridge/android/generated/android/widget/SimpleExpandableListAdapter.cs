namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleExpandableListAdapter : android.widget.BaseExpandableListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SimpleExpandableListAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getGroupId17787;
		public override long getGroupId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupId", "(I)J", ref global::android.widget.SimpleExpandableListAdapter._getGroupId17787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasStableIds17788;
		public override bool hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "hasStableIds", "()Z", ref global::android.widget.SimpleExpandableListAdapter._hasStableIds17788);
		}
		public new int GroupCount
		{
			get
			{
				return getGroupCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGroupCount17789;
		public override int getGroupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupCount", "()I", ref global::android.widget.SimpleExpandableListAdapter._getGroupCount17789);
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCount17790;
		public override int getChildrenCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildrenCount", "(I)I", ref global::android.widget.SimpleExpandableListAdapter._getChildrenCount17790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroup17791;
		public override global::java.lang.Object getGroup(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;", ref global::android.widget.SimpleExpandableListAdapter._getGroup17791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChild17792;
		public override global::java.lang.Object getChild(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;", ref global::android.widget.SimpleExpandableListAdapter._getChild17792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getChildId17793;
		public override long getChildId(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildId", "(II)J", ref global::android.widget.SimpleExpandableListAdapter._getChildId17793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupView17794;
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SimpleExpandableListAdapter._getGroupView17794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getChildView17795;
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SimpleExpandableListAdapter._getChildView17795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isChildSelectable17796;
		public override bool isChildSelectable(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "isChildSelectable", "(II)Z", ref global::android.widget.SimpleExpandableListAdapter._isChildSelectable17796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newGroupView17797;
		public virtual global::android.view.View newGroupView(bool arg0, android.view.ViewGroup arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "newGroupView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SimpleExpandableListAdapter._newGroupView17797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _newChildView17798;
		public virtual global::android.view.View newChildView(bool arg0, android.view.ViewGroup arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "newChildView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SimpleExpandableListAdapter._newChildView17798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _SimpleExpandableListAdapter17799;
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, java.util.List arg6, int arg7, java.lang.String[] arg8, int[] arg9) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter17799.native == global::System.IntPtr.Zero)
				global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter17799 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;I[Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter17799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleExpandableListAdapter17800;
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, java.util.List arg6, int arg7, int arg8, java.lang.String[] arg9, int[] arg10) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter17800.native == global::System.IntPtr.Zero)
				global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter17800 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;II[Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter17800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleExpandableListAdapter17801;
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, java.lang.String[] arg3, int[] arg4, java.util.List arg5, int arg6, java.lang.String[] arg7, int[] arg8) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter17801.native == global::System.IntPtr.Zero)
				global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter17801 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[ILjava/util/List;I[Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._SimpleExpandableListAdapter17801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			Init(@__env, handle);
		}
		static SimpleExpandableListAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SimpleExpandableListAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SimpleExpandableListAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
