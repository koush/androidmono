namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.ResourceCursorAdapter_))]
	public abstract partial class ResourceCursorAdapter : android.widget.CursorAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResourceCursorAdapter()
		{
			InitJNI();
		}
		protected ResourceCursorAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownViewResource11817;
		public virtual void setDropDownViewResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorAdapter._setDropDownViewResource11817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._setDropDownViewResource11817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newView11818;
		public override global::android.view.View newView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ResourceCursorAdapter._newView11818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._newView11818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _newDropDownView11819;
		public override global::android.view.View newDropDownView(android.content.Context arg0, android.database.Cursor arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ResourceCursorAdapter._newDropDownView11819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._newDropDownView11819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setViewResource11820;
		public virtual void setViewResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorAdapter._setViewResource11820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._setViewResource11820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ResourceCursorAdapter11821;
		public ResourceCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter11821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ResourceCursorAdapter11822;
		public ResourceCursorAdapter(android.content.Context arg0, int arg1, android.database.Cursor arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorAdapter.staticClass, global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter11822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorAdapter"));
			global::android.widget.ResourceCursorAdapter._setDropDownViewResource11817 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorAdapter.staticClass, "setDropDownViewResource", "(I)V");
			global::android.widget.ResourceCursorAdapter._newView11818 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorAdapter.staticClass, "newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ResourceCursorAdapter._newDropDownView11819 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorAdapter.staticClass, "newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ResourceCursorAdapter._setViewResource11820 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorAdapter.staticClass, "setViewResource", "(I)V");
			global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter11821 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;)V");
			global::android.widget.ResourceCursorAdapter._ResourceCursorAdapter11822 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorAdapter.staticClass, "<init>", "(Landroid/content/Context;ILandroid/database/Cursor;Z)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ResourceCursorAdapter))]
	public sealed partial class ResourceCursorAdapter_ : android.widget.ResourceCursorAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResourceCursorAdapter_()
		{
			InitJNI();
		}
		internal ResourceCursorAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _bindView11823;
		public override void bindView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorAdapter_._bindView11823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorAdapter_.staticClass, global::android.widget.ResourceCursorAdapter_._bindView11823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorAdapter"));
			global::android.widget.ResourceCursorAdapter_._bindView11823 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorAdapter_.staticClass, "bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V");
		}
	}
}
