namespace java.io
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class IOException : java.lang.Exception
	{
		internal static global::java.lang.Class staticClass;
		static IOException()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.io.IOException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.io.IOException(@__env);
			}
		}
		protected IOException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _IOException12136;
		public IOException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException12136, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _IOException12137;
		public IOException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException12137, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _IOException12138;
		public IOException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException12138, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _IOException12139;
		public IOException(java.lang.Throwable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.IOException.staticClass, global::java.io.IOException._IOException12139, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.io.IOException.staticClass = @__class;
			global::java.io.IOException._IOException12136 = @__env.GetMethodID(global::java.io.IOException.staticClass, "<init>", "()V");
			global::java.io.IOException._IOException12137 = @__env.GetMethodID(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.IOException._IOException12138 = @__env.GetMethodID(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.io.IOException._IOException12139 = @__env.GetMethodID(global::java.io.IOException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
