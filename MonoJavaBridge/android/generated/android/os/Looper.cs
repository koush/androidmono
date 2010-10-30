namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Looper : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Looper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString9913;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._toString9913.native == global::System.IntPtr.Zero)
				global::android.os.Looper._toString9913 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Looper.staticClass, global::android.os.Looper._toString9913) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _loop9914;
		public static void loop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._loop9914.native == global::System.IntPtr.Zero)
				global::android.os.Looper._loop9914 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "loop", "()V");
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._loop9914);
		}
		internal static global::MonoJavaBridge.MethodId _prepare9915;
		public static void prepare()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._prepare9915.native == global::System.IntPtr.Zero)
				global::android.os.Looper._prepare9915 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "prepare", "()V");
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._prepare9915);
		}
		internal static global::MonoJavaBridge.MethodId _dump9916;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._dump9916.native == global::System.IntPtr.Zero)
				global::android.os.Looper._dump9916 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Looper.staticClass, global::android.os.Looper._dump9916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getMainLooper9917;
		public static global::android.os.Looper getMainLooper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._getMainLooper9917.native == global::System.IntPtr.Zero)
				global::android.os.Looper._getMainLooper9917 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._getMainLooper9917)) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _prepareMainLooper9918;
		public static void prepareMainLooper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._prepareMainLooper9918.native == global::System.IntPtr.Zero)
				global::android.os.Looper._prepareMainLooper9918 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "prepareMainLooper", "()V");
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._prepareMainLooper9918);
		}
		internal static global::MonoJavaBridge.MethodId _myLooper9919;
		public static global::android.os.Looper myLooper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._myLooper9919.native == global::System.IntPtr.Zero)
				global::android.os.Looper._myLooper9919 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "myLooper", "()Landroid/os/Looper;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._myLooper9919)) as android.os.Looper;
		}
		public new global::android.util.Printer MessageLogging
		{
			set
			{
				setMessageLogging(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMessageLogging9920;
		public virtual void setMessageLogging(android.util.Printer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._setMessageLogging9920.native == global::System.IntPtr.Zero)
				global::android.os.Looper._setMessageLogging9920 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "setMessageLogging", "(Landroid/util/Printer;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Looper.staticClass, global::android.os.Looper._setMessageLogging9920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setMessageLogging(global::android.util.PrinterDelegate arg0)
		{
			setMessageLogging((global::android.util.PrinterDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _myQueue9921;
		public static global::android.os.MessageQueue myQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._myQueue9921.native == global::System.IntPtr.Zero)
				global::android.os.Looper._myQueue9921 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "myQueue", "()Landroid/os/MessageQueue;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._myQueue9921)) as android.os.MessageQueue;
		}
		internal static global::MonoJavaBridge.MethodId _quit9922;
		public virtual void quit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._quit9922.native == global::System.IntPtr.Zero)
				global::android.os.Looper._quit9922 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "quit", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Looper.staticClass, global::android.os.Looper._quit9922);
		}
		public new global::java.lang.Thread Thread
		{
			get
			{
				return getThread();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThread9923;
		public virtual global::java.lang.Thread getThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Looper._getThread9923.native == global::System.IntPtr.Zero)
				global::android.os.Looper._getThread9923 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "getThread", "()Ljava/lang/Thread;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Looper.staticClass, global::android.os.Looper._getThread9923) as java.lang.Thread;
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
