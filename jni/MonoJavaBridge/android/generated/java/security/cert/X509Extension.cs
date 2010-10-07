namespace java.security.cert
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface X509Extension 
	{
		bool hasUnsupportedCriticalExtension();
		global::java.util.Set getCriticalExtensionOIDs();
		global::java.util.Set getNonCriticalExtensionOIDs();
		byte[] getExtensionValue(java.lang.String arg0);
	}

	public partial class X509Extension_
	{
		public static global::java.lang.Class _class
		{
			get { return __X509Extension.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __X509Extension : java.lang.Object, X509Extension
	{
		internal static global::java.lang.Class staticClass;
		static __X509Extension()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.cert.__X509Extension), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.security.cert.__X509Extension(@__env);
			}
		}
		internal __X509Extension(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasUnsupportedCriticalExtension13352;
		 bool java.security.cert.X509Extension.hasUnsupportedCriticalExtension() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.cert.__X509Extension._hasUnsupportedCriticalExtension13352);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.cert.__X509Extension.staticClass, global::java.security.cert.__X509Extension._hasUnsupportedCriticalExtension13352);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCriticalExtensionOIDs13353;
		 global::java.util.Set java.security.cert.X509Extension.getCriticalExtensionOIDs() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.__X509Extension._getCriticalExtensionOIDs13353));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.__X509Extension.staticClass, global::java.security.cert.__X509Extension._getCriticalExtensionOIDs13353));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNonCriticalExtensionOIDs13354;
		 global::java.util.Set java.security.cert.X509Extension.getNonCriticalExtensionOIDs() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.__X509Extension._getNonCriticalExtensionOIDs13354));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.__X509Extension.staticClass, global::java.security.cert.__X509Extension._getNonCriticalExtensionOIDs13354));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtensionValue13355;
		 byte[] java.security.cert.X509Extension.getExtensionValue(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.cert.__X509Extension._getExtensionValue13355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.cert.__X509Extension.staticClass, global::java.security.cert.__X509Extension._getExtensionValue13355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.cert.__X509Extension.staticClass = @__class;
			global::java.security.cert.__X509Extension._hasUnsupportedCriticalExtension13352 = @__env.GetMethodID(global::java.security.cert.__X509Extension.staticClass, "java.security.cert.X509Extension.hasUnsupportedCriticalExtension", "()Z");
			global::java.security.cert.__X509Extension._getCriticalExtensionOIDs13353 = @__env.GetMethodID(global::java.security.cert.__X509Extension.staticClass, "java.security.cert.X509Extension.getCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.__X509Extension._getNonCriticalExtensionOIDs13354 = @__env.GetMethodID(global::java.security.cert.__X509Extension.staticClass, "java.security.cert.X509Extension.getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
			global::java.security.cert.__X509Extension._getExtensionValue13355 = @__env.GetMethodID(global::java.security.cert.__X509Extension.staticClass, "java.security.cert.X509Extension.getExtensionValue", "(Ljava/lang/String;)[B");
		}
	}
}
