namespace java.nio.channels
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class FileLock : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static FileLock()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.FileLock), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected FileLock(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12196;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.FileLock._toString12196));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._toString12196));
		}
		internal static global::net.sf.jni4net.jni.MethodId _size12197;
		public virtual long size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.nio.channels.FileLock._size12197);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._size12197);
		}
		internal static global::net.sf.jni4net.jni.MethodId _position12198;
		public virtual long position() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.nio.channels.FileLock._position12198);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._position12198);
		}
		internal static global::net.sf.jni4net.jni.MethodId _release12199;
		public abstract void release();
		internal static global::net.sf.jni4net.jni.MethodId _channel12200;
		public virtual global::java.nio.channels.FileChannel channel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileChannel>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.FileLock._channel12200));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._channel12200));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShared12201;
		public virtual bool isShared() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.channels.FileLock._isShared12201);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._isShared12201);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isValid12202;
		public abstract bool isValid();
		internal static global::net.sf.jni4net.jni.MethodId _overlaps12203;
		public virtual bool overlaps(long arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.channels.FileLock._overlaps12203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._overlaps12203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FileLock12204;
		protected FileLock(java.nio.channels.FileChannel arg0, long arg1, long arg2, bool arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.FileLock.staticClass, global::java.nio.channels.FileLock._FileLock12204, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.FileLock.staticClass = @__class;
			global::java.nio.channels.FileLock._toString12196 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.channels.FileLock._size12197 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "size", "()J");
			global::java.nio.channels.FileLock._position12198 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "position", "()J");
			global::java.nio.channels.FileLock._release12199 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "release", "()V");
			global::java.nio.channels.FileLock._channel12200 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "channel", "()Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileLock._isShared12201 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "isShared", "()Z");
			global::java.nio.channels.FileLock._isValid12202 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "isValid", "()Z");
			global::java.nio.channels.FileLock._overlaps12203 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "overlaps", "(JJ)Z");
			global::java.nio.channels.FileLock._FileLock12204 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "<init>", "(Ljava/nio/channels/FileChannel;JJZ)V");
		}
	}
}
