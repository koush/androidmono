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
		static FileNameMap_()
		{
			InitJNI();
		}
		internal FileNameMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContentTypeFor21465;
		 global::java.lang.String java.net.FileNameMap.getContentTypeFor(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.FileNameMap_._getContentTypeFor21465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.FileNameMap_.staticClass, global::java.net.FileNameMap_._getContentTypeFor21465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.FileNameMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/FileNameMap"));
			global::java.net.FileNameMap_._getContentTypeFor21465 = @__env.GetMethodIDNoThrow(global::java.net.FileNameMap_.staticClass, "getContentTypeFor", "(Ljava/lang/String;)Ljava/lang/String;");
		}
	}
}
