namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XmlPullParserException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XmlPullParserException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void printStackTrace()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.XmlPullParserException.staticClass, "printStackTrace", "()V", ref global::org.xmlpull.v1.XmlPullParserException._m0);
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParserException.staticClass, "getLineNumber", "()I", ref global::org.xmlpull.v1.XmlPullParserException._m1);
		}
		public new int ColumnNumber
		{
			get
			{
				return getColumnNumber();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.XmlPullParserException.staticClass, "getColumnNumber", "()I", ref global::org.xmlpull.v1.XmlPullParserException._m2);
		}
		public new global::java.lang.Throwable Detail
		{
			get
			{
				return getDetail();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Throwable getDetail()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xmlpull.v1.XmlPullParserException.staticClass, "getDetail", "()Ljava/lang/Throwable;", ref global::org.xmlpull.v1.XmlPullParserException._m3) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public XmlPullParserException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParserException._m4.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParserException._m4 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public XmlPullParserException(java.lang.String arg0, org.xmlpull.v1.XmlPullParser arg1, java.lang.Throwable arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.XmlPullParserException._m5.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.XmlPullParserException._m5 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xmlpull/v1/XmlPullParser;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static XmlPullParserException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlPullParserException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlPullParserException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
