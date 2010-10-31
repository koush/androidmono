namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XPathException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XPathException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void printStackTrace(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.xpath.XPathException.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V", ref global::javax.xml.xpath.XPathException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void printStackTrace()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.xpath.XPathException.staticClass, "printStackTrace", "()V", ref global::javax.xml.xpath.XPathException._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void printStackTrace(java.io.PrintWriter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.xpath.XPathException.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V", ref global::javax.xml.xpath.XPathException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.xpath.XPathException.staticClass, "getCause", "()Ljava/lang/Throwable;", ref global::javax.xml.xpath.XPathException._m3) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public XPathException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathException._m4.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathException._m4 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public XPathException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.xpath.XPathException._m5.native == global::System.IntPtr.Zero)
				global::javax.xml.xpath.XPathException._m5 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static XPathException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathException"));
		}
	}
}
