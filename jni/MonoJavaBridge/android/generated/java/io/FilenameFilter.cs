namespace java.io
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface FilenameFilter 
	{
		bool accept(java.io.File arg0, java.lang.String arg1);
	}

	public partial class FilenameFilter_
	{
		public static global::java.lang.Class _class
		{
			get { return __FilenameFilter.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __FilenameFilter : java.lang.Object, FilenameFilter
	{
		internal static global::java.lang.Class staticClass;
		static __FilenameFilter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.io.__FilenameFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.io.__FilenameFilter(@__env);
			}
		}
		internal __FilenameFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _accept12125;
		 bool java.io.FilenameFilter.accept(java.io.File arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.io.__FilenameFilter._accept12125, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.__FilenameFilter.staticClass, global::java.io.__FilenameFilter._accept12125, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.io.__FilenameFilter.staticClass = @__class;
			global::java.io.__FilenameFilter._accept12125 = @__env.GetMethodID(global::java.io.__FilenameFilter.staticClass, "java.io.FilenameFilter.accept", "(Ljava/io/File;Ljava/lang/String;)Z");
		}
	}
}
