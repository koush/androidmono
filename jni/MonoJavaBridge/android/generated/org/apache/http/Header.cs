namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Header 
	{
		global::java.lang.String getName();
		global::java.lang.String getValue();
		global::org.apache.http.HeaderElement[] getElements();
	}

	public partial class Header_
	{
		public static global::java.lang.Class _class
		{
			get { return __Header.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Header : java.lang.Object, Header
	{
		internal static global::java.lang.Class staticClass;
		static __Header()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__Header), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__Header(@__env);
			}
		}
		internal __Header(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName14191;
		 global::java.lang.String org.apache.http.Header.getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__Header._getName14191));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__Header.staticClass, global::org.apache.http.__Header._getName14191));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue14192;
		 global::java.lang.String org.apache.http.Header.getValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__Header._getValue14192));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__Header.staticClass, global::org.apache.http.__Header._getValue14192));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getElements14193;
		 global::org.apache.http.HeaderElement[] org.apache.http.Header.getElements() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__Header._getElements14193));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__Header.staticClass, global::org.apache.http.__Header._getElements14193));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__Header.staticClass = @__class;
			global::org.apache.http.__Header._getName14191 = @__env.GetMethodID(global::org.apache.http.__Header.staticClass, "org.apache.http.Header.getName", "()Ljava/lang/String;");
			global::org.apache.http.__Header._getValue14192 = @__env.GetMethodID(global::org.apache.http.__Header.staticClass, "org.apache.http.Header.getValue", "()Ljava/lang/String;");
			global::org.apache.http.__Header._getElements14193 = @__env.GetMethodID(global::org.apache.http.__Header.staticClass, "org.apache.http.Header.getElements", "()[Lorg/apache/http/HeaderElement;");
		}
	}
}
