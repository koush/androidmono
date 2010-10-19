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
		internal static global::MonoJavaBridge.MethodId _enable9511;
		public virtual void enable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener._enable9511);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._enable9511);
		}
		internal static global::MonoJavaBridge.MethodId _disable9512;
		public virtual void disable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener._disable9512);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._disable9512);
		}
		internal static global::MonoJavaBridge.MethodId _canDetectOrientation9513;
		public virtual bool canDetectOrientation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.OrientationEventListener._canDetectOrientation9513);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._canDetectOrientation9513);
		}
		internal static global::MonoJavaBridge.MethodId _onOrientationChanged9514;
		public abstract void onOrientationChanged(int arg0);
		internal static global::MonoJavaBridge.MethodId _OrientationEventListener9515;
		public OrientationEventListener(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._OrientationEventListener9515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OrientationEventListener9516;
		public OrientationEventListener(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._OrientationEventListener9516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::android.view.OrientationEventListener._enable9511 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "enable", "()V");
			global::android.view.OrientationEventListener._disable9512 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "disable", "()V");
			global::android.view.OrientationEventListener._canDetectOrientation9513 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "canDetectOrientation", "()Z");
			global::android.view.OrientationEventListener._onOrientationChanged9514 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "onOrientationChanged", "(I)V");
			global::android.view.OrientationEventListener._OrientationEventListener9515 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.OrientationEventListener._OrientationEventListener9516 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "<init>", "(Landroid/content/Context;I)V");
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
		internal static global::MonoJavaBridge.MethodId _onOrientationChanged9517;
		public override void onOrientationChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener_._onOrientationChanged9517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.OrientationEventListener_.staticClass, global::android.view.OrientationEventListener_._onOrientationChanged9517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.OrientationEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/OrientationEventListener"));
			global::android.view.OrientationEventListener_._onOrientationChanged9517 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener_.staticClass, "onOrientationChanged", "(I)V");
		}
	}
}
