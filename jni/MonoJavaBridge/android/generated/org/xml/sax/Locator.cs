namespace org.xml.sax
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Locator 
	{
		int getLineNumber();
		global::java.lang.String getPublicId();
		global::java.lang.String getSystemId();
		int getColumnNumber();
	}

	public partial class Locator_
	{
		public static global::java.lang.Class _class
		{
			get { return __Locator.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Locator : java.lang.Object, Locator
	{
		internal static global::java.lang.Class staticClass;
		static __Locator()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.xml.sax.__Locator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.xml.sax.__Locator(@__env);
			}
		}
		internal __Locator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineNumber14599;
		 int org.xml.sax.Locator.getLineNumber() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xml.sax.__Locator._getLineNumber14599);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xml.sax.__Locator.staticClass, global::org.xml.sax.__Locator._getLineNumber14599);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPublicId14600;
		 global::java.lang.String org.xml.sax.Locator.getPublicId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__Locator._getPublicId14600));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__Locator.staticClass, global::org.xml.sax.__Locator._getPublicId14600));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSystemId14601;
		 global::java.lang.String org.xml.sax.Locator.getSystemId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__Locator._getSystemId14601));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__Locator.staticClass, global::org.xml.sax.__Locator._getSystemId14601));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNumber14602;
		 int org.xml.sax.Locator.getColumnNumber() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xml.sax.__Locator._getColumnNumber14602);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xml.sax.__Locator.staticClass, global::org.xml.sax.__Locator._getColumnNumber14602);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.xml.sax.__Locator.staticClass = @__class;
			global::org.xml.sax.__Locator._getLineNumber14599 = @__env.GetMethodID(global::org.xml.sax.__Locator.staticClass, "org.xml.sax.Locator.getLineNumber", "()I");
			global::org.xml.sax.__Locator._getPublicId14600 = @__env.GetMethodID(global::org.xml.sax.__Locator.staticClass, "org.xml.sax.Locator.getPublicId", "()Ljava/lang/String;");
			global::org.xml.sax.__Locator._getSystemId14601 = @__env.GetMethodID(global::org.xml.sax.__Locator.staticClass, "org.xml.sax.Locator.getSystemId", "()Ljava/lang/String;");
			global::org.xml.sax.__Locator._getColumnNumber14602 = @__env.GetMethodID(global::org.xml.sax.__Locator.staticClass, "org.xml.sax.Locator.getColumnNumber", "()I");
		}
	}
}
