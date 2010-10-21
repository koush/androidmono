namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Attributes2Impl : org.xml.sax.helpers.AttributesImpl, Attributes2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Attributes2Impl()
		{
			InitJNI();
		}
		protected Attributes2Impl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addAttribute34976;
		public override void addAttribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._addAttribute34976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._addAttribute34976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute34977;
		public override void removeAttribute(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._removeAttribute34977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._removeAttribute34977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttributes34978;
		public override void setAttributes(org.xml.sax.Attributes arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._setAttributes34978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._setAttributes34978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified34979;
		public virtual bool isSpecified(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isSpecified34979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isSpecified34979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified34980;
		public virtual bool isSpecified(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isSpecified34980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isSpecified34980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified34981;
		public virtual bool isSpecified(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isSpecified34981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isSpecified34981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared34982;
		public virtual bool isDeclared(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isDeclared34982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isDeclared34982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared34983;
		public virtual bool isDeclared(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isDeclared34983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isDeclared34983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared34984;
		public virtual bool isDeclared(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isDeclared34984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isDeclared34984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDeclared34985;
		public virtual void setDeclared(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._setDeclared34985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._setDeclared34985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSpecified34986;
		public virtual void setSpecified(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._setSpecified34986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._setSpecified34986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Attributes2Impl34987;
		public Attributes2Impl(org.xml.sax.Attributes arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl34987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Attributes2Impl34988;
		public Attributes2Impl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl34988);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Attributes2Impl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Attributes2Impl"));
			global::org.xml.sax.ext.Attributes2Impl._addAttribute34976 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.Attributes2Impl._removeAttribute34977 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "removeAttribute", "(I)V");
			global::org.xml.sax.ext.Attributes2Impl._setAttributes34978 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "setAttributes", "(Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.ext.Attributes2Impl._isSpecified34979 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isSpecified34980 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(I)Z");
			global::org.xml.sax.ext.Attributes2Impl._isSpecified34981 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isDeclared34982 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isDeclared34983 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isDeclared34984 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(I)Z");
			global::org.xml.sax.ext.Attributes2Impl._setDeclared34985 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "setDeclared", "(IZ)V");
			global::org.xml.sax.ext.Attributes2Impl._setSpecified34986 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "setSpecified", "(IZ)V");
			global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl34987 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "<init>", "(Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl34988 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "<init>", "()V");
		}
	}
}
