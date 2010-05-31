namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface FileNameMap 
	{ 
		global::java.lang.String getContentTypeFor(java.lang.String arg0); 
	} 

	public partial class FileNameMap_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __FileNameMap.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __FileNameMap : java.lang.Object, FileNameMap
	{ 
		internal static global::java.lang.Class staticClass; 
		static __FileNameMap() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.__FileNameMap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.__FileNameMap(@__env); 
			} 
		} 
		internal __FileNameMap(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentTypeFor11738; 
		 global::java.lang.String java.net.FileNameMap.getContentTypeFor(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.__FileNameMap._getContentTypeFor11738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.__FileNameMap.staticClass, global::java.net.__FileNameMap._getContentTypeFor11738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.__FileNameMap.staticClass = @__class; 
			global::java.net.__FileNameMap._getContentTypeFor11738 = @__env.GetMethodID(global::java.net.__FileNameMap.staticClass, "java.net.FileNameMap.getContentTypeFor", "(Ljava/lang/String;)Ljava/lang/String;"); 
		} 
	} 
} 
