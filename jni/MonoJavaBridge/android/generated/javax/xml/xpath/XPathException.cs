namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XPathException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XPathException()
		{
			InitJNI();
		}
		protected XPathException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace24693;
		public override void printStackTrace(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException._printStackTrace24693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._printStackTrace24693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace24694;
		public override void printStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException._printStackTrace24694);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._printStackTrace24694);
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace24695;
		public override void printStackTrace(java.io.PrintWriter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException._printStackTrace24695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._printStackTrace24695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCause24696;
		public override global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathException._getCause24696)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._getCause24696)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _XPathException24697;
		public XPathException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._XPathException24697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XPathException24698;
		public XPathException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.xpath.XPathException.staticClass, global::javax.xml.xpath.XPathException._XPathException24698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathException"));
			global::javax.xml.xpath.XPathException._printStackTrace24693 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V");
			global::javax.xml.xpath.XPathException._printStackTrace24694 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "printStackTrace", "()V");
			global::javax.xml.xpath.XPathException._printStackTrace24695 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V");
			global::javax.xml.xpath.XPathException._getCause24696 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::javax.xml.xpath.XPathException._XPathException24697 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.xpath.XPathException._XPathException24698 = @__env.GetMethodIDNoThrow(global::javax.xml.xpath.XPathException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
