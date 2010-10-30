namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.ResourceCursorAdapter_))]
	public abstract partial class ResourceCursorAdapter : android.widget.CursorAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResourceCursorAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setDropDownViewResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ResourceCursorAdapter.staticClass, "setDropDownViewResource", "(I)V", ref global::android.widget.ResourceCursorAdapter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ResourceCursorAdapter.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ResourceCursorAdapter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::android.view.View newDropDownView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ResourceCursorAdapter.staticClass, "newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ResourceCursorAdapter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setViewResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ResourceCursorAdapter.staticClass, "setViewResource", "(I)V", ref global::android.widget.ResourceCursorAdapter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ResourceCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ResourceCursorAdapter._m4.native == global::System.IntPtr.Zero)
				global::android.widget.ResourceCursorAdapter._m4 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ResourceCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ResourceCursorAdapter._m5.native == global::System.IntPtr.Zero)
				global::android.widget.ResourceCursorAdapter._m5 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static ResourceCursorAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ResourceCursorAdapter))]
	internal sealed partial class ResourceCursorAdapter_ : android.widget.ResourceCursorAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResourceCursorAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ResourceCursorAdapter_.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V", ref global::android.widget.ResourceCursorAdapter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static ResourceCursorAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorAdapter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
