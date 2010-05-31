namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ReadableByteChannel : Channel
	{ 
		int read(java.nio.ByteBuffer arg0); 
	} 

	public partial class ReadableByteChannel_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __ReadableByteChannel.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __ReadableByteChannel : java.lang.Object, ReadableByteChannel
	{ 
		internal static global::java.lang.Class staticClass; 
		static __ReadableByteChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.__ReadableByteChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.nio.channels.__ReadableByteChannel(@__env); 
			} 
		} 
		internal __ReadableByteChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read12229; 
		 int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.nio.channels.__ReadableByteChannel._read12229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.__ReadableByteChannel.staticClass, global::java.nio.channels.__ReadableByteChannel._read12229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12230; 
		 void java.nio.channels.Channel.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.nio.channels.__ReadableByteChannel._close12230); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.__ReadableByteChannel.staticClass, global::java.nio.channels.__ReadableByteChannel._close12230); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpen12231; 
		 bool java.nio.channels.Channel.isOpen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.nio.channels.__ReadableByteChannel._isOpen12231); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.__ReadableByteChannel.staticClass, global::java.nio.channels.__ReadableByteChannel._isOpen12231); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12232; 
		 void java.io.Closeable.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.nio.channels.__ReadableByteChannel._close12232); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.__ReadableByteChannel.staticClass, global::java.nio.channels.__ReadableByteChannel._close12232); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.__ReadableByteChannel.staticClass = @__class; 
			global::java.nio.channels.__ReadableByteChannel._read12229 = @__env.GetMethodID(global::java.nio.channels.__ReadableByteChannel.staticClass, "java.nio.channels.ReadableByteChannel.read", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.__ReadableByteChannel._close12230 = @__env.GetMethodID(global::java.nio.channels.__ReadableByteChannel.staticClass, "java.nio.channels.Channel.close", "()V"); 
			global::java.nio.channels.__ReadableByteChannel._isOpen12231 = @__env.GetMethodID(global::java.nio.channels.__ReadableByteChannel.staticClass, "java.nio.channels.Channel.isOpen", "()Z"); 
			global::java.nio.channels.__ReadableByteChannel._close12232 = @__env.GetMethodID(global::java.nio.channels.__ReadableByteChannel.staticClass, "java.io.Closeable.close", "()V"); 
		} 
	} 
} 
