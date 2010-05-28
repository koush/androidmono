namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ScatteringByteChannel : ReadableByteChannel
	{ 
		long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		long read(java.nio.ByteBuffer[] arg0); 
	} 

	public partial class ScatteringByteChannel_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __ScatteringByteChannel.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __ScatteringByteChannel : java.lang.Object, ScatteringByteChannel
	{ 
		internal static global::java.lang.Class staticClass; 
		static __ScatteringByteChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.__ScatteringByteChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.nio.channels.__ScatteringByteChannel(@__env); 
			} 
		} 
		internal __ScatteringByteChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read12233; 
		 long java.nio.channels.ScatteringByteChannel.read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__ScatteringByteChannel)) 
				return @__env.CallLongMethod(this, global::java.nio.channels.__ScatteringByteChannel._read12233, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.__ScatteringByteChannel.staticClass, global::java.nio.channels.__ScatteringByteChannel._read12233, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read12234; 
		 long java.nio.channels.ScatteringByteChannel.read(java.nio.ByteBuffer[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__ScatteringByteChannel)) 
				return @__env.CallLongMethod(this, global::java.nio.channels.__ScatteringByteChannel._read12234, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.__ScatteringByteChannel.staticClass, global::java.nio.channels.__ScatteringByteChannel._read12234, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read12235; 
		 int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__ScatteringByteChannel)) 
				return @__env.CallIntMethod(this, global::java.nio.channels.__ScatteringByteChannel._read12235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.__ScatteringByteChannel.staticClass, global::java.nio.channels.__ScatteringByteChannel._read12235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12236; 
		 void java.nio.channels.Channel.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__ScatteringByteChannel)) 
				@__env.CallVoidMethod(this, global::java.nio.channels.__ScatteringByteChannel._close12236); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.__ScatteringByteChannel.staticClass, global::java.nio.channels.__ScatteringByteChannel._close12236); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpen12237; 
		 bool java.nio.channels.Channel.isOpen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__ScatteringByteChannel)) 
				return @__env.CallBooleanMethod(this, global::java.nio.channels.__ScatteringByteChannel._isOpen12237); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.__ScatteringByteChannel.staticClass, global::java.nio.channels.__ScatteringByteChannel._isOpen12237); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12238; 
		 void java.io.Closeable.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__ScatteringByteChannel)) 
				@__env.CallVoidMethod(this, global::java.nio.channels.__ScatteringByteChannel._close12238); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.__ScatteringByteChannel.staticClass, global::java.nio.channels.__ScatteringByteChannel._close12238); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.__ScatteringByteChannel.staticClass = @__class; 
			global::java.nio.channels.__ScatteringByteChannel._read12233 = @__env.GetMethodID(global::java.nio.channels.__ScatteringByteChannel.staticClass, "java.nio.channels.ScatteringByteChannel.read", "([Ljava/nio/ByteBuffer;II)J"); 
			global::java.nio.channels.__ScatteringByteChannel._read12234 = @__env.GetMethodID(global::java.nio.channels.__ScatteringByteChannel.staticClass, "java.nio.channels.ScatteringByteChannel.read", "([Ljava/nio/ByteBuffer;)J"); 
			global::java.nio.channels.__ScatteringByteChannel._read12235 = @__env.GetMethodID(global::java.nio.channels.__ScatteringByteChannel.staticClass, "java.nio.channels.ReadableByteChannel.read", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.__ScatteringByteChannel._close12236 = @__env.GetMethodID(global::java.nio.channels.__ScatteringByteChannel.staticClass, "java.nio.channels.Channel.close", "()V"); 
			global::java.nio.channels.__ScatteringByteChannel._isOpen12237 = @__env.GetMethodID(global::java.nio.channels.__ScatteringByteChannel.staticClass, "java.nio.channels.Channel.isOpen", "()Z"); 
			global::java.nio.channels.__ScatteringByteChannel._close12238 = @__env.GetMethodID(global::java.nio.channels.__ScatteringByteChannel.staticClass, "java.io.Closeable.close", "()V"); 
		} 
	} 
} 
