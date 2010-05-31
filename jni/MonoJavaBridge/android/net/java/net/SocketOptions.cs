namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SocketOptions 
	{ 
		global::java.lang.Object getOption(int arg0); 
		void setOption(int arg0, java.lang.Object arg1); 
	} 

	public partial class SocketOptions_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SocketOptions.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SocketOptions : java.lang.Object, SocketOptions
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SocketOptions() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.__SocketOptions), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.__SocketOptions(@__env); 
			} 
		} 
		internal __SocketOptions(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOption11895; 
		 global::java.lang.Object java.net.SocketOptions.getOption(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.__SocketOptions._getOption11895, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.__SocketOptions.staticClass, global::java.net.__SocketOptions._getOption11895, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOption11896; 
		 void java.net.SocketOptions.setOption(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.__SocketOptions._setOption11896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.__SocketOptions.staticClass, global::java.net.__SocketOptions._setOption11896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.__SocketOptions.staticClass = @__class; 
			global::java.net.__SocketOptions._getOption11895 = @__env.GetMethodID(global::java.net.__SocketOptions.staticClass, "java.net.SocketOptions.getOption", "(I)Ljava/lang/Object;"); 
			global::java.net.__SocketOptions._setOption11896 = @__env.GetMethodID(global::java.net.__SocketOptions.staticClass, "java.net.SocketOptions.setOption", "(ILjava/lang/Object;)V"); 
		} 
	} 
} 
