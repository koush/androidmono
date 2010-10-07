namespace java.nio
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class MappedByteBuffer : java.nio.ByteBuffer
	{
		internal static global::java.lang.Class staticClass;
		static MappedByteBuffer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.MappedByteBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected MappedByteBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _load12851;
		public virtual global::java.nio.MappedByteBuffer load() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.MappedByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.MappedByteBuffer._load12851));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.MappedByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._load12851));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLoaded12852;
		public virtual bool isLoaded() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.MappedByteBuffer._isLoaded12852);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._isLoaded12852);
		}
		internal static global::net.sf.jni4net.jni.MethodId _force12853;
		public virtual global::java.nio.MappedByteBuffer force() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.MappedByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.MappedByteBuffer._force12853));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.MappedByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.MappedByteBuffer.staticClass, global::java.nio.MappedByteBuffer._force12853));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.MappedByteBuffer.staticClass = @__class;
			global::java.nio.MappedByteBuffer._load12851 = @__env.GetMethodID(global::java.nio.MappedByteBuffer.staticClass, "load", "()Ljava/nio/MappedByteBuffer;");
			global::java.nio.MappedByteBuffer._isLoaded12852 = @__env.GetMethodID(global::java.nio.MappedByteBuffer.staticClass, "isLoaded", "()Z");
			global::java.nio.MappedByteBuffer._force12853 = @__env.GetMethodID(global::java.nio.MappedByteBuffer.staticClass, "force", "()Ljava/nio/MappedByteBuffer;");
		}
	}
}
