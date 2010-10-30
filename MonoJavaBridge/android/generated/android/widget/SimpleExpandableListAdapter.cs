namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleExpandableListAdapter : android.widget.BaseExpandableListAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SimpleExpandableListAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override long getGroupId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupId", "(I)J", ref global::android.widget.SimpleExpandableListAdapter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool hasStableIds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "hasStableIds", "()Z", ref global::android.widget.SimpleExpandableListAdapter._m1);
		}
		public new int GroupCount
		{
			get
			{
				return getGroupCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int getGroupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupCount", "()I", ref global::android.widget.SimpleExpandableListAdapter._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getChildrenCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildrenCount", "(I)I", ref global::android.widget.SimpleExpandableListAdapter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.Object getGroup(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroup", "(I)Ljava/lang/Object;", ref global::android.widget.SimpleExpandableListAdapter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.lang.Object getChild(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getChild", "(II)Ljava/lang/Object;", ref global::android.widget.SimpleExpandableListAdapter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override long getChildId(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildId", "(II)J", ref global::android.widget.SimpleExpandableListAdapter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::android.view.View getGroupView(int arg0, bool arg1, android.view.View arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SimpleExpandableListAdapter._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::android.view.View getChildView(int arg0, int arg1, bool arg2, android.view.View arg3, android.view.ViewGroup arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SimpleExpandableListAdapter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool isChildSelectable(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "isChildSelectable", "(II)Z", ref global::android.widget.SimpleExpandableListAdapter._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.view.View newGroupView(bool arg0, android.view.ViewGroup arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "newGroupView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SimpleExpandableListAdapter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.view.View newChildView(bool arg0, android.view.ViewGroup arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SimpleExpandableListAdapter.staticClass, "newChildView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.SimpleExpandableListAdapter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, java.util.List arg6, int arg7, java.lang.String[] arg8, int[] arg9) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SimpleExpandableListAdapter._m12.native == global::System.IntPtr.Zero)
				global::android.widget.SimpleExpandableListAdapter._m12 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;I[Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, int arg3, java.lang.String[] arg4, int[] arg5, java.util.List arg6, int arg7, int arg8, java.lang.String[] arg9, int[] arg10) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SimpleExpandableListAdapter._m13.native == global::System.IntPtr.Zero)
				global::android.widget.SimpleExpandableListAdapter._m13 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;II[Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public SimpleExpandableListAdapter(android.content.Context arg0, java.util.List arg1, int arg2, java.lang.String[] arg3, int[] arg4, java.util.List arg5, int arg6, java.lang.String[] arg7, int[] arg8) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SimpleExpandableListAdapter._m14.native == global::System.IntPtr.Zero)
				global::android.widget.SimpleExpandableListAdapter._m14 = @__env.GetMethodIDNoThrow(global::android.widget.SimpleExpandableListAdapter.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[ILjava/util/List;I[Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SimpleExpandableListAdapter.staticClass, global::android.widget.SimpleExpandableListAdapter._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
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
