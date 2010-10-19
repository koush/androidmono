namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XmlPullParserException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XmlPullParserException()
		{
			InitJNI();
		}
		protected XmlPullParserException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace28478;
		public override void printStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException._printStackTrace28478);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._printStackTrace28478);
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber28479;
		public virtual int getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException._getLineNumber28479);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._getLineNumber28479);
		}
		public new int ColumnNumber
		{
			get
			{
				return getColumnNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber28480;
		public virtual int getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException._getColumnNumber28480);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._getColumnNumber28480);
		}
		public new global::java.lang.Throwable Detail
		{
			get
			{
				return getDetail();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDetail28481;
		public virtual global::java.lang.Throwable getDetail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException._getDetail28481)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._getDetail28481)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _XmlPullParserException28482;
		public XmlPullParserException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._XmlPullParserException28482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XmlPullParserException28483;
		public XmlPullParserException(java.lang.String arg0, org.xmlpull.v1.XmlPullParser arg1, java.lang.Throwable arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._XmlPullParserException28483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlPullParserException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlPullParserException"));
			global::org.xmlpull.v1.XmlPullParserException._printStackTrace28478 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "printStackTrace", "()V");
			global::org.xmlpull.v1.XmlPullParserException._getLineNumber28479 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "getLineNumber", "()I");
			global::org.xmlpull.v1.XmlPullParserException._getColumnNumber28480 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "getColumnNumber", "()I");
			global::org.xmlpull.v1.XmlPullParserException._getDetail28481 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "getDetail", "()Ljava/lang/Throwable;");
			global::org.xmlpull.v1.XmlPullParserException._XmlPullParserException28482 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlPullParserException._XmlPullParserException28483 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xmlpull/v1/XmlPullParser;Ljava/lang/Throwable;)V");
		}
	}
}
