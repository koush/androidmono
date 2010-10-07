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
		internal static global::net.sf.jni4net.jni.MethodId _getEncoded13278;
		 byte[] java.security.Key.getEncoded() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.__PublicKey._getEncoded13278));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.__PublicKey.staticClass, global::java.security.__PublicKey._getEncoded13278));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAlgorithm13279;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.__PublicKey._getAlgorithm13279));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.__PublicKey.staticClass, global::java.security.__PublicKey._getAlgorithm13279));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFormat13280;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.__PublicKey._getFormat13280));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.__PublicKey.staticClass, global::java.security.__PublicKey._getFormat13280));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.__PublicKey.staticClass = @__class;
			global::java.security.__PublicKey._getEncoded13278 = @__env.GetMethodID(global::java.security.__PublicKey.staticClass, "java.security.Key.getEncoded", "()[B");
			global::java.security.__PublicKey._getAlgorithm13279 = @__env.GetMethodID(global::java.security.__PublicKey.staticClass, "java.security.Key.getAlgorithm", "()Ljava/lang/String;");
			global::java.security.__PublicKey._getFormat13280 = @__env.GetMethodID(global::java.security.__PublicKey.staticClass, "java.security.Key.getFormat", "()Ljava/lang/String;");
		}
	}
}
