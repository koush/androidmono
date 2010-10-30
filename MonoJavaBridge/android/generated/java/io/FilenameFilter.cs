namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.FilenameFilter_))]
	public partial interface FilenameFilter  : global::MonoJavaBridge.IJavaObject 
	{
		bool accept(java.io.File arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.FilenameFilter))]
	internal sealed partial class FilenameFilter_ : java.lang.Object, FilenameFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FilenameFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.io.FilenameFilter.accept(java.io.File arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FilenameFilter_.staticClass, "accept", "(Ljava/io/File;Ljava/lang/String;)Z", ref global::java.io.FilenameFilter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static FilenameFilter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilenameFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilenameFilter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
