namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.FileFilter_))]
	public partial interface FileFilter  : global::MonoJavaBridge.IJavaObject 
	{
		bool accept(java.io.File arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.FileFilter))]
	internal sealed partial class FileFilter_ : java.lang.Object, FileFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FileFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.io.FileFilter.accept(java.io.File arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.FileFilter_.staticClass, "accept", "(Ljava/io/File;)Z", ref global::java.io.FileFilter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static FileFilter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileFilter"));
		}
	}
}
