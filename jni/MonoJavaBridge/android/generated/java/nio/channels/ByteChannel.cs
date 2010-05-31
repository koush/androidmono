namespace java.nio.channels
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ByteChannel : ReadableByteChannel, WritableByteChannel
	{
	}

	public partial class ByteChannel_
	{
		public static global::java.lang.Class _class
		{
			get { return __ByteChannel.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ByteChannel : java.lang.Object, ByteChannel
	{
		internal static global::java.lang.Class staticClass;
		static __ByteChannel()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.__ByteChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.nio.channels.__ByteChannel(@__env);
			}
		}
		internal __ByteChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _read12148;
		 int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.channels.__ByteChannel._read12148, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.__ByteChannel.staticClass, global::java.nio.channels.__ByteChannel._read12148, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close12149;
		 void java.nio.channels.Channel.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.__ByteChannel._close12149);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.__ByteChannel.staticClass, global::java.nio.channels.__ByteChannel._close12149);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpen12150;
		 bool java.nio.channels.Channel.isOpen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.channels.__ByteChannel._isOpen12150);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.__ByteChannel.staticClass, global::java.nio.channels.__ByteChannel._isOpen12150);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close12151;
		 void java.io.Closeable.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.channels.__ByteChannel._close12151);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.__ByteChannel.staticClass, global::java.nio.channels.__ByteChannel._close12151);
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12152;
		 int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.channels.__ByteChannel._write12152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.__ByteChannel.staticClass, global::java.nio.channels.__ByteChannel._write12152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.__ByteChannel.staticClass = @__class;
			global::java.nio.channels.__ByteChannel._read12148 = @__env.GetMethodID(global::java.nio.channels.__ByteChannel.staticClass, "java.nio.channels.ReadableByteChannel.read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.__ByteChannel._close12149 = @__env.GetMethodID(global::java.nio.channels.__ByteChannel.staticClass, "java.nio.channels.Channel.close", "()V");
			global::java.nio.channels.__ByteChannel._isOpen12150 = @__env.GetMethodID(global::java.nio.channels.__ByteChannel.staticClass, "java.nio.channels.Channel.isOpen", "()Z");
			global::java.nio.channels.__ByteChannel._close12151 = @__env.GetMethodID(global::java.nio.channels.__ByteChannel.staticClass, "java.io.Closeable.close", "()V");
			global::java.nio.channels.__ByteChannel._write12152 = @__env.GetMethodID(global::java.nio.channels.__ByteChannel.staticClass, "java.nio.channels.WritableByteChannel.write", "(Ljava/nio/ByteBuffer;)I");
		}
	}
}
