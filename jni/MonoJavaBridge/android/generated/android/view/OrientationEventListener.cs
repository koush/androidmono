namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.OrientationEventListener_))]
	public abstract partial class OrientationEventListener : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OrientationEventListener()
		{
			InitJNI();
		}
		protected OrientationEventListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _enable8965;
		public virtual void enable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener._enable8965);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._enable8965);
		}
		internal static global::MonoJavaBridge.MethodId _disable8966;
		public virtual void disable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener._disable8966);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._disable8966);
		}
		internal static global::MonoJavaBridge.MethodId _canDetectOrientation8967;
		public virtual bool canDetectOrientation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.OrientationEventListener._canDetectOrientation8967);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._canDetectOrientation8967);
		}
		internal static global::MonoJavaBridge.MethodId _onOrientationChanged8968;
		public abstract void onOrientationChanged(int arg0);
		internal static global::MonoJavaBridge.MethodId _OrientationEventListener8969;
		public OrientationEventListener(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._OrientationEventListener8969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OrientationEventListener8970;
		public OrientationEventListener(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._OrientationEventListener8970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int ORIENTATION_UNKNOWN
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.OrientationEventListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/OrientationEventListener"));
			global::android.view.OrientationEventListener._enable8965 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "enable", "()V");
			global::android.view.OrientationEventListener._disable8966 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "disable", "()V");
			global::android.view.OrientationEventListener._canDetectOrientation8967 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "canDetectOrientation", "()Z");
			global::android.view.OrientationEventListener._onOrientationChanged8968 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "onOrientationChanged", "(I)V");
			global::android.view.OrientationEventListener._OrientationEventListener8969 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.OrientationEventListener._OrientationEventListener8970 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.OrientationEventListener))]
	public sealed partial class OrientationEventListener_ : android.view.OrientationEventListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OrientationEventListener_()
		{
			InitJNI();
		}
		internal OrientationEventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onOrientationChanged8971;
		public override void onOrientationChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener_._onOrientationChanged8971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener_.staticClass, global::android.view.OrientationEventListener_._onOrientationChanged8971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.OrientationEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/OrientationEventListener"));
			global::android.view.OrientationEventListener_._onOrientationChanged8971 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener_.staticClass, "onOrientationChanged", "(I)V");
		}
	}
}
