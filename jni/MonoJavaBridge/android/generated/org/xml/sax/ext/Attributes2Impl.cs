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
		internal static global::MonoJavaBridge.MethodId _addAttribute28225;
		public override void addAttribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._addAttribute28225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._addAttribute28225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute28226;
		public override void removeAttribute(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._removeAttribute28226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._removeAttribute28226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttributes28227;
		public override void setAttributes(org.xml.sax.Attributes arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._setAttributes28227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._setAttributes28227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified28228;
		public virtual bool isSpecified(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isSpecified28228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isSpecified28228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified28229;
		public virtual bool isSpecified(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isSpecified28229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isSpecified28229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified28230;
		public virtual bool isSpecified(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isSpecified28230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isSpecified28230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared28231;
		public virtual bool isDeclared(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isDeclared28231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isDeclared28231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared28232;
		public virtual bool isDeclared(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isDeclared28232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isDeclared28232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared28233;
		public virtual bool isDeclared(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isDeclared28233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isDeclared28233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDeclared28234;
		public virtual void setDeclared(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._setDeclared28234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._setDeclared28234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSpecified28235;
		public virtual void setSpecified(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._setSpecified28235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._setSpecified28235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Attributes2Impl28236;
		public Attributes2Impl(org.xml.sax.Attributes arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl28236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Attributes2Impl28237;
		public Attributes2Impl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl28237);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Attributes2Impl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Attributes2Impl"));
			global::org.xml.sax.ext.Attributes2Impl._addAttribute28225 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.Attributes2Impl._removeAttribute28226 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "removeAttribute", "(I)V");
			global::org.xml.sax.ext.Attributes2Impl._setAttributes28227 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "setAttributes", "(Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.ext.Attributes2Impl._isSpecified28228 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isSpecified28229 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(I)Z");
			global::org.xml.sax.ext.Attributes2Impl._isSpecified28230 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isDeclared28231 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isDeclared28232 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isDeclared28233 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(I)Z");
			global::org.xml.sax.ext.Attributes2Impl._setDeclared28234 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "setDeclared", "(IZ)V");
			global::org.xml.sax.ext.Attributes2Impl._setSpecified28235 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "setSpecified", "(IZ)V");
			global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl28236 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "<init>", "(Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl28237 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "<init>", "()V");
		}
	}
}
