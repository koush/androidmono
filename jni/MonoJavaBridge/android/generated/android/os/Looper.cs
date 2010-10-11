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
		internal static global::MonoJavaBridge.MethodId _toString6471;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Looper._toString6471)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Looper.staticClass, global::android.os.Looper._toString6471)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _loop6472;
		public static void loop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._loop6472);
		}
		internal static global::MonoJavaBridge.MethodId _prepare6473;
		public static void prepare() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._prepare6473);
		}
		internal static global::MonoJavaBridge.MethodId _dump6474;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Looper._dump6474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Looper.staticClass, global::android.os.Looper._dump6474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMainLooper6475;
		public static global::android.os.Looper getMainLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._getMainLooper6475)) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _prepareMainLooper6476;
		public static void prepareMainLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, global::android.os.Looper._prepareMainLooper6476);
		}
		internal static global::MonoJavaBridge.MethodId _myLooper6477;
		public static global::android.os.Looper myLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._myLooper6477)) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _setMessageLogging6478;
		public virtual void setMessageLogging(android.util.Printer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Looper._setMessageLogging6478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Looper.staticClass, global::android.os.Looper._setMessageLogging6478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _myQueue6479;
		public static global::android.os.MessageQueue myQueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Looper.staticClass, global::android.os.Looper._myQueue6479)) as android.os.MessageQueue;
		}
		internal static global::MonoJavaBridge.MethodId _quit6480;
		public virtual void quit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Looper._quit6480);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Looper.staticClass, global::android.os.Looper._quit6480);
		}
		internal static global::MonoJavaBridge.MethodId _getThread6481;
		public virtual global::java.lang.Thread getThread() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Looper._getThread6481)) as java.lang.Thread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Looper.staticClass, global::android.os.Looper._getThread6481)) as java.lang.Thread;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Looper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Looper"));
			global::android.os.Looper._toString6471 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Looper._loop6472 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "loop", "()V");
			global::android.os.Looper._prepare6473 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "prepare", "()V");
			global::android.os.Looper._dump6474 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.os.Looper._getMainLooper6475 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			global::android.os.Looper._prepareMainLooper6476 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "prepareMainLooper", "()V");
			global::android.os.Looper._myLooper6477 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "myLooper", "()Landroid/os/Looper;");
			global::android.os.Looper._setMessageLogging6478 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "setMessageLogging", "(Landroid/util/Printer;)V");
			global::android.os.Looper._myQueue6479 = @__env.GetStaticMethodIDNoThrow(global::android.os.Looper.staticClass, "myQueue", "()Landroid/os/MessageQueue;");
			global::android.os.Looper._quit6480 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "quit", "()V");
			global::android.os.Looper._getThread6481 = @__env.GetMethodIDNoThrow(global::android.os.Looper.staticClass, "getThread", "()Ljava/lang/Thread;");
		}
	}
}
