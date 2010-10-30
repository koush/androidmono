namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.FileLock_))]
	public abstract partial class FileLock : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.channels.FileLock.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.channels.FileLock._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual long size()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileLock.staticClass, "size", "()J", ref global::java.nio.channels.FileLock._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual long position()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileLock.staticClass, "position", "()J", ref global::java.nio.channels.FileLock._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void release();
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.nio.channels.FileChannel channel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileLock.staticClass, "channel", "()Ljava/nio/channels/FileChannel;", ref global::java.nio.channels.FileLock._m4) as java.nio.channels.FileChannel;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isShared()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.FileLock.staticClass, "isShared", "()Z", ref global::java.nio.channels.FileLock._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract bool isValid();
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool overlaps(long arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.FileLock.staticClass, "overlaps", "(JJ)Z", ref global::java.nio.channels.FileLock._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected FileLock(java.nio.channels.FileChannel arg0, long arg1, long arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileLock._m8.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileLock._m8 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "<init>", "(Ljava/nio/channels/FileChannel;JJZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static FileLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileLock"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.FileLock))]
	internal sealed partial class FileLock_ : java.nio.channels.FileLock
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FileLock_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.FileLock_.staticClass, "release", "()V", ref global::java.nio.channels.FileLock_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool isValid()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.FileLock_.staticClass, "isValid", "()Z", ref global::java.nio.channels.FileLock_._m1);
		}
		static FileLock_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileLock_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileLock"));
		}
		internal static void InitJNI()
		{
		}
	}
}
