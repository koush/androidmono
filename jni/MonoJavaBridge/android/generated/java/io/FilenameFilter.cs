namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.FilenameFilter_))]
	public interface FilenameFilter  : global::MonoJavaBridge.IJavaObject 
	{
		bool accept(java.io.File arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.FilenameFilter))]
	public sealed partial class FilenameFilter_ : java.lang.Object, FilenameFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FilenameFilter_()
		{
			InitJNI();
		}
		internal FilenameFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _accept18939;
		 bool java.io.FilenameFilter.accept(java.io.File arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FilenameFilter_._accept18939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FilenameFilter_.staticClass, global::java.io.FilenameFilter_._accept18939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilenameFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilenameFilter"));
			global::java.io.FilenameFilter_._accept18939 = @__env.GetMethodIDNoThrow(global::java.io.FilenameFilter_.staticClass, "accept", "(Ljava/io/File;Ljava/lang/String;)Z");
		}
	}
}
