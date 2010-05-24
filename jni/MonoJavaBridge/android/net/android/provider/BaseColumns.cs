namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface BaseColumns 
	{ 
	} 

	public partial class BaseColumns_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __BaseColumns.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __BaseColumns : java.lang.Object, BaseColumns
	{ 
		internal static global::java.lang.Class staticClass; 
		static __BaseColumns() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.__BaseColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.provider.__BaseColumns(@__env); 
			} 
		} 
		internal __BaseColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.__BaseColumns.staticClass = @__class; 
		} 
	} 
} 
