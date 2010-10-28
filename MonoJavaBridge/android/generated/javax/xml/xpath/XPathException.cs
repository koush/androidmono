namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XPathException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XPathException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace31298;
		public override void printStackTrace(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException._printStackTrace31298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._printStackTrace31298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace31299;
		public override void printStackTrace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException._printStackTrace31299);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._printStackTrace31299);
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace31300;
		public override void printStackTrace(java.io.PrintWriter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException._printStackTrace31300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._printStackTrace31300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCause31301;
		public override global::java.lang.Throwable getCause()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathException._getCause31301)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._getCause31301)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _XPathException31302;
		public XPathException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._XPathException31302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XPathException31303;
		public XPathException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._XPathException31303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static XPathException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathException"));
			global::javax.xml.xpath.XPathException._printStackTrace31298 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V");
			global::javax.xml.xpath.XPathException._printStackTrace31299 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "printStackTrace", "()V");
			global::javax.xml.xpath.XPathException._printStackTrace31300 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V");
			global::javax.xml.xpath.XPathException._getCause31301 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::javax.xml.xpath.XPathException._XPathException31302 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.xpath.XPathException._XPathException31303 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
