namespace java.nio 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class MappedByteBuffer : java.nio.ByteBuffer
	{ 
		internal static global::java.lang.Class staticClass; 
		static MappedByteBuffer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.MappedByteBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected MappedByteBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _load11290; 
		public virtual java.nio.MappedByteBuffer load() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.MappedByteBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.MappedByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, _load11290)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.MappedByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.MappedByteBuffer.staticClass, _load11290)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLoaded11291; 
		public virtual bool isLoaded() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.MappedByteBuffer)) 
				return @__env.CallBooleanMethod(this, _isLoaded11291); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.MappedByteBuffer.staticClass, _isLoaded11291); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _force11292; 
		public virtual java.nio.MappedByteBuffer force() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.MappedByteBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.MappedByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, _force11292)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.MappedByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.MappedByteBuffer.staticClass, _force11292)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.MappedByteBuffer.staticClass = @__class; 
			global::java.nio.MappedByteBuffer._load11290 = @__env.GetMethodID(global::java.nio.MappedByteBuffer.staticClass, "load", "()Ljava/nio/MappedByteBuffer;"); 
			global::java.nio.MappedByteBuffer._isLoaded11291 = @__env.GetMethodID(global::java.nio.MappedByteBuffer.staticClass, "isLoaded", "()Z"); 
			global::java.nio.MappedByteBuffer._force11292 = @__env.GetMethodID(global::java.nio.MappedByteBuffer.staticClass, "force", "()Ljava/nio/MappedByteBuffer;"); 
		} 
	} 
} 
