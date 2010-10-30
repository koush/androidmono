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
		internal static global::MonoJavaBridge.MethodId _accept19057;
		bool java.io.FilenameFilter.accept(java.io.File arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.FilenameFilter_._accept19057.native == global::System.IntPtr.Zero)
				global::java.io.FilenameFilter_._accept19057 = @__env.GetMethodIDNoThrow(global::java.io.FilenameFilter_.staticClass, "accept", "(Ljava/io/File;Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FilenameFilter_._accept19057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
