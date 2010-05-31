namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface WritableByteChannel : Channel
	{ 
		int write(java.nio.ByteBuffer arg0); 
	} 

	public partial class WritableByteChannel_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __WritableByteChannel.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __WritableByteChannel : java.lang.Object, WritableByteChannel
	{ 
		internal static global::java.lang.Class staticClass; 
		static __WritableByteChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.__WritableByteChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.nio.channels.__WritableByteChannel(@__env); 
			} 
		} 
		internal __WritableByteChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write12294; 
		 int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.nio.channels.__WritableByteChannel._write12294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.__WritableByteChannel.staticClass, global::java.nio.channels.__WritableByteChannel._write12294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12295; 
		 void java.nio.channels.Channel.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.nio.channels.__WritableByteChannel._close12295); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.__WritableByteChannel.staticClass, global::java.nio.channels.__WritableByteChannel._close12295); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpen12296; 
		 bool java.nio.channels.Channel.isOpen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.nio.channels.__WritableByteChannel._isOpen12296); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.channels.__WritableByteChannel.staticClass, global::java.nio.channels.__WritableByteChannel._isOpen12296); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12297; 
		 void java.io.Closeable.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.nio.channels.__WritableByteChannel._close12297); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.channels.__WritableByteChannel.staticClass, global::java.nio.channels.__WritableByteChannel._close12297); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.__WritableByteChannel.staticClass = @__class; 
			global::java.nio.channels.__WritableByteChannel._write12294 = @__env.GetMethodID(global::java.nio.channels.__WritableByteChannel.staticClass, "java.nio.channels.WritableByteChannel.write", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.__WritableByteChannel._close12295 = @__env.GetMethodID(global::java.nio.channels.__WritableByteChannel.staticClass, "java.nio.channels.Channel.close", "()V"); 
			global::java.nio.channels.__WritableByteChannel._isOpen12296 = @__env.GetMethodID(global::java.nio.channels.__WritableByteChannel.staticClass, "java.nio.channels.Channel.isOpen", "()Z"); 
			global::java.nio.channels.__WritableByteChannel._close12297 = @__env.GetMethodID(global::java.nio.channels.__WritableByteChannel.staticClass, "java.io.Closeable.close", "()V"); 
		} 
	} 
} 
