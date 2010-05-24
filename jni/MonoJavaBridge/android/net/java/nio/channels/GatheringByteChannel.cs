namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface GatheringByteChannel : WritableByteChannel
	{ 
		long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		long write(java.nio.ByteBuffer[] arg0); 
	} 

	public partial class GatheringByteChannel_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __GatheringByteChannel.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __GatheringByteChannel : java.lang.Object, GatheringByteChannel
	{ 
		internal static global::java.lang.Class staticClass; 
		static __GatheringByteChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.__GatheringByteChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.nio.channels.__GatheringByteChannel(@__env); 
			} 
		} 
		internal __GatheringByteChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write12205; 
		 long java.nio.channels.GatheringByteChannel.write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__GatheringByteChannel)) 
				return @__env.CallLongMethod(this, _write12205, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.nio.channels.__GatheringByteChannel.staticClass, _write12205, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write12206; 
		 long java.nio.channels.GatheringByteChannel.write(java.nio.ByteBuffer[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__GatheringByteChannel)) 
				return @__env.CallLongMethod(this, _write12206, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.nio.channels.__GatheringByteChannel.staticClass, _write12206, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write12207; 
		 int java.nio.channels.WritableByteChannel.write(java.nio.ByteBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__GatheringByteChannel)) 
				return @__env.CallIntMethod(this, _write12207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.channels.__GatheringByteChannel.staticClass, _write12207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12208; 
		 void java.nio.channels.Channel.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__GatheringByteChannel)) 
				@__env.CallVoidMethod(this, _close12208); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.__GatheringByteChannel.staticClass, _close12208); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpen12209; 
		 bool java.nio.channels.Channel.isOpen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__GatheringByteChannel)) 
				return @__env.CallBooleanMethod(this, _isOpen12209); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.channels.__GatheringByteChannel.staticClass, _isOpen12209); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close12210; 
		 void java.io.Closeable.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.__GatheringByteChannel)) 
				@__env.CallVoidMethod(this, _close12210); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.channels.__GatheringByteChannel.staticClass, _close12210); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.__GatheringByteChannel.staticClass = @__class; 
			global::java.nio.channels.__GatheringByteChannel._write12205 = @__env.GetMethodID(global::java.nio.channels.__GatheringByteChannel.staticClass, "java.nio.channels.GatheringByteChannel.write", "([Ljava/nio/ByteBuffer;II)J"); 
			global::java.nio.channels.__GatheringByteChannel._write12206 = @__env.GetMethodID(global::java.nio.channels.__GatheringByteChannel.staticClass, "java.nio.channels.GatheringByteChannel.write", "([Ljava/nio/ByteBuffer;)J"); 
			global::java.nio.channels.__GatheringByteChannel._write12207 = @__env.GetMethodID(global::java.nio.channels.__GatheringByteChannel.staticClass, "java.nio.channels.WritableByteChannel.write", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.__GatheringByteChannel._close12208 = @__env.GetMethodID(global::java.nio.channels.__GatheringByteChannel.staticClass, "java.nio.channels.Channel.close", "()V"); 
			global::java.nio.channels.__GatheringByteChannel._isOpen12209 = @__env.GetMethodID(global::java.nio.channels.__GatheringByteChannel.staticClass, "java.nio.channels.Channel.isOpen", "()Z"); 
			global::java.nio.channels.__GatheringByteChannel._close12210 = @__env.GetMethodID(global::java.nio.channels.__GatheringByteChannel.staticClass, "java.io.Closeable.close", "()V"); 
		} 
	} 
} 
