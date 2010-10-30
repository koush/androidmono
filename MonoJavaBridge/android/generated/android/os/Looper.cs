namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Looper : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Looper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Looper.staticClass, "toString", "()Ljava/lang/String;", ref global::android.os.Looper._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void loop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._m1.native == global::System.IntPtr.Zero)
				global::android.os.Looper._m1 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "loop", "()V");
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void prepare()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._m2.native == global::System.IntPtr.Zero)
				global::android.os.Looper._m2 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "prepare", "()V");
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Looper.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.os.Looper._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		public static global::android.os.Looper MainLooper
		{
			get
			{
				return getMainLooper();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::android.os.Looper getMainLooper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._m4.native == global::System.IntPtr.Zero)
				global::android.os.Looper._m4 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._m4)) as android.os.Looper;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void prepareMainLooper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._m5.native == global::System.IntPtr.Zero)
				global::android.os.Looper._m5 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "prepareMainLooper", "()V");
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.os.Looper myLooper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._m6.native == global::System.IntPtr.Zero)
				global::android.os.Looper._m6 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "myLooper", "()Landroid/os/Looper;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._m6)) as android.os.Looper;
		}
		public new global::android.util.Printer MessageLogging
		{
			set
			{
				setMessageLogging(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setMessageLogging(android.util.Printer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Looper.staticClass, "setMessageLogging", "(Landroid/util/Printer;)V", ref global::android.os.Looper._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setMessageLogging(global::android.util.PrinterDelegate arg0)
		{
			setMessageLogging((global::android.util.PrinterDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::android.os.MessageQueue myQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._m8.native == global::System.IntPtr.Zero)
				global::android.os.Looper._m8 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "myQueue", "()Landroid/os/MessageQueue;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._m8)) as android.os.MessageQueue;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void quit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Looper.staticClass, "quit", "()V", ref global::android.os.Looper._m9);
		}
		public new global::java.lang.Thread Thread
		{
			get
			{
				return getThread();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.Thread getThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Looper.staticClass, "getThread", "()Ljava/lang/Thread;", ref global::android.os.Looper._m10) as java.lang.Thread;
		}
		static Looper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Looper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Looper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
