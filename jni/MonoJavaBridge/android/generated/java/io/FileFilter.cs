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
		static FileFilter_()
		{
			InitJNI();
		}
		internal FileFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _accept19016;
		bool java.io.FileFilter.accept(java.io.File arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FileFilter_._accept19016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FileFilter_.staticClass, global::java.io.FileFilter_._accept19016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FileFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FileFilter"));
			global::java.io.FileFilter_._accept19016 = @__env.GetMethodIDNoThrow(global::java.io.FileFilter_.staticClass, "accept", "(Ljava/io/File;)Z");
		}
	}
}
