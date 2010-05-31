namespace java.io 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface FileFilter 
	{ 
		bool accept(java.io.File arg0); 
	} 

	public partial class FileFilter_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __FileFilter.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __FileFilter : java.lang.Object, FileFilter
	{ 
		internal static global::java.lang.Class staticClass; 
		static __FileFilter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.io.__FileFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.io.__FileFilter(@__env); 
			} 
		} 
		internal __FileFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _accept11394; 
		 bool java.io.FileFilter.accept(java.io.File arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.io.__FileFilter._accept11394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.__FileFilter.staticClass, global::java.io.__FileFilter._accept11394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.io.__FileFilter.staticClass = @__class; 
			global::java.io.__FileFilter._accept11394 = @__env.GetMethodID(global::java.io.__FileFilter.staticClass, "java.io.FileFilter.accept", "(Ljava/io/File;)Z"); 
		} 
	} 
} 
