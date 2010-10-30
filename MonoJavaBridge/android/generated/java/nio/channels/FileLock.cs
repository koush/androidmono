namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.FileLock_))]
	public abstract partial class FileLock : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString22490;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileLock._toString22490.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileLock._toString22490 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._toString22490) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size22491;
		public virtual long size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileLock._size22491.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileLock._size22491 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "size", "()J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._size22491);
		}
		internal static global::MonoJavaBridge.MethodId _position22492;
		public virtual long position()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileLock._position22492.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileLock._position22492 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "position", "()J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._position22492);
		}
		internal static global::MonoJavaBridge.MethodId _release22493;
		public abstract void release();
		internal static global::MonoJavaBridge.MethodId _channel22494;
		public virtual global::java.nio.channels.FileChannel channel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileLock._channel22494.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileLock._channel22494 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "channel", "()Ljava/nio/channels/FileChannel;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._channel22494) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isShared22495;
		public virtual bool isShared()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileLock._isShared22495.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileLock._isShared22495 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "isShared", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._isShared22495);
		}
		internal static global::MonoJavaBridge.MethodId _isValid22496;
		public abstract bool isValid();
		internal static global::MonoJavaBridge.MethodId _overlaps22497;
		public virtual bool overlaps(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileLock._overlaps22497.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileLock._overlaps22497 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "overlaps", "(JJ)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._overlaps22497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _FileLock22498;
		protected FileLock(java.nio.channels.FileChannel arg0, long arg1, long arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileLock._FileLock22498.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileLock._FileLock22498 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "<init>", "(Ljava/nio/channels/FileChannel;JJZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._FileLock22498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		internal static global::MonoJavaBridge.MethodId _release22499;
		public override void release()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileLock_._release22499.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileLock_._release22499 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock_.staticClass, "release", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.FileLock_._release22499);
		}
		internal static global::MonoJavaBridge.MethodId _isValid22500;
		public override bool isValid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileLock_._isValid22500.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileLock_._isValid22500 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock_.staticClass, "isValid", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.FileLock_._isValid22500);
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
