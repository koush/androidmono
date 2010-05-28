namespace java.lang 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Readable 
	{ 
		int read(java.nio.CharBuffer arg0); 
	} 

	public partial class Readable_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Readable.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Readable : java.lang.Object, Readable
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Readable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.lang.__Readable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.lang.__Readable(@__env); 
			} 
		} 
		internal __Readable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read11507; 
		 int java.lang.Readable.read(java.nio.CharBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.__Readable)) 
				return @__env.CallIntMethod(this, global::java.lang.__Readable._read11507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.__Readable.staticClass, global::java.lang.__Readable._read11507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.lang.__Readable.staticClass = @__class; 
			global::java.lang.__Readable._read11507 = @__env.GetMethodID(global::java.lang.__Readable.staticClass, "java.lang.Readable.read", "(Ljava/nio/CharBuffer;)I"); 
		} 
	} 
} 
