namespace java.security
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Principal 
	{
		bool equals(java.lang.Object arg0);
		global::java.lang.String toString();
		int hashCode();
		global::java.lang.String getName();
	}

	public partial class Principal_
	{
		public static global::java.lang.Class _class
		{
			get { return __Principal.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Principal : java.lang.Object, Principal
	{
		internal static global::java.lang.Class staticClass;
		static __Principal()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.__Principal), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.security.__Principal(@__env);
			}
		}
		internal __Principal(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13236;
		 bool java.security.Principal.equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.security.__Principal._equals13236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.__Principal.staticClass, global::java.security.__Principal._equals13236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13237;
		 global::java.lang.String java.security.Principal.toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.__Principal._toString13237));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.__Principal.staticClass, global::java.security.__Principal._toString13237));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13238;
		 int java.security.Principal.hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.security.__Principal._hashCode13238);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.security.__Principal.staticClass, global::java.security.__Principal._hashCode13238);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName13239;
		 global::java.lang.String java.security.Principal.getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.__Principal._getName13239));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.__Principal.staticClass, global::java.security.__Principal._getName13239));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.__Principal.staticClass = @__class;
			global::java.security.__Principal._equals13236 = @__env.GetMethodID(global::java.security.__Principal.staticClass, "java.security.Principal.equals", "(Ljava/lang/Object;)Z");
			global::java.security.__Principal._toString13237 = @__env.GetMethodID(global::java.security.__Principal.staticClass, "java.security.Principal.toString", "()Ljava/lang/String;");
			global::java.security.__Principal._hashCode13238 = @__env.GetMethodID(global::java.security.__Principal.staticClass, "java.security.Principal.hashCode", "()I");
			global::java.security.__Principal._getName13239 = @__env.GetMethodID(global::java.security.__Principal.staticClass, "java.security.Principal.getName", "()Ljava/lang/String;");
		}
	}
}
