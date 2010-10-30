namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.ResourceCursorAdapter_))]
	public abstract partial class ResourceCursorAdapter : android.widget.CursorAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResourceCursorAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownViewResource17655;
		public virtual void setDropDownViewResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ResourceCursorAdapter.staticClass, "setDropDownViewResource", "(I)V", ref global::android.widget.ResourceCursorAdapter._setDropDownViewResource17655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newView17656;
		public override global::android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ResourceCursorAdapter.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ResourceCursorAdapter._newView17656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _newDropDownView17657;
		public override global::android.view.View newDropDownView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ResourceCursorAdapter.staticClass, "newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ResourceCursorAdapter._newDropDownView17657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setViewResource17658;
		public virtual void setViewResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ResourceCursorAdapter.staticClass, "setViewResource", "(I)V", ref global::android.widget.ResourceCursorAdapter._setViewResource17658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ResourceCursorAdapter17659;
		public ResourceCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter17659.native == global::System.IntPtr.Zero)
				global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter17659 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter17659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ResourceCursorAdapter17660;
		public ResourceCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter17660.native == global::System.IntPtr.Zero)
				global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter17660 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter17660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		internal static global::MonoJavaBridge.MethodId _bindView17661;
		public override void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ResourceCursorAdapter_.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V", ref global::android.widget.ResourceCursorAdapter_._bindView17661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
