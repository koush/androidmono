namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface NameValuePair 
	{
		global::java.lang.String getName();
		global::java.lang.String getValue();
	}

	public partial class NameValuePair_
	{
		public static global::java.lang.Class _class
		{
			get { return __NameValuePair.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __NameValuePair : java.lang.Object, NameValuePair
	{
		internal static global::java.lang.Class staticClass;
		static __NameValuePair()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__NameValuePair), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__NameValuePair(@__env);
			}
		}
		internal __NameValuePair(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName14347;
		 global::java.lang.String org.apache.http.NameValuePair.getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__NameValuePair._getName14347));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__NameValuePair.staticClass, global::org.apache.http.__NameValuePair._getName14347));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue14348;
		 global::java.lang.String org.apache.http.NameValuePair.getValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__NameValuePair._getValue14348));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__NameValuePair.staticClass, global::org.apache.http.__NameValuePair._getValue14348));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__NameValuePair.staticClass = @__class;
			global::org.apache.http.__NameValuePair._getName14347 = @__env.GetMethodID(global::org.apache.http.__NameValuePair.staticClass, "org.apache.http.NameValuePair.getName", "()Ljava/lang/String;");
			global::org.apache.http.__NameValuePair._getValue14348 = @__env.GetMethodID(global::org.apache.http.__NameValuePair.staticClass, "org.apache.http.NameValuePair.getValue", "()Ljava/lang/String;");
		}
	}
}
