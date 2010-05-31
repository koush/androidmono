namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface PublicKey : Key
	{ 
	} 

	public partial class PublicKey_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __PublicKey.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __PublicKey : java.lang.Object, PublicKey
	{ 
		internal static global::java.lang.Class staticClass; 
		static __PublicKey() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.__PublicKey), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.security.__PublicKey(@__env); 
			} 
		} 
		internal __PublicKey(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlgorithm12468; 
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.__PublicKey._getAlgorithm12468)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.__PublicKey.staticClass, global::java.security.__PublicKey._getAlgorithm12468)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded12469; 
		 byte[] java.security.Key.getEncoded() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.__PublicKey._getEncoded12469)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.__PublicKey.staticClass, global::java.security.__PublicKey._getEncoded12469)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFormat12470; 
		 global::java.lang.String java.security.Key.getFormat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.__PublicKey._getFormat12470)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.__PublicKey.staticClass, global::java.security.__PublicKey._getFormat12470)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.__PublicKey.staticClass = @__class; 
			global::java.security.__PublicKey._getAlgorithm12468 = @__env.GetMethodID(global::java.security.__PublicKey.staticClass, "java.security.Key.getAlgorithm", "()Ljava/lang/String;"); 
			global::java.security.__PublicKey._getEncoded12469 = @__env.GetMethodID(global::java.security.__PublicKey.staticClass, "java.security.Key.getEncoded", "()[B"); 
			global::java.security.__PublicKey._getFormat12470 = @__env.GetMethodID(global::java.security.__PublicKey.staticClass, "java.security.Key.getFormat", "()Ljava/lang/String;"); 
		} 
	} 
} 
