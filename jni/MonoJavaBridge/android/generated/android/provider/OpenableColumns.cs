namespace android.provider
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface OpenableColumns 
	{
	}

	public partial class OpenableColumns_
	{
		public static global::java.lang.Class _class
		{
			get { return __OpenableColumns.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __OpenableColumns : java.lang.Object, OpenableColumns
	{
		internal static global::java.lang.Class staticClass;
		static __OpenableColumns()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.__OpenableColumns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.provider.__OpenableColumns(@__env);
			}
		}
		internal __OpenableColumns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.provider.__OpenableColumns.staticClass = @__class;
		}
	}
}
