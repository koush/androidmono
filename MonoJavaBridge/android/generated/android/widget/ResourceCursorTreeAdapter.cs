namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.ResourceCursorTreeAdapter_))]
	public abstract partial class ResourceCursorTreeAdapter : android.widget.ResourceCursorTreeAdapterScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResourceCursorTreeAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newGroupView17662;
		public virtual global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._newGroupView17662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _newChildView17663;
		public virtual global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._newChildView17663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _ResourceCursorTreeAdapter17664;
		public ResourceCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter17664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ResourceCursorTreeAdapter17665;
		public ResourceCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter17665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ResourceCursorTreeAdapter17666;
		public ResourceCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter17666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static ResourceCursorTreeAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorTreeAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorTreeAdapter"));
			global::android.widget.ResourceCursorTreeAdapter._newGroupView17662 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ResourceCursorTreeAdapter._newChildView17663 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter17664 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;IIII)V");
			global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter17665 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;III)V");
			global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter17666 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;II)V");
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
		internal static global::MonoJavaBridge.MethodId _getChildrenCursor17667;
		protected override global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter_._getChildrenCursor17667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _bindGroupView17668;
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter_._bindGroupView17668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _bindChildView17669;
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter_._bindChildView17669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static ResourceCursorTreeAdapter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorTreeAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorTreeAdapter"));
			global::android.widget.ResourceCursorTreeAdapter_._getChildrenCursor17667 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter_.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;");
			global::android.widget.ResourceCursorTreeAdapter_._bindGroupView17668 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter_.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.ResourceCursorTreeAdapter_._bindChildView17669 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter_.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
