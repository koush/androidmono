namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Attributes2Impl : org.xml.sax.helpers.AttributesImpl, Attributes2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Attributes2Impl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void addAttribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.Attributes2Impl._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void removeAttribute(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "removeAttribute", "(I)V", ref global::org.xml.sax.ext.Attributes2Impl._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.Attributes Attributes
		{
			set
			{
				setAttributes(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setAttributes(org.xml.sax.Attributes arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "setAttributes", "(Lorg/xml/sax/Attributes;)V", ref global::org.xml.sax.ext.Attributes2Impl._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool isSpecified(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2Impl._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isSpecified(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(I)Z", ref global::org.xml.sax.ext.Attributes2Impl._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isSpecified(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2Impl._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isDeclared(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2Impl._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isDeclared(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2Impl._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isDeclared(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(I)Z", ref global::org.xml.sax.ext.Attributes2Impl._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setDeclared(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "setDeclared", "(IZ)V", ref global::org.xml.sax.ext.Attributes2Impl._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setSpecified(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "setSpecified", "(IZ)V", ref global::org.xml.sax.ext.Attributes2Impl._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Attributes2Impl(org.xml.sax.Attributes arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.ext.Attributes2Impl._m11.native == global::System.IntPtr.Zero)
				global::org.xml.sax.ext.Attributes2Impl._m11 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "<init>", "(Lorg/xml/sax/Attributes;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public Attributes2Impl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.ext.Attributes2Impl._m12.native == global::System.IntPtr.Zero)
				global::org.xml.sax.ext.Attributes2Impl._m12 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._m12);
			Init(@__env, handle);
		}
		static Attributes2Impl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Attributes2Impl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Attributes2Impl"));
		}
		internal static void InitJNI()
		{
		}
	}
}
