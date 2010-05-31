namespace org.xml.sax
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface EntityResolver 
	{
		global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1);
	}

	public partial class EntityResolver_
	{
		public static global::java.lang.Class _class
		{
			get { return __EntityResolver.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __EntityResolver : java.lang.Object, EntityResolver
	{
		internal static global::java.lang.Class staticClass;
		static __EntityResolver()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.xml.sax.__EntityResolver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.xml.sax.__EntityResolver(@__env);
			}
		}
		internal __EntityResolver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _resolveEntity13302;
		 global::org.xml.sax.InputSource org.xml.sax.EntityResolver.resolveEntity(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.xml.sax.InputSource>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__EntityResolver._resolveEntity13302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.xml.sax.InputSource>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__EntityResolver.staticClass, global::org.xml.sax.__EntityResolver._resolveEntity13302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.xml.sax.__EntityResolver.staticClass = @__class;
			global::org.xml.sax.__EntityResolver._resolveEntity13302 = @__env.GetMethodID(global::org.xml.sax.__EntityResolver.staticClass, "org.xml.sax.EntityResolver.resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
		}
	}
}
