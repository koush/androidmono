namespace java.net
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.net.FileNameMap_))]
	public partial interface FileNameMap  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getContentTypeFor(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.FileNameMap))]
	internal sealed partial class FileNameMap_ : java.lang.Object, FileNameMap
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FileNameMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContentTypeFor21466;
		global::java.lang.String java.net.FileNameMap.getContentTypeFor(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.FileNameMap_.staticClass, "getContentTypeFor", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.net.FileNameMap_._getContentTypeFor21466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		static FileNameMap_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.FileNameMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/FileNameMap"));
		}
		internal static void InitJNI()
		{
		}
	}
}
