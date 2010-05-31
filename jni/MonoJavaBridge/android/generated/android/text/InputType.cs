namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface InputType 
	{
	}

	public partial class InputType_
	{
		public static global::java.lang.Class _class
		{
			get { return __InputType.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __InputType : java.lang.Object, InputType
	{
		internal static global::java.lang.Class staticClass;
		static __InputType()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.__InputType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.__InputType(@__env);
			}
		}
		internal __InputType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.__InputType.staticClass = @__class;
		}
	}
}
