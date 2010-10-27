namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.FileLock_))]
	public abstract partial class FileLock : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileLock()
		{
			InitJNI();
		}
		protected FileLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString22489;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileLock._toString22489)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._toString22489)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _size22490;
		public virtual long size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileLock._size22490);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._size22490);
		}
		internal static global::MonoJavaBridge.MethodId _position22491;
		public virtual long position()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileLock._position22491);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._position22491);
		}
		internal static global::MonoJavaBridge.MethodId _release22492;
		public abstract void release();
		internal static global::MonoJavaBridge.MethodId _channel22493;
		public virtual global::java.nio.channels.FileChannel channel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileLock._channel22493)) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._channel22493)) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isShared22494;
		public virtual bool isShared()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.FileLock._isShared22494);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._isShared22494);
		}
		internal static global::MonoJavaBridge.MethodId _isValid22495;
		public abstract bool isValid();
		internal static global::MonoJavaBridge.MethodId _overlaps22496;
		public virtual bool overlaps(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.FileLock._overlaps22496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._overlaps22496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _FileLock22497;
		protected FileLock(java.nio.channels.FileChannel arg0, long arg1, long arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._FileLock22497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileLock"));
			global::java.nio.channels.FileLock._toString22489 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.channels.FileLock._size22490 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "size", "()J");
			global::java.nio.channels.FileLock._position22491 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "position", "()J");
			global::java.nio.channels.FileLock._release22492 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "release", "()V");
			global::java.nio.channels.FileLock._channel22493 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "channel", "()Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileLock._isShared22494 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "isShared", "()Z");
			global::java.nio.channels.FileLock._isValid22495 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "isValid", "()Z");
			global::java.nio.channels.FileLock._overlaps22496 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "overlaps", "(JJ)Z");
			global::java.nio.channels.FileLock._FileLock22497 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock.staticClass, "<init>", "(Ljava/nio/channels/FileChannel;JJZ)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.FileLock))]
	internal sealed partial class FileLock_ : java.nio.channels.FileLock
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileLock_()
		{
			InitJNI();
		}
		internal FileLock_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _release22498;
		public override void release()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.FileLock_._release22498);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.FileLock_.staticClass, global::java.nio.channels.FileLock_._release22498);
		}
		internal static global::MonoJavaBridge.MethodId _isValid22499;
		public override bool isValid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.FileLock_._isValid22499);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.FileLock_.staticClass, global::java.nio.channels.FileLock_._isValid22499);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileLock_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileLock"));
			global::java.nio.channels.FileLock_._release22498 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock_.staticClass, "release", "()V");
			global::java.nio.channels.FileLock_._isValid22499 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileLock_.staticClass, "isValid", "()Z");
		}
	}
}
