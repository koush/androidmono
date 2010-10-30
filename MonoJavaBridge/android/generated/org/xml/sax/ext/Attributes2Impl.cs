namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Attributes2Impl : org.xml.sax.helpers.AttributesImpl, Attributes2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Attributes2Impl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addAttribute35095;
		public override void addAttribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.Attributes2Impl._addAttribute35095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute35096;
		public override void removeAttribute(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "removeAttribute", "(I)V", ref global::org.xml.sax.ext.Attributes2Impl._removeAttribute35096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.Attributes Attributes
		{
			set
			{
				setAttributes(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAttributes35097;
		public override void setAttributes(org.xml.sax.Attributes arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "setAttributes", "(Lorg/xml/sax/Attributes;)V", ref global::org.xml.sax.ext.Attributes2Impl._setAttributes35097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified35098;
		public virtual bool isSpecified(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2Impl._isSpecified35098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified35099;
		public virtual bool isSpecified(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(I)Z", ref global::org.xml.sax.ext.Attributes2Impl._isSpecified35099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified35100;
		public virtual bool isSpecified(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2Impl._isSpecified35100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared35101;
		public virtual bool isDeclared(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2Impl._isDeclared35101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared35102;
		public virtual bool isDeclared(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.xml.sax.ext.Attributes2Impl._isDeclared35102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared35103;
		public virtual bool isDeclared(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(I)Z", ref global::org.xml.sax.ext.Attributes2Impl._isDeclared35103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDeclared35104;
		public virtual void setDeclared(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "setDeclared", "(IZ)V", ref global::org.xml.sax.ext.Attributes2Impl._setDeclared35104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSpecified35105;
		public virtual void setSpecified(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Attributes2Impl.staticClass, "setSpecified", "(IZ)V", ref global::org.xml.sax.ext.Attributes2Impl._setSpecified35105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Attributes2Impl35106;
		public Attributes2Impl(org.xml.sax.Attributes arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl35106.native == global::System.IntPtr.Zero)
				global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl35106 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "<init>", "(Lorg/xml/sax/Attributes;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl35106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Attributes2Impl35107;
		public Attributes2Impl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl35107.native == global::System.IntPtr.Zero)
				global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl35107 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl35107);
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
