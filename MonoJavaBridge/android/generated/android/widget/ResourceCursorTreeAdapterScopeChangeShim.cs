namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.ResourceCursorTreeAdapterScopeChangeShim_))]
	public abstract partial class ResourceCursorTreeAdapterScopeChangeShim : android.widget.CursorTreeAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResourceCursorTreeAdapterScopeChangeShim(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ResourceCursorTreeAdapterScopeChangeShim._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ResourceCursorTreeAdapterScopeChangeShim._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.view.View;
		}
		static ResourceCursorTreeAdapterScopeChangeShim()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorTreeAdapterScopeChangeShim.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorTreeAdapterScopeChangeShim"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ResourceCursorTreeAdapterScopeChangeShim))]
	internal sealed partial class ResourceCursorTreeAdapterScopeChangeShim_ : android.widget.ResourceCursorTreeAdapterScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResourceCursorTreeAdapterScopeChangeShim_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.widget.ResourceCursorTreeAdapterScopeChangeShim_.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;", ref global::android.widget.ResourceCursorTreeAdapterScopeChangeShim_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ResourceCursorTreeAdapterScopeChangeShim_.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", ref global::android.widget.ResourceCursorTreeAdapterScopeChangeShim_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ResourceCursorTreeAdapterScopeChangeShim_.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", ref global::android.widget.ResourceCursorTreeAdapterScopeChangeShim_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static ResourceCursorTreeAdapterScopeChangeShim_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorTreeAdapterScopeChangeShim_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorTreeAdapterScopeChangeShim"));
		}
		internal static void InitJNI()
		{
		}
	}
}
