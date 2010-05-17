namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class FileLock : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static FileLock() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.FileLock), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected FileLock(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11356; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.FileLock)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11356)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.FileLock.staticClass, _toString11356)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size11357; 
		public virtual long size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.FileLock)) 
				return @__env.CallLongMethod(this, _size11357); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.nio.channels.FileLock.staticClass, _size11357); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _position11358; 
		public virtual long position() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.FileLock)) 
				return @__env.CallLongMethod(this, _position11358); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.nio.channels.FileLock.staticClass, _position11358); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release11359; 
		public abstract void release(); 
		internal static global::net.sf.jni4net.jni.MethodId _channel11360; 
		public virtual java.nio.channels.FileChannel channel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.FileLock)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileChannel>(@__env, @__env.CallObjectMethodPtr(this, _channel11360)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileChannel>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.FileLock.staticClass, _channel11360)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShared11361; 
		public virtual bool isShared() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.FileLock)) 
				return @__env.CallBooleanMethod(this, _isShared11361); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.FileLock.staticClass, _isShared11361); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isValid11362; 
		public abstract bool isValid(); 
		internal static global::net.sf.jni4net.jni.MethodId _overlaps11363; 
		public virtual bool overlaps(long arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.FileLock)) 
				return @__env.CallBooleanMethod(this, _overlaps11363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.FileLock.staticClass, _overlaps11363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FileLock11364; 
		protected FileLock(java.nio.channels.FileChannel arg0, long arg1, long arg2, bool arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.FileLock.staticClass, _FileLock11364, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.FileLock.staticClass = @__class; 
			global::java.nio.channels.FileLock._toString11356 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.channels.FileLock._size11357 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "size", "()J"); 
			global::java.nio.channels.FileLock._position11358 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "position", "()J"); 
			global::java.nio.channels.FileLock._release11359 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "release", "()V"); 
			global::java.nio.channels.FileLock._channel11360 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "channel", "()Ljava/nio/channels/FileChannel;"); 
			global::java.nio.channels.FileLock._isShared11361 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "isShared", "()Z"); 
			global::java.nio.channels.FileLock._isValid11362 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "isValid", "()Z"); 
			global::java.nio.channels.FileLock._overlaps11363 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "overlaps", "(JJ)Z"); 
			global::java.nio.channels.FileLock._FileLock11364 = @__env.GetMethodID(global::java.nio.channels.FileLock.staticClass, "<init>", "(Ljava/nio/channels/FileChannel;JJZ)V"); 
		} 
	} 
} 
