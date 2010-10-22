namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Looper : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Looper()
		{
			InitJNI();
		}
		protected Looper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString9868;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Looper._toString9868)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Looper.staticClass, global::android.os.Looper._toString9868)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _loop9869;
		public static void loop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._loop9869);
		}
		internal static global::MonoJavaBridge.MethodId _prepare9870;
		public static void prepare() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._prepare9870);
		}
		internal static global::MonoJavaBridge.MethodId _dump9871;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Looper._dump9871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Looper.staticClass, global::android.os.Looper._dump9871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static global::android.os.Looper MainLooper
		{
			get
			{
				return getMainLooper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMainLooper9872;
		public static global::android.os.Looper getMainLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._getMainLooper9872)) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _prepareMainLooper9873;
		public static void prepareMainLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._prepareMainLooper9873);
		}
		internal static global::MonoJavaBridge.MethodId _myLooper9874;
		public static global::android.os.Looper myLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._myLooper9874)) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _setMessageLogging9875;
		public virtual void setMessageLogging(android.util.Printer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Looper._setMessageLogging9875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Looper.staticClass, global::android.os.Looper._setMessageLogging9875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _myQueue9876;
		public static global::android.os.MessageQueue myQueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._myQueue9876)) as android.os.MessageQueue;
		}
		internal static global::MonoJavaBridge.MethodId _quit9877;
		public virtual void quit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Looper._quit9877);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Looper.staticClass, global::android.os.Looper._quit9877);
		}
		public new global::java.lang.Thread Thread
		{
			get
			{
				return getThread();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThread9878;
		public virtual global::java.lang.Thread getThread() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Looper._getThread9878)) as java.lang.Thread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Looper.staticClass, global::android.os.Looper._getThread9878)) as java.lang.Thread;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Looper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Looper"));
			global::android.os.Looper._toString9868 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Looper._loop9869 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "loop", "()V");
			global::android.os.Looper._prepare9870 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "prepare", "()V");
			global::android.os.Looper._dump9871 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.os.Looper._getMainLooper9872 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			global::android.os.Looper._prepareMainLooper9873 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "prepareMainLooper", "()V");
			global::android.os.Looper._myLooper9874 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "myLooper", "()Landroid/os/Looper;");
			global::android.os.Looper._setMessageLogging9875 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "setMessageLogging", "(Landroid/util/Printer;)V");
			global::android.os.Looper._myQueue9876 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "myQueue", "()Landroid/os/MessageQueue;");
			global::android.os.Looper._quit9877 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "quit", "()V");
			global::android.os.Looper._getThread9878 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "getThread", "()Ljava/lang/Thread;");
		}
	}
}
