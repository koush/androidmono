namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.ResourceCursorTreeAdapter_))]
	public abstract partial class ResourceCursorTreeAdapter : android.widget.ResourceCursorTreeAdapterScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResourceCursorTreeAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ResourceCursorTreeAdapter.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ResourceCursorTreeAdapter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ResourceCursorTreeAdapter.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ResourceCursorTreeAdapter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ResourceCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ResourceCursorTreeAdapter._m2.native == global::System.IntPtr.Zero)
				global::android.widget.ResourceCursorTreeAdapter._m2 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;IIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ResourceCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ResourceCursorTreeAdapter._m3.native == global::System.IntPtr.Zero)
				global::android.widget.ResourceCursorTreeAdapter._m3 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ResourceCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ResourceCursorTreeAdapter._m4.native == global::System.IntPtr.Zero)
				global::android.widget.ResourceCursorTreeAdapter._m4 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static ResourceCursorTreeAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorTreeAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorTreeAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ResourceCursorTreeAdapter))]
	internal sealed partial class ResourceCursorTreeAdapter_ : android.widget.ResourceCursorTreeAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResourceCursorTreeAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.widget.ResourceCursorTreeAdapter_.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;", ref global::android.widget.ResourceCursorTreeAdapter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ResourceCursorTreeAdapter_.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", ref global::android.widget.ResourceCursorTreeAdapter_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ResourceCursorTreeAdapter_.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", ref global::android.widget.ResourceCursorTreeAdapter_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static ResourceCursorTreeAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorTreeAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorTreeAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
